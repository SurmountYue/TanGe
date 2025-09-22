using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Airtightness.Core.Presenters;
using Airtightness.Core.Interfaces;
using Airtightness.Core.Enums;
using Airtightness.MES;
using Airtightness.Hardware;

namespace TanGe
{
    public partial class MainForm : Form
    {
        // ====== 字段：Presenter/硬件/MES/调试轮询 ======
        private WorkstationPresenter _wsPresenter1;
        private WorkstationPresenter _wsPresenter2;
        // 连接状态（懒连接标记）
        private bool _ws1Connected = false;
        private bool _ws2Connected = false;


        private IInstrument _debugInstrument; // 调试页专用实例（与你的生产实例可分离）
        private CancellationTokenSource _debugPollCts;

        // 简单配置缓存（Settings页）
        private AppConfig _config = new AppConfig();

        public MainForm()
        {
            InitializeComponent();
            // 隐藏 Tab 页签，使用上方按钮导航
            SafeHideTabHeaders();

            // 初始化页面事件绑定
            BindNavigation();
            BindSettingsPage();
            BindHistoryPage();
            BindDebugPage();
            BindTestPageAndPresenters(); // 放最后，因其包含异步连接
        }

        // ========== 导航与Tab隐藏 ==========
        private void SafeHideTabHeaders()
        {
            try
            {
                tabControl.Appearance = TabAppearance.FlatButtons;
                tabControl.ItemSize = new Size(0, 1);
                tabControl.SizeMode = TabSizeMode.Fixed;
            }
            catch { /* 设计时可能空引用 */ }
        }

        private void BindNavigation()
        {
            // 这些按钮名称按你的Designer调整
            btnNavTest.Click += (s, e) => SwitchTab(tabPageTest, btnNavTest);
            btnNavParams.Click += (s, e) => SwitchTab(tabPageParams, btnNavParams);
            btnNavDebug.Click += (s, e) => SwitchTab(tabPageDebug, btnNavDebug);
            btnNavSettings.Click += (s, e) => SwitchTab(tabPageSettings, btnNavSettings);
            btnNavHistory.Click += (s, e) => SwitchTab(tabPageHistory, btnNavHistory);

            // 默认进入测试页
            SwitchTab(tabPageTest, btnNavTest);
        }

        private void SwitchTab(TabPage page, Button activeButton)
        {
            tabControl.SelectedTab = page;

            // 高亮当前导航按钮
            var all = new[] { btnNavTest, btnNavParams, btnNavDebug, btnNavSettings, btnNavHistory };
            foreach (var b in all) b.BackColor = Color.LightGray;
            activeButton.BackColor = Color.White;
        }

