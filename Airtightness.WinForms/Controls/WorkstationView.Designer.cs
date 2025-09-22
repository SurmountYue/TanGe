namespace Airtightness.WinForms.Controls
{
    partial class WorkstationView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLeakValueUnit = new System.Windows.Forms.Label();
            this.lblTemperatureUnit = new System.Windows.Forms.Label();
            this.lblInletPressureUnit = new System.Windows.Forms.Label();
            this.lblAtmPressureUnit = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLeakValue = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblLeakValue = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtInletPressure = new System.Windows.Forms.TextBox();
            this.txtAtmPressure = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblAtmPressure = new System.Windows.Forms.Label();
            this.lblInletPressure = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.plotYieldChart = new ScottPlot.FormsPlot();
            this.lblCommStatus = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOK = new System.Windows.Forms.Label();
            this.btnClearStats = new System.Windows.Forms.Button();
            this.lblNG = new System.Windows.Forms.Label();
            this.txtYield = new System.Windows.Forms.TextBox();
            this.lblYield = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNG = new System.Windows.Forms.TextBox();
            this.txtOK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLeakValueUnit
            // 
            this.lblLeakValueUnit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblLeakValueUnit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeakValueUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLeakValueUnit.Location = new System.Drawing.Point(645, 135);
            this.lblLeakValueUnit.Name = "lblLeakValueUnit";
            this.lblLeakValueUnit.Size = new System.Drawing.Size(55, 40);
            this.lblLeakValueUnit.TabIndex = 43;
            this.lblLeakValueUnit.Text = "Pa";
            this.lblLeakValueUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperatureUnit
            // 
            this.lblTemperatureUnit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTemperatureUnit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTemperatureUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTemperatureUnit.Location = new System.Drawing.Point(645, 91);
            this.lblTemperatureUnit.Name = "lblTemperatureUnit";
            this.lblTemperatureUnit.Size = new System.Drawing.Size(55, 40);
            this.lblTemperatureUnit.TabIndex = 42;
            this.lblTemperatureUnit.Text = "°C";
            this.lblTemperatureUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInletPressureUnit
            // 
            this.lblInletPressureUnit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblInletPressureUnit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInletPressureUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInletPressureUnit.Location = new System.Drawing.Point(375, 135);
            this.lblInletPressureUnit.Name = "lblInletPressureUnit";
            this.lblInletPressureUnit.Size = new System.Drawing.Size(55, 40);
            this.lblInletPressureUnit.TabIndex = 41;
            this.lblInletPressureUnit.Text = "Pa";
            this.lblInletPressureUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtmPressureUnit
            // 
            this.lblAtmPressureUnit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblAtmPressureUnit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAtmPressureUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAtmPressureUnit.Location = new System.Drawing.Point(375, 91);
            this.lblAtmPressureUnit.Name = "lblAtmPressureUnit";
            this.lblAtmPressureUnit.Size = new System.Drawing.Size(55, 40);
            this.lblAtmPressureUnit.TabIndex = 40;
            this.lblAtmPressureUnit.Text = "hpa";
            this.lblAtmPressureUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStation
            // 
            this.lblStation.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblStation.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStation.Location = new System.Drawing.Point(-1, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(701, 40);
            this.lblStation.TabIndex = 46;
            this.lblStation.Text = "工位";
            this.lblStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(165, 179);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(535, 49);
            this.lblStatus.TabIndex = 39;
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLeakValue
            // 
            this.txtLeakValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLeakValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLeakValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLeakValue.Location = new System.Drawing.Point(565, 147);
            this.txtLeakValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtLeakValue.Name = "txtLeakValue";
            this.txtLeakValue.ReadOnly = true;
            this.txtLeakValue.Size = new System.Drawing.Size(75, 28);
            this.txtLeakValue.TabIndex = 38;
            this.txtLeakValue.Text = "0.0";
            this.txtLeakValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTemperature.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTemperature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTemperature.Location = new System.Drawing.Point(437, 91);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(120, 40);
            this.lblTemperature.TabIndex = 35;
            this.lblTemperature.Text = "    温度    ";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeakValue
            // 
            this.lblLeakValue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblLeakValue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeakValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLeakValue.Location = new System.Drawing.Point(437, 135);
            this.lblLeakValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeakValue.Name = "lblLeakValue";
            this.lblLeakValue.Size = new System.Drawing.Size(120, 40);
            this.lblLeakValue.TabIndex = 37;
            this.lblLeakValue.Text = " 泄  漏  值";
            this.lblLeakValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemperature.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTemperature.Location = new System.Drawing.Point(565, 93);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(4);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.ReadOnly = true;
            this.txtTemperature.Size = new System.Drawing.Size(75, 28);
            this.txtTemperature.TabIndex = 36;
            this.txtTemperature.Text = "0.0";
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInletPressure
            // 
            this.txtInletPressure.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInletPressure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInletPressure.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInletPressure.Location = new System.Drawing.Point(295, 141);
            this.txtInletPressure.Margin = new System.Windows.Forms.Padding(4);
            this.txtInletPressure.Name = "txtInletPressure";
            this.txtInletPressure.ReadOnly = true;
            this.txtInletPressure.Size = new System.Drawing.Size(75, 28);
            this.txtInletPressure.TabIndex = 34;
            this.txtInletPressure.Text = "0.0";
            this.txtInletPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAtmPressure
            // 
            this.txtAtmPressure.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAtmPressure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAtmPressure.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAtmPressure.Location = new System.Drawing.Point(295, 97);
            this.txtAtmPressure.Margin = new System.Windows.Forms.Padding(4);
            this.txtAtmPressure.Name = "txtAtmPressure";
            this.txtAtmPressure.ReadOnly = true;
            this.txtAtmPressure.Size = new System.Drawing.Size(75, 28);
            this.txtAtmPressure.TabIndex = 32;
            this.txtAtmPressure.Text = "0.0";
            this.txtAtmPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarcode.Location = new System.Drawing.Point(167, 44);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(533, 35);
            this.txtBarcode.TabIndex = 30;
            // 
            // lblAtmPressure
            // 
            this.lblAtmPressure.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblAtmPressure.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAtmPressure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAtmPressure.Location = new System.Drawing.Point(167, 91);
            this.lblAtmPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtmPressure.Name = "lblAtmPressure";
            this.lblAtmPressure.Size = new System.Drawing.Size(120, 40);
            this.lblAtmPressure.TabIndex = 31;
            this.lblAtmPressure.Text = "大气压力";
            this.lblAtmPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInletPressure
            // 
            this.lblInletPressure.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblInletPressure.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInletPressure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInletPressure.Location = new System.Drawing.Point(167, 135);
            this.lblInletPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInletPressure.Name = "lblInletPressure";
            this.lblInletPressure.Size = new System.Drawing.Size(120, 40);
            this.lblInletPressure.TabIndex = 33;
            this.lblInletPressure.Text = " 进气压力 ";
            this.lblInletPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 24;
            this.lstLog.Location = new System.Drawing.Point(163, 245);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(534, 556);
            this.lstLog.TabIndex = 44;
            // 
            // plotYieldChart
            // 
            this.plotYieldChart.Location = new System.Drawing.Point(6, 315);
            this.plotYieldChart.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.plotYieldChart.Name = "plotYieldChart";
            this.plotYieldChart.Size = new System.Drawing.Size(148, 117);
            this.plotYieldChart.TabIndex = 60;
            // 
            // lblCommStatus
            // 
            this.lblCommStatus.BackColor = System.Drawing.Color.Firebrick;
            this.lblCommStatus.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCommStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCommStatus.Location = new System.Drawing.Point(-1, 173);
            this.lblCommStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommStatus.Name = "lblCommStatus";
            this.lblCommStatus.Size = new System.Drawing.Size(160, 40);
            this.lblCommStatus.TabIndex = 49;
            this.lblCommStatus.Text = "设备已断开";
            this.lblCommStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBarcode
            // 
            this.lblBarcode.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblBarcode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBarcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBarcode.Location = new System.Drawing.Point(-1, 44);
            this.lblBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(160, 40);
            this.lblBarcode.TabIndex = 47;
            this.lblBarcode.Text = "条码";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(-1, 87);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 40);
            this.btnStart.TabIndex = 48;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Firebrick;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(-1, 130);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(160, 40);
            this.btnStop.TabIndex = 50;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotal.Location = new System.Drawing.Point(2, 536);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "总产量";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOK
            // 
            this.lblOK.AutoSize = true;
            this.lblOK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOK.Location = new System.Drawing.Point(6, 591);
            this.lblOK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(57, 25);
            this.lblOK.TabIndex = 52;
            this.lblOK.Text = "OK数";
            this.lblOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearStats
            // 
            this.btnClearStats.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClearStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStats.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearStats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearStats.Location = new System.Drawing.Point(4, 756);
            this.btnClearStats.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearStats.Name = "btnClearStats";
            this.btnClearStats.Size = new System.Drawing.Size(160, 40);
            this.btnClearStats.TabIndex = 59;
            this.btnClearStats.Text = "产品清零";
            this.btnClearStats.UseVisualStyleBackColor = false;
            // 
            // lblNG
            // 
            this.lblNG.AutoSize = true;
            this.lblNG.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNG.Location = new System.Drawing.Point(4, 646);
            this.lblNG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNG.Name = "lblNG";
            this.lblNG.Size = new System.Drawing.Size(59, 25);
            this.lblNG.TabIndex = 53;
            this.lblNG.Text = "NG数";
            this.lblNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYield
            // 
            this.txtYield.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtYield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYield.Location = new System.Drawing.Point(71, 699);
            this.txtYield.Margin = new System.Windows.Forms.Padding(4);
            this.txtYield.Name = "txtYield";
            this.txtYield.ReadOnly = true;
            this.txtYield.Size = new System.Drawing.Size(93, 31);
            this.txtYield.TabIndex = 57;
            this.txtYield.Text = "0.00%";
            this.txtYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYield
            // 
            this.lblYield.AutoSize = true;
            this.lblYield.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblYield.Location = new System.Drawing.Point(4, 701);
            this.lblYield.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYield.Name = "lblYield";
            this.lblYield.Size = new System.Drawing.Size(66, 25);
            this.lblYield.TabIndex = 54;
            this.lblYield.Text = "良品率";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(71, 534);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(93, 31);
            this.txtTotal.TabIndex = 58;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNG
            // 
            this.txtNG.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNG.Location = new System.Drawing.Point(71, 644);
            this.txtNG.Margin = new System.Windows.Forms.Padding(4);
            this.txtNG.Name = "txtNG";
            this.txtNG.ReadOnly = true;
            this.txtNG.Size = new System.Drawing.Size(93, 31);
            this.txtNG.TabIndex = 55;
            this.txtNG.Text = "0";
            this.txtNG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOK
            // 
            this.txtOK.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOK.Location = new System.Drawing.Point(71, 585);
            this.txtOK.Margin = new System.Windows.Forms.Padding(4);
            this.txtOK.Name = "txtOK";
            this.txtOK.ReadOnly = true;
            this.txtOK.Size = new System.Drawing.Size(93, 31);
            this.txtOK.TabIndex = 56;
            this.txtOK.Text = "0";
            this.txtOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WorkstationView
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.plotYieldChart);
            this.Controls.Add(this.lblCommStatus);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOK);
            this.Controls.Add(this.btnClearStats);
            this.Controls.Add(this.lblNG);
            this.Controls.Add(this.txtYield);
            this.Controls.Add(this.lblYield);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNG);
            this.Controls.Add(this.txtOK);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.lblLeakValueUnit);
            this.Controls.Add(this.lblTemperatureUnit);
            this.Controls.Add(this.lblInletPressureUnit);
            this.Controls.Add(this.lblAtmPressureUnit);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLeakValue);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblLeakValue);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtInletPressure);
            this.Controls.Add(this.txtAtmPressure);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblAtmPressure);
            this.Controls.Add(this.lblInletPressure);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkstationView";
            this.Size = new System.Drawing.Size(700, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLeakValueUnit;
        private System.Windows.Forms.Label lblTemperatureUnit;
        private System.Windows.Forms.Label lblInletPressureUnit;
        private System.Windows.Forms.Label lblAtmPressureUnit;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtLeakValue;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblLeakValue;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtInletPressure;
        private System.Windows.Forms.TextBox txtAtmPressure;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblAtmPressure;
        private System.Windows.Forms.Label lblInletPressure;
        private System.Windows.Forms.ListBox lstLog;
        private ScottPlot.FormsPlot plotYieldChart;
        private System.Windows.Forms.Label lblCommStatus;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOK;
        private System.Windows.Forms.Button btnClearStats;
        private System.Windows.Forms.Label lblNG;
        private System.Windows.Forms.TextBox txtYield;
        private System.Windows.Forms.Label lblYield;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNG;
        private System.Windows.Forms.TextBox txtOK;
    }
}
