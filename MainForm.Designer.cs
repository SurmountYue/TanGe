namespace TanGe
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.btnNavTest = new System.Windows.Forms.Button();
            this.btnNavParams = new System.Windows.Forms.Button();
            this.btnNavDebug = new System.Windows.Forms.Button();
            this.btnNavSettings = new System.Windows.Forms.Button();
            this.btnNavHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPageParams = new System.Windows.Forms.TabPage();
            this.RecipeDetails = new System.Windows.Forms.Panel();
            this.numLeakLowerLimit = new System.Windows.Forms.NumericUpDown();
            this.numInletLowerLimit = new System.Windows.Forms.NumericUpDown();
            this.numLeakThreshold = new System.Windows.Forms.NumericUpDown();
            this.numTestTime = new System.Windows.Forms.NumericUpDown();
            this.numExhaustTime = new System.Windows.Forms.NumericUpDown();
            this.numInflationPressure = new System.Windows.Forms.NumericUpDown();
            this.numInletUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.numStabilizationTime = new System.Windows.Forms.NumericUpDown();
            this.numInflationTime = new System.Windows.Forms.NumericUpDown();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblLeakLowerLimit = new System.Windows.Forms.Label();
            this.lblLeakThreshold = new System.Windows.Forms.Label();
            this.lblInletLowerLimit = new System.Windows.Forms.Label();
            this.lblInletUpperLimit = new System.Windows.Forms.Label();
            this.lblInflationPressure = new System.Windows.Forms.Label();
            this.lblExhaustTime = new System.Windows.Forms.Label();
            this.lblTestTime = new System.Windows.Forms.Label();
            this.lblStabilizationTime = new System.Windows.Forms.Label();
            this.lblInflationTime = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.workstationView2 = new Airtightness.WinForms.Controls.WorkstationView();
            this.workstationView1 = new Airtightness.WinForms.Controls.WorkstationView();
            this.lblConnection = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.grpManual = new System.Windows.Forms.GroupBox();
            this.btnForceInflate = new System.Windows.Forms.Button();
            this.btnForceDeflate = new System.Windows.Forms.Button();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.lblRegAddr = new System.Windows.Forms.Label();
            this.txtRegAddr = new System.Windows.Forms.TextBox();
            this.lblRegValue = new System.Windows.Forms.Label();
            this.txtRegValue = new System.Windows.Forms.TextBox();
            this.btnReadReg = new System.Windows.Forms.Button();
            this.btnWriteReg = new System.Windows.Forms.Button();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblStatusCode = new System.Windows.Forms.Label();
            this.grpMES = new System.Windows.Forms.GroupBox();
            this.lblMesUrl = new System.Windows.Forms.Label();
            this.txtMesUrl = new System.Windows.Forms.TextBox();
            this.chkEnableMes = new System.Windows.Forms.CheckBox();
            this.grpStorage = new System.Windows.Forms.GroupBox();
            this.txtDataPath = new System.Windows.Forms.TextBox();
            this.lblDataPath = new System.Windows.Forms.Label();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.gbSearchHistory = new System.Windows.Forms.GroupBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtSearchBarcode = new System.Windows.Forms.TextBox();
            this.btnSearchHistory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.tabPageParams.SuspendLayout();
            this.RecipeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLeakLowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletLowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeakThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExhaustTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInflationPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletUpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStabilizationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInflationTime)).BeginInit();
            this.tabPageDebug.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpManual.SuspendLayout();
            this.grpRegister.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpMES.SuspendLayout();
            this.grpStorage.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.gbSearchHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1584, 70);
            this.Title.TabIndex = 1;
            this.Title.Text = "产  品  气  密  性  测  试";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNavTest
            // 
            this.btnNavTest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNavTest.Location = new System.Drawing.Point(15, 3);
            this.btnNavTest.Name = "btnNavTest";
            this.btnNavTest.Size = new System.Drawing.Size(75, 59);
            this.btnNavTest.TabIndex = 2;
            this.btnNavTest.Text = "测试界面";
            this.btnNavTest.UseVisualStyleBackColor = false;
            // 
            // btnNavParams
            // 
            this.btnNavParams.Location = new System.Drawing.Point(96, 3);
            this.btnNavParams.Name = "btnNavParams";
            this.btnNavParams.Size = new System.Drawing.Size(75, 59);
            this.btnNavParams.TabIndex = 3;
            this.btnNavParams.Text = "仪器参数";
            this.btnNavParams.UseVisualStyleBackColor = true;
            // 
            // btnNavDebug
            // 
            this.btnNavDebug.Location = new System.Drawing.Point(177, 3);
            this.btnNavDebug.Name = "btnNavDebug";
            this.btnNavDebug.Size = new System.Drawing.Size(75, 59);
            this.btnNavDebug.TabIndex = 4;
            this.btnNavDebug.Text = "仪器调试";
            this.btnNavDebug.UseVisualStyleBackColor = true;
            // 
            // btnNavSettings
            // 
            this.btnNavSettings.Location = new System.Drawing.Point(258, 3);
            this.btnNavSettings.Name = "btnNavSettings";
            this.btnNavSettings.Size = new System.Drawing.Size(75, 59);
            this.btnNavSettings.TabIndex = 5;
            this.btnNavSettings.Text = "软件设置";
            this.btnNavSettings.UseVisualStyleBackColor = true;
            // 
            // btnNavHistory
            // 
            this.btnNavHistory.Location = new System.Drawing.Point(339, 3);
            this.btnNavHistory.Name = "btnNavHistory";
            this.btnNavHistory.Size = new System.Drawing.Size(75, 60);
            this.btnNavHistory.TabIndex = 6;
            this.btnNavHistory.Text = "历史记录";
            this.btnNavHistory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnNavTest);
            this.panel1.Controls.Add(this.btnNavHistory);
            this.panel1.Controls.Add(this.btnNavParams);
            this.panel1.Controls.Add(this.btnNavSettings);
            this.panel1.Controls.Add(this.btnNavDebug);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 72);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 1019);
            this.panel2.TabIndex = 8;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTest);
            this.tabControl.Controls.Add(this.tabPageParams);
            this.tabControl.Controls.Add(this.tabPageDebug);
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1584, 1019);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.richTextBox1);
            this.tabPageTest.Controls.Add(this.workstationView2);
            this.tabPageTest.Controls.Add(this.workstationView1);
            this.tabPageTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(1576, 993);
            this.tabPageTest.TabIndex = 0;
            this.tabPageTest.Text = "测试界面";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 807);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1573, 183);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // tabPageParams
            // 
            this.tabPageParams.Controls.Add(this.RecipeDetails);
            this.tabPageParams.Controls.Add(this.btnDeleteRecipe);
            this.tabPageParams.Controls.Add(this.btnNewRecipe);
            this.tabPageParams.Controls.Add(this.lstRecipes);
            this.tabPageParams.Location = new System.Drawing.Point(4, 22);
            this.tabPageParams.Name = "tabPageParams";
            this.tabPageParams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParams.Size = new System.Drawing.Size(1576, 993);
            this.tabPageParams.TabIndex = 1;
            this.tabPageParams.Text = "仪器参数";
            this.tabPageParams.UseVisualStyleBackColor = true;
            // 
            // RecipeDetails
            // 
            this.RecipeDetails.Controls.Add(this.numLeakLowerLimit);
            this.RecipeDetails.Controls.Add(this.numInletLowerLimit);
            this.RecipeDetails.Controls.Add(this.numLeakThreshold);
            this.RecipeDetails.Controls.Add(this.numTestTime);
            this.RecipeDetails.Controls.Add(this.numExhaustTime);
            this.RecipeDetails.Controls.Add(this.numInflationPressure);
            this.RecipeDetails.Controls.Add(this.numInletUpperLimit);
            this.RecipeDetails.Controls.Add(this.numStabilizationTime);
            this.RecipeDetails.Controls.Add(this.numInflationTime);
            this.RecipeDetails.Controls.Add(this.btnSaveChanges);
            this.RecipeDetails.Controls.Add(this.lblLeakLowerLimit);
            this.RecipeDetails.Controls.Add(this.lblLeakThreshold);
            this.RecipeDetails.Controls.Add(this.lblInletLowerLimit);
            this.RecipeDetails.Controls.Add(this.lblInletUpperLimit);
            this.RecipeDetails.Controls.Add(this.lblInflationPressure);
            this.RecipeDetails.Controls.Add(this.lblExhaustTime);
            this.RecipeDetails.Controls.Add(this.lblTestTime);
            this.RecipeDetails.Controls.Add(this.lblStabilizationTime);
            this.RecipeDetails.Controls.Add(this.lblInflationTime);
            this.RecipeDetails.Controls.Add(this.txtRecipeName);
            this.RecipeDetails.Controls.Add(this.lblRecipeName);
            this.RecipeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecipeDetails.Location = new System.Drawing.Point(203, 3);
            this.RecipeDetails.Name = "RecipeDetails";
            this.RecipeDetails.Size = new System.Drawing.Size(1370, 987);
            this.RecipeDetails.TabIndex = 3;
            // 
            // numLeakLowerLimit
            // 
            this.numLeakLowerLimit.DecimalPlaces = 3;
            this.numLeakLowerLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLeakLowerLimit.Location = new System.Drawing.Point(213, 488);
            this.numLeakLowerLimit.Name = "numLeakLowerLimit";
            this.numLeakLowerLimit.Size = new System.Drawing.Size(150, 29);
            this.numLeakLowerLimit.TabIndex = 29;
            // 
            // numInletLowerLimit
            // 
            this.numInletLowerLimit.DecimalPlaces = 3;
            this.numInletLowerLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numInletLowerLimit.Location = new System.Drawing.Point(213, 400);
            this.numInletLowerLimit.Name = "numInletLowerLimit";
            this.numInletLowerLimit.Size = new System.Drawing.Size(150, 29);
            this.numInletLowerLimit.TabIndex = 28;
            // 
            // numLeakThreshold
            // 
            this.numLeakThreshold.DecimalPlaces = 3;
            this.numLeakThreshold.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLeakThreshold.Location = new System.Drawing.Point(213, 444);
            this.numLeakThreshold.Name = "numLeakThreshold";
            this.numLeakThreshold.Size = new System.Drawing.Size(150, 29);
            this.numLeakThreshold.TabIndex = 27;
            // 
            // numTestTime
            // 
            this.numTestTime.DecimalPlaces = 1;
            this.numTestTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numTestTime.Location = new System.Drawing.Point(213, 224);
            this.numTestTime.Name = "numTestTime";
            this.numTestTime.Size = new System.Drawing.Size(150, 29);
            this.numTestTime.TabIndex = 26;
            // 
            // numExhaustTime
            // 
            this.numExhaustTime.DecimalPlaces = 1;
            this.numExhaustTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numExhaustTime.Location = new System.Drawing.Point(213, 268);
            this.numExhaustTime.Name = "numExhaustTime";
            this.numExhaustTime.Size = new System.Drawing.Size(150, 29);
            this.numExhaustTime.TabIndex = 25;
            // 
            // numInflationPressure
            // 
            this.numInflationPressure.DecimalPlaces = 3;
            this.numInflationPressure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numInflationPressure.Location = new System.Drawing.Point(213, 312);
            this.numInflationPressure.Name = "numInflationPressure";
            this.numInflationPressure.Size = new System.Drawing.Size(150, 29);
            this.numInflationPressure.TabIndex = 24;
            // 
            // numInletUpperLimit
            // 
            this.numInletUpperLimit.DecimalPlaces = 3;
            this.numInletUpperLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numInletUpperLimit.Location = new System.Drawing.Point(213, 356);
            this.numInletUpperLimit.Name = "numInletUpperLimit";
            this.numInletUpperLimit.Size = new System.Drawing.Size(150, 29);
            this.numInletUpperLimit.TabIndex = 23;
            // 
            // numStabilizationTime
            // 
            this.numStabilizationTime.DecimalPlaces = 1;
            this.numStabilizationTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numStabilizationTime.Location = new System.Drawing.Point(213, 180);
            this.numStabilizationTime.Name = "numStabilizationTime";
            this.numStabilizationTime.Size = new System.Drawing.Size(150, 29);
            this.numStabilizationTime.TabIndex = 22;
            // 
            // numInflationTime
            // 
            this.numInflationTime.DecimalPlaces = 1;
            this.numInflationTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numInflationTime.Location = new System.Drawing.Point(213, 136);
            this.numInflationTime.Name = "numInflationTime";
            this.numInflationTime.Size = new System.Drawing.Size(150, 29);
            this.numInflationTime.TabIndex = 21;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(111, 538);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(252, 74);
            this.btnSaveChanges.TabIndex = 20;
            this.btnSaveChanges.Text = "保存参数";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // lblLeakLowerLimit
            // 
            this.lblLeakLowerLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeakLowerLimit.Location = new System.Drawing.Point(107, 491);
            this.lblLeakLowerLimit.Name = "lblLeakLowerLimit";
            this.lblLeakLowerLimit.Size = new System.Drawing.Size(100, 29);
            this.lblLeakLowerLimit.TabIndex = 18;
            this.lblLeakLowerLimit.Text = "泄漏下限";
            // 
            // lblLeakThreshold
            // 
            this.lblLeakThreshold.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeakThreshold.Location = new System.Drawing.Point(107, 447);
            this.lblLeakThreshold.Name = "lblLeakThreshold";
            this.lblLeakThreshold.Size = new System.Drawing.Size(100, 29);
            this.lblLeakThreshold.TabIndex = 16;
            this.lblLeakThreshold.Text = "泄漏上限";
            // 
            // lblInletLowerLimit
            // 
            this.lblInletLowerLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInletLowerLimit.Location = new System.Drawing.Point(107, 403);
            this.lblInletLowerLimit.Name = "lblInletLowerLimit";
            this.lblInletLowerLimit.Size = new System.Drawing.Size(100, 29);
            this.lblInletLowerLimit.TabIndex = 14;
            this.lblInletLowerLimit.Text = "进气下限";
            // 
            // lblInletUpperLimit
            // 
            this.lblInletUpperLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInletUpperLimit.Location = new System.Drawing.Point(107, 359);
            this.lblInletUpperLimit.Name = "lblInletUpperLimit";
            this.lblInletUpperLimit.Size = new System.Drawing.Size(100, 29);
            this.lblInletUpperLimit.TabIndex = 12;
            this.lblInletUpperLimit.Text = "进气上限";
            // 
            // lblInflationPressure
            // 
            this.lblInflationPressure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInflationPressure.Location = new System.Drawing.Point(107, 315);
            this.lblInflationPressure.Name = "lblInflationPressure";
            this.lblInflationPressure.Size = new System.Drawing.Size(100, 29);
            this.lblInflationPressure.TabIndex = 10;
            this.lblInflationPressure.Text = "充气压力";
            // 
            // lblExhaustTime
            // 
            this.lblExhaustTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExhaustTime.Location = new System.Drawing.Point(107, 271);
            this.lblExhaustTime.Name = "lblExhaustTime";
            this.lblExhaustTime.Size = new System.Drawing.Size(100, 29);
            this.lblExhaustTime.TabIndex = 8;
            this.lblExhaustTime.Text = "放气时间";
            // 
            // lblTestTime
            // 
            this.lblTestTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTestTime.Location = new System.Drawing.Point(107, 227);
            this.lblTestTime.Name = "lblTestTime";
            this.lblTestTime.Size = new System.Drawing.Size(100, 29);
            this.lblTestTime.TabIndex = 6;
            this.lblTestTime.Text = "测试时间";
            // 
            // lblStabilizationTime
            // 
            this.lblStabilizationTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStabilizationTime.Location = new System.Drawing.Point(107, 183);
            this.lblStabilizationTime.Name = "lblStabilizationTime";
            this.lblStabilizationTime.Size = new System.Drawing.Size(100, 29);
            this.lblStabilizationTime.TabIndex = 4;
            this.lblStabilizationTime.Text = "稳压时间";
            // 
            // lblInflationTime
            // 
            this.lblInflationTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInflationTime.Location = new System.Drawing.Point(107, 139);
            this.lblInflationTime.Name = "lblInflationTime";
            this.lblInflationTime.Size = new System.Drawing.Size(100, 29);
            this.lblInflationTime.TabIndex = 2;
            this.lblInflationTime.Text = "充气时间";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecipeName.Location = new System.Drawing.Point(213, 92);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(150, 29);
            this.txtRecipeName.TabIndex = 1;
            this.txtRecipeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecipeName.Location = new System.Drawing.Point(107, 95);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(100, 29);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "配方名称";
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(3, 789);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(200, 74);
            this.btnDeleteRecipe.TabIndex = 2;
            this.btnDeleteRecipe.Text = "删除参数";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.Location = new System.Drawing.Point(3, 709);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(200, 74);
            this.btnNewRecipe.TabIndex = 1;
            this.btnNewRecipe.Text = "新建参数";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // lstRecipes
            // 
            this.lstRecipes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 12;
            this.lstRecipes.Location = new System.Drawing.Point(3, 3);
            this.lstRecipes.MaximumSize = new System.Drawing.Size(200, 700);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(200, 700);
            this.lstRecipes.TabIndex = 0;
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.Controls.Add(this.grpStatus);
            this.tabPageDebug.Controls.Add(this.grpRegister);
            this.tabPageDebug.Controls.Add(this.grpManual);
            this.tabPageDebug.Controls.Add(this.panel3);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebug.Size = new System.Drawing.Size(1576, 993);
            this.tabPageDebug.TabIndex = 2;
            this.tabPageDebug.Text = "仪器调试";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.btnSaveSettings);
            this.tabPageSettings.Controls.Add(this.grpGeneral);
            this.tabPageSettings.Controls.Add(this.grpStorage);
            this.tabPageSettings.Controls.Add(this.grpMES);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(1576, 993);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "软件设置";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.btnClearHistory);
            this.tabPageHistory.Controls.Add(this.btnExportExcel);
            this.tabPageHistory.Controls.Add(this.dataGridView1);
            this.tabPageHistory.Controls.Add(this.gbSearchHistory);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(1576, 993);
            this.tabPageHistory.TabIndex = 4;
            this.tabPageHistory.Text = "历史记录";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // workstationView2
            // 
            this.workstationView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.workstationView2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.workstationView2.BarcodeText = "";
            this.workstationView2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.workstationView2.Location = new System.Drawing.Point(872, 4);
            this.workstationView2.Margin = new System.Windows.Forms.Padding(4);
            this.workstationView2.Name = "workstationView2";
            this.workstationView2.Size = new System.Drawing.Size(700, 800);
            this.workstationView2.TabIndex = 1;
            // 
            // workstationView1
            // 
            this.workstationView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.workstationView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.workstationView1.BarcodeText = "";
            this.workstationView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.workstationView1.Location = new System.Drawing.Point(0, 4);
            this.workstationView1.Margin = new System.Windows.Forms.Padding(4);
            this.workstationView1.Name = "workstationView1";
            this.workstationView1.Size = new System.Drawing.Size(700, 800);
            this.workstationView1.TabIndex = 0;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblConnection.Location = new System.Drawing.Point(60, 26);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(221, 21);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "连接参数(IP:端口 或 COM口):";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDisconnect);
            this.panel3.Controls.Add(this.btnConnect);
            this.panel3.Controls.Add(this.txtConnectionString);
            this.panel3.Controls.Add(this.lblConnection);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1570, 71);
            this.panel3.TabIndex = 1;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(287, 26);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(315, 21);
            this.txtConnectionString.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.Location = new System.Drawing.Point(608, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 37);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisconnect.Location = new System.Drawing.Point(689, 18);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 37);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // grpManual
            // 
            this.grpManual.Controls.Add(this.btnForceDeflate);
            this.grpManual.Controls.Add(this.btnForceInflate);
            this.grpManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpManual.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpManual.Location = new System.Drawing.Point(3, 74);
            this.grpManual.Name = "grpManual";
            this.grpManual.Size = new System.Drawing.Size(1570, 95);
            this.grpManual.TabIndex = 2;
            this.grpManual.TabStop = false;
            this.grpManual.Text = "手动操作";
            // 
            // btnForceInflate
            // 
            this.btnForceInflate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForceInflate.Location = new System.Drawing.Point(170, 22);
            this.btnForceInflate.Name = "btnForceInflate";
            this.btnForceInflate.Size = new System.Drawing.Size(164, 57);
            this.btnForceInflate.TabIndex = 3;
            this.btnForceInflate.Text = "强制充气";
            this.btnForceInflate.UseVisualStyleBackColor = true;
            // 
            // btnForceDeflate
            // 
            this.btnForceDeflate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForceDeflate.Location = new System.Drawing.Point(529, 22);
            this.btnForceDeflate.Name = "btnForceDeflate";
            this.btnForceDeflate.Size = new System.Drawing.Size(164, 57);
            this.btnForceDeflate.TabIndex = 4;
            this.btnForceDeflate.Text = "强制放气";
            this.btnForceDeflate.UseVisualStyleBackColor = true;
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.btnWriteReg);
            this.grpRegister.Controls.Add(this.btnReadReg);
            this.grpRegister.Controls.Add(this.txtRegValue);
            this.grpRegister.Controls.Add(this.lblRegValue);
            this.grpRegister.Controls.Add(this.txtRegAddr);
            this.grpRegister.Controls.Add(this.lblRegAddr);
            this.grpRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRegister.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpRegister.Location = new System.Drawing.Point(3, 169);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(1570, 231);
            this.grpRegister.TabIndex = 3;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "寄存器读写";
            // 
            // lblRegAddr
            // 
            this.lblRegAddr.AutoSize = true;
            this.lblRegAddr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRegAddr.Location = new System.Drawing.Point(166, 45);
            this.lblRegAddr.Name = "lblRegAddr";
            this.lblRegAddr.Size = new System.Drawing.Size(58, 21);
            this.lblRegAddr.TabIndex = 1;
            this.lblRegAddr.Text = "地址：";
            // 
            // txtRegAddr
            // 
            this.txtRegAddr.Location = new System.Drawing.Point(262, 39);
            this.txtRegAddr.Name = "txtRegAddr";
            this.txtRegAddr.Size = new System.Drawing.Size(315, 33);
            this.txtRegAddr.TabIndex = 2;
            // 
            // lblRegValue
            // 
            this.lblRegValue.AutoSize = true;
            this.lblRegValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRegValue.Location = new System.Drawing.Point(182, 102);
            this.lblRegValue.Name = "lblRegValue";
            this.lblRegValue.Size = new System.Drawing.Size(42, 21);
            this.lblRegValue.TabIndex = 3;
            this.lblRegValue.Text = "值：";
            // 
            // txtRegValue
            // 
            this.txtRegValue.Location = new System.Drawing.Point(262, 96);
            this.txtRegValue.Name = "txtRegValue";
            this.txtRegValue.Size = new System.Drawing.Size(315, 33);
            this.txtRegValue.TabIndex = 4;
            // 
            // btnReadReg
            // 
            this.btnReadReg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadReg.Location = new System.Drawing.Point(170, 168);
            this.btnReadReg.Name = "btnReadReg";
            this.btnReadReg.Size = new System.Drawing.Size(164, 57);
            this.btnReadReg.TabIndex = 5;
            this.btnReadReg.Text = "读取";
            this.btnReadReg.UseVisualStyleBackColor = true;
            // 
            // btnWriteReg
            // 
            this.btnWriteReg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteReg.Location = new System.Drawing.Point(529, 168);
            this.btnWriteReg.Name = "btnWriteReg";
            this.btnWriteReg.Size = new System.Drawing.Size(164, 57);
            this.btnWriteReg.TabIndex = 6;
            this.btnWriteReg.Text = "写入";
            this.btnWriteReg.UseVisualStyleBackColor = true;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.lblPressure);
            this.grpStatus.Controls.Add(this.lblStatusCode);
            this.grpStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStatus.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpStatus.Location = new System.Drawing.Point(3, 400);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(1570, 231);
            this.grpStatus.TabIndex = 4;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "状态监控";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPressure.Location = new System.Drawing.Point(182, 102);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(112, 27);
            this.lblPressure.TabIndex = 3;
            this.lblPressure.Text = "压力: - kPa";
            // 
            // lblStatusCode
            // 
            this.lblStatusCode.AutoSize = true;
            this.lblStatusCode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatusCode.Location = new System.Drawing.Point(166, 48);
            this.lblStatusCode.Name = "lblStatusCode";
            this.lblStatusCode.Size = new System.Drawing.Size(92, 27);
            this.lblStatusCode.TabIndex = 1;
            this.lblStatusCode.Text = "状态码: -";
            // 
            // grpMES
            // 
            this.grpMES.Controls.Add(this.chkEnableMes);
            this.grpMES.Controls.Add(this.txtMesUrl);
            this.grpMES.Controls.Add(this.lblMesUrl);
            this.grpMES.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMES.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpMES.Location = new System.Drawing.Point(3, 3);
            this.grpMES.Name = "grpMES";
            this.grpMES.Size = new System.Drawing.Size(1570, 145);
            this.grpMES.TabIndex = 0;
            this.grpMES.TabStop = false;
            this.grpMES.Text = "MES 系统设置";
            // 
            // lblMesUrl
            // 
            this.lblMesUrl.AutoSize = true;
            this.lblMesUrl.Location = new System.Drawing.Point(47, 47);
            this.lblMesUrl.Name = "lblMesUrl";
            this.lblMesUrl.Size = new System.Drawing.Size(154, 26);
            this.lblMesUrl.TabIndex = 0;
            this.lblMesUrl.Text = "MES服务器地址:";
            // 
            // txtMesUrl
            // 
            this.txtMesUrl.Location = new System.Drawing.Point(207, 44);
            this.txtMesUrl.Name = "txtMesUrl";
            this.txtMesUrl.Size = new System.Drawing.Size(434, 33);
            this.txtMesUrl.TabIndex = 1;
            // 
            // chkEnableMes
            // 
            this.chkEnableMes.AutoSize = true;
            this.chkEnableMes.Location = new System.Drawing.Point(666, 47);
            this.chkEnableMes.Name = "chkEnableMes";
            this.chkEnableMes.Size = new System.Drawing.Size(161, 30);
            this.chkEnableMes.TabIndex = 2;
            this.chkEnableMes.Text = "启用 MES 功能";
            this.chkEnableMes.UseVisualStyleBackColor = true;
            // 
            // grpStorage
            // 
            this.grpStorage.Controls.Add(this.btnBrowsePath);
            this.grpStorage.Controls.Add(this.txtDataPath);
            this.grpStorage.Controls.Add(this.lblDataPath);
            this.grpStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStorage.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpStorage.Location = new System.Drawing.Point(3, 148);
            this.grpStorage.Name = "grpStorage";
            this.grpStorage.Size = new System.Drawing.Size(1570, 145);
            this.grpStorage.TabIndex = 1;
            this.grpStorage.TabStop = false;
            this.grpStorage.Text = "数据存储设置";
            // 
            // txtDataPath
            // 
            this.txtDataPath.Location = new System.Drawing.Point(207, 44);
            this.txtDataPath.Name = "txtDataPath";
            this.txtDataPath.Size = new System.Drawing.Size(434, 33);
            this.txtDataPath.TabIndex = 1;
            // 
            // lblDataPath
            // 
            this.lblDataPath.AutoSize = true;
            this.lblDataPath.Location = new System.Drawing.Point(47, 47);
            this.lblDataPath.Name = "lblDataPath";
            this.lblDataPath.Size = new System.Drawing.Size(131, 26);
            this.lblDataPath.TabIndex = 0;
            this.lblDataPath.Text = "数据保存路径:";
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowsePath.Location = new System.Drawing.Point(693, 33);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(164, 57);
            this.btnBrowsePath.TabIndex = 5;
            this.btnBrowsePath.Text = "浏览";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.comboBox2);
            this.grpGeneral.Controls.Add(this.comboBox1);
            this.grpGeneral.Controls.Add(this.lblTheme);
            this.grpGeneral.Controls.Add(this.lblLanguage);
            this.grpGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGeneral.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpGeneral.Location = new System.Drawing.Point(3, 293);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(1570, 145);
            this.grpGeneral.TabIndex = 2;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "通用设置";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(123, 47);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 26);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "语言:";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(94, 95);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(93, 26);
            this.lblTheme.TabIndex = 3;
            this.lblTheme.Text = "界面主题:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "中文",
            "English"});
            this.comboBox1.Location = new System.Drawing.Point(217, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 34);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "浅色",
            "深色",
            "蓝色"});
            this.comboBox2.Location = new System.Drawing.Point(217, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 34);
            this.comboBox2.TabIndex = 5;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveSettings.Location = new System.Drawing.Point(800, 478);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(393, 57);
            this.btnSaveSettings.TabIndex = 6;
            this.btnSaveSettings.Text = "保存设置";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            // 
            // gbSearchHistory
            // 
            this.gbSearchHistory.Controls.Add(this.btnSearchHistory);
            this.gbSearchHistory.Controls.Add(this.txtSearchBarcode);
            this.gbSearchHistory.Controls.Add(this.lblBarcode);
            this.gbSearchHistory.Controls.Add(this.dtpToDate);
            this.gbSearchHistory.Controls.Add(this.lblToDate);
            this.gbSearchHistory.Controls.Add(this.dtpFromDate);
            this.gbSearchHistory.Controls.Add(this.lblFromDate);
            this.gbSearchHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchHistory.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbSearchHistory.Location = new System.Drawing.Point(3, 3);
            this.gbSearchHistory.Name = "gbSearchHistory";
            this.gbSearchHistory.Size = new System.Drawing.Size(1570, 145);
            this.gbSearchHistory.TabIndex = 1;
            this.gbSearchHistory.TabStop = false;
            this.gbSearchHistory.Text = "历史查询";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(47, 47);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(93, 26);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "开始时间:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(156, 42);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 33);
            this.dtpFromDate.TabIndex = 1;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(530, 42);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 33);
            this.dtpToDate.TabIndex = 3;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(421, 47);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(107, 26);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "结束时间：";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(47, 96);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(91, 26);
            this.lblBarcode.TabIndex = 4;
            this.lblBarcode.Text = "条码/SN:";
            // 
            // txtSearchBarcode
            // 
            this.txtSearchBarcode.Location = new System.Drawing.Point(156, 89);
            this.txtSearchBarcode.Name = "txtSearchBarcode";
            this.txtSearchBarcode.Size = new System.Drawing.Size(574, 33);
            this.txtSearchBarcode.TabIndex = 5;
            // 
            // btnSearchHistory
            // 
            this.btnSearchHistory.Location = new System.Drawing.Point(765, 85);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.Size = new System.Drawing.Size(146, 37);
            this.btnSearchHistory.TabIndex = 6;
            this.btnSearchHistory.Text = "查询";
            this.btnSearchHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1570, 515);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExportExcel.Location = new System.Drawing.Point(3, 703);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(183, 73);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "导出到 Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearHistory.Location = new System.Drawing.Point(215, 703);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(183, 73);
            this.btnClearHistory.TabIndex = 4;
            this.btnClearHistory.Text = "清空记录";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1584, 1161);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.MinimumSize = new System.Drawing.Size(1600, 1200);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageTest.ResumeLayout(false);
            this.tabPageParams.ResumeLayout(false);
            this.RecipeDetails.ResumeLayout(false);
            this.RecipeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLeakLowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletLowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeakThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExhaustTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInflationPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletUpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStabilizationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInflationTime)).EndInit();
            this.tabPageDebug.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageHistory.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpManual.ResumeLayout(false);
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpMES.ResumeLayout(false);
            this.grpMES.PerformLayout();
            this.grpStorage.ResumeLayout(false);
            this.grpStorage.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.gbSearchHistory.ResumeLayout(false);
            this.gbSearchHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnNavTest;
        private System.Windows.Forms.Button btnNavParams;
        private System.Windows.Forms.Button btnNavDebug;
        private System.Windows.Forms.Button btnNavSettings;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.TabPage tabPageParams;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageHistory;
        private Airtightness.WinForms.Controls.WorkstationView workstationView2;
        private Airtightness.WinForms.Controls.WorkstationView workstationView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.Button btnNewRecipe;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.Panel RecipeDetails;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblLeakLowerLimit;
        private System.Windows.Forms.Label lblLeakThreshold;
        private System.Windows.Forms.Label lblInletLowerLimit;
        private System.Windows.Forms.Label lblInletUpperLimit;
        private System.Windows.Forms.Label lblInflationPressure;
        private System.Windows.Forms.Label lblExhaustTime;
        private System.Windows.Forms.Label lblTestTime;
        private System.Windows.Forms.Label lblStabilizationTime;
        private System.Windows.Forms.Label lblInflationTime;
        private System.Windows.Forms.NumericUpDown numLeakLowerLimit;
        private System.Windows.Forms.NumericUpDown numInletLowerLimit;
        private System.Windows.Forms.NumericUpDown numLeakThreshold;
        private System.Windows.Forms.NumericUpDown numTestTime;
        private System.Windows.Forms.NumericUpDown numExhaustTime;
        private System.Windows.Forms.NumericUpDown numInflationPressure;
        private System.Windows.Forms.NumericUpDown numInletUpperLimit;
        private System.Windows.Forms.NumericUpDown numStabilizationTime;
        private System.Windows.Forms.NumericUpDown numInflationTime;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.GroupBox grpManual;
        private System.Windows.Forms.Button btnForceDeflate;
        private System.Windows.Forms.Button btnForceInflate;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.Button btnWriteReg;
        private System.Windows.Forms.Button btnReadReg;
        private System.Windows.Forms.TextBox txtRegValue;
        private System.Windows.Forms.Label lblRegValue;
        private System.Windows.Forms.TextBox txtRegAddr;
        private System.Windows.Forms.Label lblRegAddr;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblStatusCode;
        private System.Windows.Forms.GroupBox grpMES;
        private System.Windows.Forms.Label lblMesUrl;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.GroupBox grpStorage;
        private System.Windows.Forms.Button btnBrowsePath;
        private System.Windows.Forms.TextBox txtDataPath;
        private System.Windows.Forms.Label lblDataPath;
        private System.Windows.Forms.CheckBox chkEnableMes;
        private System.Windows.Forms.TextBox txtMesUrl;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.GroupBox gbSearchHistory;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnSearchHistory;
        private System.Windows.Forms.TextBox txtSearchBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Button btnExportExcel;
    }
}