        // ========== 测试页与Presenter绑定 ==========
        private void BindTestPageAndPresenters()
        {
            // 这里用配置创建 MES 服务；MesService内部URL默认可改为读取_config.MesUrl
            var mes = new MesService();

            // 工位1/工位2 使用 Modbus TCP（如需RTU，根据Settings选择不同实现）
            var instr1 = new ModbusInstrument();
            var instr2 = new ModbusInstrument();

            _wsPresenter1 = new WorkstationPresenter("工位1", instr1, mes);
            _wsPresenter2 = new WorkstationPresenter("工位2", instr2, mes);

            // 绑定工位1事件到 WorkstationView1
            // 注意：以下方法名需与你的 WorkstationView 实际提供的方法一致
            _wsPresenter1.StateChanged += (state, msg) => workstationView1.UpdateStatus(msg, StateColor(state));
            _wsPresenter1.LogMessageGenerated += (line) =>
            {
                workstationView1.AppendLog(line); // 若无该方法，可改写到全局日志
                AppendGlobalLog(line);
            };
            _wsPresenter1.CommunicationLogGenerated += (type, msg) => AppendGlobalLog($"[{type}] {msg}");
            _wsPresenter1.RealtimeDataUpdated += (leak, press, temp) => workstationView1.UpdateRealtimeData(leak, press, temp);
            _wsPresenter1.StatisticsUpdated += (tot, ok, ng) => workstationView1.UpdateStatistics(tot, ok, ng);

            // 绑定工位2事件到 WorkstationView2
            _wsPresenter2.StateChanged += (state, msg) => workstationView2.UpdateStatus(msg, StateColor(state));
            _wsPresenter2.LogMessageGenerated += (line) =>
            {
                workstationView2.AppendLog(line);
                AppendGlobalLog(line);
            };
            _wsPresenter2.CommunicationLogGenerated += (type, msg) => AppendGlobalLog($"[{type}] {msg}");
            _wsPresenter2.RealtimeDataUpdated += (leak, press, temp) => workstationView2.UpdateRealtimeData(leak, press, temp);
            _wsPresenter2.StatisticsUpdated += (tot, ok, ng) => workstationView2.UpdateStatistics(tot, ok, ng);

            // WorkstationView 按钮事件 → Presenter
            workstationView1.StartRequested += async (s, e) => await _wsPresenter1.StartTestAsync();
            workstationView1.StopRequested += (s, e) => _wsPresenter1.StopTest();
            workstationView1.ClearStatsRequested += (s, e) => { /* TODO: 若Presenter未提供Reset方法，可在控件内清零 */ };

            workstationView2.StartRequested += async (s, e) => await _wsPresenter2.StartTestAsync();
            workstationView2.StopRequested += (s, e) => _wsPresenter2.StopTest();
            workstationView2.ClearStatsRequested += (s, e) => { /* TODO: 同上 */ };

            // 初始化设备连接（连接字符串可来自 Settings 页）
            // 如果你在 Settings 保存了连接参数，可替换如下 "127.0.0.1:502"
            //_ = _wsPresenter1.InitializeAsync("127.0.0.1:502");
            //_ = _wsPresenter2.InitializeAsync("127.0.0.1:502");

            // 设置工位标题
            workstationView1.SetStationName("工位1");
            workstationView2.SetStationName("工位2");
        }

        private Color StateColor(WorkstationState state)
        {
            switch (state)
            {
                case WorkstationState.TestPassed: return Color.LimeGreen;
                case WorkstationState.TestFailed: return Color.OrangeRed;
                case WorkstationState.Error: return Color.Red;
                case WorkstationState.Testing: return Color.Gold;
                case WorkstationState.Ready: return Color.DeepSkyBlue;
                default: return Color.White;
            }
        }

        private void AppendGlobalLog(string line)
        {
            // 你的测试页底部应该有一个 RichTextBox 名为 richTextBox1（按Designer修改）
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.BeginInvoke(new Action(() => AppendGlobalLog(line)));
                return;
            }
            richTextBox1.AppendText(line + Environment.NewLine);
            richTextBox1.ScrollToCaret();
        }

