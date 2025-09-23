using Airtightness.Core.Enums;
using ScottPlot;          // ScottPlot 核心库
using ScottPlot.Styles;
using ScottPlot.WinForms; // WinForms 控件版本
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Airtightness.WinForms.Controls
{
    /// <summary>
    /// WorkstationView 是一个自定义 WinForms 用户控件
    /// 用于显示某个工位的状态、实时数据、生产统计和环形图
    /// 适配 ScottPlot 4.1.73 API
    /// </summary>
    public partial class WorkstationView : UserControl
    {
        
        public WorkstationView()
        {
            InitializeComponent();
            
        }

        #region ==== 公开事件 ====

        /// <summary>点击开始按钮</summary>
        public event EventHandler StartRequested;

        /// <summary>点击停止按钮</summary>
        public event EventHandler StopRequested;

        /// <summary>点击清空统计按钮</summary>
        public event EventHandler ClearStatsRequested;

        /// <summary>Enter输入SN</summary>
        public event Action<string> BarcodeEntered;

        /// <summary>点击断开按钮</summary>
        public event EventHandler DisconnectRequested;

        #endregion

        #region ==== 公开属性 ====

        /// <summary>条码文本</summary>
        public string BarcodeText
        {
            get => txtBarcode.Text;
            set
            {
                if (txtBarcode.InvokeRequired)
                    txtBarcode.BeginInvoke(new Action(() => txtBarcode.Text = value));
                else
                    txtBarcode.Text = value;
            }
        }

        #endregion

        #region ==== 公共方法 ====

        /// <summary>设置工位名称</summary>
        public void SetStationName(string name)
        {
            if (lblStation.InvokeRequired)
                lblStation.BeginInvoke(new Action(() => lblStation.Text = name));
            else
                lblStation.Text = name;
        }

        /// <summary>更新测试状态</summary>
        public void UpdateStatus(string status, Color color)
        {
            if (lblStatus.InvokeRequired)
                lblStatus.BeginInvoke(new Action(() =>
                {
                    lblStatus.Text = status;
                    lblStatus.ForeColor = color;
                }));
            else
            {
                lblStatus.Text = status;
                lblStatus.ForeColor = color;
            }
        }

        /// <summary>更新通信状态</summary>
        public void UpdateCommStatus(string text, Color color)
        {
            if (lblCommStatus.InvokeRequired)
                lblCommStatus.BeginInvoke(new Action(() =>
                {
                    lblCommStatus.Text = text;
                    lblCommStatus.BackColor = color;
                    
                }));
            else
            {
                lblCommStatus.Text = text;
                lblCommStatus.BackColor = color;
            }
        }

        /// <summary>更新实时数据</summary>
        public void UpdateRealtimeData(float leakValue, float pressure, float temp)
        {
            if (this.InvokeRequired)
                this.BeginInvoke(new Action(() =>
                {
                    txtLeakValue.Text = leakValue.ToString("F3");
                    txtInletPressure.Text = pressure.ToString("F2");
                    txtTemperature.Text = temp.ToString("F1");
                }));
            else
            {
                txtLeakValue.Text = leakValue.ToString("F3");
                txtInletPressure.Text = pressure.ToString("F2");
                txtTemperature.Text = temp.ToString("F1");
            }
        }

        /// <summary>更新统计数据 + 环形图</summary>
        public void UpdateStatistics(int total, int ok, int ng)
        {
            if (this.InvokeRequired)
                this.BeginInvoke(new Action(() =>
                {
                    UpdateStatsText(total, ok, ng);
                    UpdateDoughnutChart(ok, ng);
                }));
            else
            {
                UpdateStatsText(total, ok, ng);
                UpdateDoughnutChart(ok, ng);
            }
        }

        /// <summary>添加日志</summary>
        public void Log(string message)
        {
            if (lstLog.InvokeRequired)
                lstLog.BeginInvoke(new Action(() => AddLog(message)));
            else
                AddLog(message);
        }

        /// <summary>设置开始/停止按钮的状态</summary>
        public void SetButtonState(bool startEnabled, bool stopEnabled)
        {
            if (btnStart.InvokeRequired)
                btnStart.BeginInvoke(new Action(() =>
                {
                    btnStart.Enabled = startEnabled;
                    btnStop.Enabled = stopEnabled;
                }));
            else
            {
                btnStart.Enabled = startEnabled;
                btnStop.Enabled = stopEnabled;
            }
        }

        #endregion

        #region ==== 内部事件处理 ====
        // 绑定按钮把内部点击转成对外事件（供 MainForm 订阅）
        private void btnStart_Click(object sender, EventArgs e)
        {
            try { StartRequested?.Invoke(this, EventArgs.Empty); } catch { /* 避免未订阅异常 */ }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try { StopRequested?.Invoke(this, EventArgs.Empty); } catch { }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnClearStats_Click(object sender, EventArgs e)
        {
            try { ClearStatsRequested?.Invoke(this, EventArgs.Empty); } catch { }
        }
        public void AppendLog(string line)
        {
            if (lstLog.InvokeRequired)
            {
                lstLog.BeginInvoke(new Action(() => AppendLog(line)));
                return;
            }
            lstLog.Items.Add(line);
            lstLog.TopIndex = Math.Max(0, lstLog.Items.Count - 1); // 自动滚动到底
        }

        #endregion

        #region ==== 私有方法 ====
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtBarcode.Text.Trim();
                if (!string.IsNullOrEmpty(barcode))
                {
                    BarcodeEntered?.Invoke(barcode);
                }
                e.Handled = true;
                e.SuppressKeyPress = true; // 防止输完回车响铃
            }
        }


        /// <summary>更新统计文本</summary>
        private void UpdateStatsText(int total, int ok, int ng)
        {
            txtTotal.Text = total.ToString();
            txtOK.Text = ok.ToString();
            txtNG.Text = ng.ToString();
            double yield = total == 0 ? 0 : (double)ok / total;
            txtYield.Text = yield.ToString("P2");
        }

        /// <summary>向日志添加一条记录</summary>
        private void AddLog(string message)
        {
            string logEntry = $"{DateTime.Now:HH:mm:ss} - {message}";
            if (lstLog.Items.Count > 200)
                lstLog.Items.RemoveAt(0);
            lstLog.Items.Add(logEntry);
            lstLog.SelectedIndex = lstLog.Items.Count - 1;
        }

        /// <summary>
        /// 绘制 OK/NG 环形图（适配 ScottPlot v4.1.73）
        /// </summary>
        private void UpdateDoughnutChart(int okCount, int ngCount)
        {
            // 1. 清空画布
            plotYieldChart.Plot.Clear();

            // 2. 无数据 => 显示灰色提示文字
            if (okCount == 0 && ngCount == 0)
            {
                plotYieldChart.Plot.Title("无产量数据", bold: false, color: Color.Gray, size: 12);
                plotYieldChart.Refresh();
                return;
            }

            // 3. 数据
            double[] values = { okCount, ngCount };
            string[] labels = { "OK", "NG" };
            Color[] sliceColors =
            {
                Color.FromArgb(46, 204, 113), // OK 绿色
                Color.FromArgb(231, 76, 60)   // NG 红色
            };

            // 4. 添加饼图
            var pie = plotYieldChart.Plot.AddPie(values);
            pie.DonutSize = 0.6;
            pie.DonutLabel = $"{okCount + ngCount}\n总计";
            pie.SliceFillColors = sliceColors;
            pie.ShowValues = false;
            pie.LegendLabels = labels;

            // 5. 图例位置
            plotYieldChart.Plot.Legend(location: Alignment.MiddleRight);

            // 6. 背景透明
            plotYieldChart.Plot.Style(
                figureBackground: Color.Transparent,
                dataBackground: Color.Transparent
            );

            // 7. 去掉坐标轴
            plotYieldChart.Plot.Frameless();

            // 8. 刷新
            plotYieldChart.Refresh();
        }













        #endregion

        
    }
}