        // ========== 仪器调试页绑定 ==========
        private void BindDebugPage()
        {
            // 这些控件名按你的 Designer 修改
            btnConnect.Click += async (s, e) =>
            {
                try
                {
                    // 连接类型：此处默认TCP，可在Settings加入下拉框选择RTU/TCP后再切换实例
                    _debugInstrument = new ModbusInstrument();
                    _debugInstrument.CommunicationLog += (t, m) => AppendGlobalLog($"[DEBUG][{t}] {m}");
                    await _debugInstrument.ConnectAsync(txtConnectionString.Text.Trim());

                    StartDebugPolling(); // 开启状态/压力轮询
                    MessageBox.Show("连接成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接失败: " + ex.Message);
                }
            };

            btnDisconnect.Click += (s, e) =>
            {
                try
                {
                    StopDebugPolling();
                    _debugInstrument?.Disconnect();
                    MessageBox.Show("已断开");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("断开失败: " + ex.Message);
                }
            };

            btnForceInflate.Click += async (s, e) =>
            {
                if (_debugInstrument == null) return;
                try { await _debugInstrument.StartTestAsync(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            };

            btnForceDeflate.Click += async (s, e) =>
            {
                if (_debugInstrument == null) return;
                try { await _debugInstrument.StopTestAsync(); } catch (Exception ex) { MessageBox.Show(ex.Message); }
            };

            // 寄存器读写（若未在硬件类暴露API，这里先留 TODO 或用Presenter提供的抽象）
            btnReadReg.Click += (s, e) =>
            {
                MessageBox.Show("寄存器读取功能：请在硬件层添加 ReadRegister/ReadHoldingRegisters 封装后再绑定。");
            };
            btnWriteReg.Click += (s, e) =>
            {
                MessageBox.Show("寄存器写入功能：请在硬件层添加 WriteSingleRegister 封装后再绑定。");
            };

            // 关闭窗体停止轮询
            this.FormClosing += (s, e) => StopDebugPolling();
        }

        private void StartDebugPolling()
        {
            StopDebugPolling();
            _debugPollCts = new CancellationTokenSource();
            var token = _debugPollCts.Token;

            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        if (_debugInstrument != null)
                        {
                            int status = await _debugInstrument.ReadStatusAsync();
                            float pressure = await _debugInstrument.ReadPressureAsync();
                            this.BeginInvoke(new Action(() =>
                            {
                                lblStatusCode.Text = $"状态码: {status}";
                                lblPressure.Text = $"压力: {pressure:F2} kPa";
                            }));
                        }
                    }
                    catch
                    {
                        // 忽略未连接/读失败，避免打断轮询
                    }
                    await Task.Delay(800, token);
                }
            }, token);
        }

        private void StopDebugPolling()
        {
            try { _debugPollCts?.Cancel(); } catch { }
            _debugPollCts = null;
        }

        // ========== 软件设置页绑定 ==========
        private IInstrument BuildInstrument(string type)
        {
            if (string.Equals(type, "RTU", StringComparison.OrdinalIgnoreCase))
                return (IInstrument)new Airtightness.Hardware.ModbusRtuInstrument();
            else
                return (IInstrument)new Airtightness.Hardware.ModbusInstrument();
        }
        private void BindSettingsPage()
        {
            // 工位1连接按钮
            btnTestStation1Conn.Click += async (s, e) =>
            {
                try
                {
                    if (_ws1Connected)
                    {
                        MessageBox.Show("工位1已连接");
                        return;
                    }

                    string type = cmbStation1Type.Text;
                    string connStr = txtStation1Conn.Text.Trim();

                    if (string.IsNullOrWhiteSpace(connStr))
                    {
                        MessageBox.Show("请输入工位1连接参数");
                        return;
                    }

                    var instrument1 = BuildInstrument(type);
                    _wsPresenter1 = new WorkstationPresenter("工位1", instrument1, new Airtightness.MES.MesService());

                    await _wsPresenter1.InitializeAsync(connStr);
                    _ws1Connected = true;

                    MessageBox.Show("工位1连接成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("工位1连接失败: " + ex.Message);
                }
            };

            // 工位2连接按钮
            btnTestStation2Conn.Click += async (s, e) =>
            {
                try
                {
                    if (_ws2Connected)
                    {
                        MessageBox.Show("工位2已连接");
                        return;
                    }

                    string type = cmbStation2Type.Text;
                    string connStr = txtStation2Conn.Text.Trim();

                    if (string.IsNullOrWhiteSpace(connStr))
                    {
                        MessageBox.Show("请输入工位2连接参数");
                        return;
                    }

                    var instrument2 = BuildInstrument(type);
                    _wsPresenter2 = new WorkstationPresenter("工位2", instrument2, new Airtightness.MES.MesService());

                    await _wsPresenter2.InitializeAsync(connStr);
                    _ws2Connected = true;

                    MessageBox.Show("工位2连接成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("工位2连接失败: " + ex.Message);
                }
            };
            // 加载配置文件
            LoadConfigToUI();

            btnBrowsePath.Click += (s, e) =>
            {
                using (var dlg = new FolderBrowserDialog())
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                        txtDataPath.Text = dlg.SelectedPath;
                }
            };

            btnSaveSettings.Click += (s, e) =>
            {
                _config.MesUrl = txtMesUrl.Text.Trim();
                _config.EnableMes = chkEnableMes.Checked;
                _config.DataPath = txtDataPath.Text.Trim();
                _config.Language = cmbLanguage.Text;
                _config.Theme = cmbTheme.Text;

                try
                {
                    SaveConfig(_config);
                    MessageBox.Show("设置已保存");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存失败: " + ex.Message);
                }
            };
        }

        private void LoadConfigToUI()
        {
            _config = LoadConfig();
            txtMesUrl.Text = _config.MesUrl ?? "";
            chkEnableMes.Checked = _config.EnableMes;
            txtDataPath.Text = _config.DataPath ?? "";
            cmbLanguage.Items.Clear();
            cmbLanguage.Items.AddRange(new object[] { "中文", "English" });
            if (!string.IsNullOrEmpty(_config.Language)) cmbLanguage.Text = _config.Language; else cmbLanguage.SelectedIndex = 0;

            cmbTheme.Items.Clear();
            cmbTheme.Items.AddRange(new object[] { "浅色", "深色", "蓝色" });
            if (!string.IsNullOrEmpty(_config.Theme)) cmbTheme.Text = _config.Theme; else cmbTheme.SelectedIndex = 0;
        }

        // ========== 历史记录页绑定 ==========
        private void BindHistoryPage()
        {
            // 查询
            btnSearchHistory.Click += (s, e) => RefreshHistoryGrid();

            // 导出
            btnExportExcel.Click += (s, e) =>
            {
                if (dgvHistory.Rows.Count == 0) { MessageBox.Show("无数据可导出"); return; }
                using (var dlg = new SaveFileDialog()
                {
                    Filter = "CSV文件 (*.csv)|*.csv",
                    FileName = $"History_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
                })
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try { ExportGridToCsv(dgvHistory, dlg.FileName); MessageBox.Show("导出完成"); }
                        catch (Exception ex) { MessageBox.Show("导出失败: " + ex.Message); }
                    }
                }
            };

            // 清空（可选：实际生产慎用）
            btnClearHistory.Click += (s, e) =>
            {
                if (MessageBox.Show("确定要清空记录吗？此操作不可恢复。", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    dgvHistory.DataSource = null;
                    dgvHistory.Rows.Clear();
                    // TODO: 如使用文件/数据库，需同时清空存储
                }
            };

            // 初始化表格样式
            InitHistoryGrid();
        }

        private void InitHistoryGrid()
        {
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.ReadOnly = true;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshHistoryGrid()
        {
            // 这里演示：从 DataPath 下某个 CSV/JSON 加载；你可替换为真实仓储
            var from = dtpFromDate.Value.Date;
            var to = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1);
            var key = txtSearchBarcode.Text.Trim();

            var dt = new DataTable();
            dt.Columns.Add("测试时间");
            dt.Columns.Add("条码/SN");
            dt.Columns.Add("泄漏值");
            dt.Columns.Add("压力");
            dt.Columns.Add("温度");
            dt.Columns.Add("结果");

            // TODO: 替换为真实数据源。这里先放一个演示行，确认UI联通
            // 真实实现：从 _config.DataPath 读取你写入的结果文件
            dt.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "SN123456", "1.23", "101.50", "25.1", "OK");

            dgvHistory.DataSource = dt;
        }

        private void ExportGridToCsv(DataGridView grid, string filePath)
        {
            var sb = new StringBuilder();

            // 标题
            var headers = grid.Columns.Cast<DataGridViewColumn>().Select(c => EscapeCsv(c.HeaderText));
            sb.AppendLine(string.Join(",", headers));

            // 行
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;
                var cells = row.Cells.Cast<DataGridViewCell>().Select(c => EscapeCsv(Convert.ToString(c.Value)));
                sb.AppendLine(string.Join(",", cells));
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        private string EscapeCsv(string s)
        {
            if (s == null) return "";
            bool needQuote = s.Contains(",") || s.Contains("\"") || s.Contains("\n");
            s = s.Replace("\"", "\"\"");
            return needQuote ? $"\"{s}\"" : s;
        }

        // ========== 简单配置读写 ==========
        private string ConfigPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

        private AppConfig LoadConfig()
        {
            try
            {
                if (File.Exists(ConfigPath))
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<AppConfig>(File.ReadAllText(ConfigPath)) ?? new AppConfig();
            }
            catch { }
            return new AppConfig();
        }

        private void SaveConfig(AppConfig cfg)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(cfg, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(ConfigPath, json, Encoding.UTF8);
        }

        private class AppConfig
        {
            public string MesUrl { get; set; } = "";
            public bool EnableMes { get; set; } = true;
            public string DataPath { get; set; } = "";
            public string Language { get; set; } = "中文";
            public string Theme { get; set; } = "浅色";
        }
    }
}
