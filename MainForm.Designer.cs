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
            this.workstationView2 = new Airtightness.WinForms.Controls.WorkstationView();
            this.workstationView1 = new Airtightness.WinForms.Controls.WorkstationView();
            this.tabPageParams = new System.Windows.Forms.TabPage();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.RecipeDetails = new System.Windows.Forms.Panel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblInflationTime = new System.Windows.Forms.Label();
            this.lblStabilizationTime = new System.Windows.Forms.Label();
            this.lblTestTime = new System.Windows.Forms.Label();
            this.lblExhaustTime = new System.Windows.Forms.Label();
            this.lblInflationPressure = new System.Windows.Forms.Label();
            this.lblInletUpperLimit = new System.Windows.Forms.Label();
            this.lblInletLowerLimit = new System.Windows.Forms.Label();
            this.lblLeakThreshold = new System.Windows.Forms.Label();
            this.lblLeakLowerLimit = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.numInflationTime = new System.Windows.Forms.NumericUpDown();
            this.numStabilizationTime = new System.Windows.Forms.NumericUpDown();
            this.numInletUpperLimit = new System.Windows.Forms.NumericUpDown();
            this.numInflationPressure = new System.Windows.Forms.NumericUpDown();
            this.numExhaustTime = new System.Windows.Forms.NumericUpDown();
            this.numTestTime = new System.Windows.Forms.NumericUpDown();
            this.numLeakThreshold = new System.Windows.Forms.NumericUpDown();
            this.numInletLowerLimit = new System.Windows.Forms.NumericUpDown();
            this.numLeakLowerLimit = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.tabPageParams.SuspendLayout();
            this.RecipeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInflationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStabilizationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletUpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInflationPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExhaustTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeakThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletLowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeakLowerLimit)).BeginInit();
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
            // tabPageDebug
            // 
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
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(1576, 993);
            this.tabPageHistory.TabIndex = 4;
            this.tabPageHistory.Text = "历史记录";
            this.tabPageHistory.UseVisualStyleBackColor = true;
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
            // btnNewRecipe
            // 
            this.btnNewRecipe.Location = new System.Drawing.Point(3, 709);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(200, 74);
            this.btnNewRecipe.TabIndex = 1;
            this.btnNewRecipe.Text = "新建参数";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
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
            // lblRecipeName
            // 
            this.lblRecipeName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecipeName.Location = new System.Drawing.Point(107, 95);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(100, 29);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "配方名称";
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
            // lblInflationTime
            // 
            this.lblInflationTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInflationTime.Location = new System.Drawing.Point(107, 139);
            this.lblInflationTime.Name = "lblInflationTime";
            this.lblInflationTime.Size = new System.Drawing.Size(100, 29);
            this.lblInflationTime.TabIndex = 2;
            this.lblInflationTime.Text = "充气时间";
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
            // lblTestTime
            // 
            this.lblTestTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTestTime.Location = new System.Drawing.Point(107, 227);
            this.lblTestTime.Name = "lblTestTime";
            this.lblTestTime.Size = new System.Drawing.Size(100, 29);
            this.lblTestTime.TabIndex = 6;
            this.lblTestTime.Text = "测试时间";
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
            // lblInflationPressure
            // 
            this.lblInflationPressure.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInflationPressure.Location = new System.Drawing.Point(107, 315);
            this.lblInflationPressure.Name = "lblInflationPressure";
            this.lblInflationPressure.Size = new System.Drawing.Size(100, 29);
            this.lblInflationPressure.TabIndex = 10;
            this.lblInflationPressure.Text = "充气压力";
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
            // lblInletLowerLimit
            // 
            this.lblInletLowerLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInletLowerLimit.Location = new System.Drawing.Point(107, 403);
            this.lblInletLowerLimit.Name = "lblInletLowerLimit";
            this.lblInletLowerLimit.Size = new System.Drawing.Size(100, 29);
            this.lblInletLowerLimit.TabIndex = 14;
            this.lblInletLowerLimit.Text = "进气下限";
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
            // lblLeakLowerLimit
            // 
            this.lblLeakLowerLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeakLowerLimit.Location = new System.Drawing.Point(107, 491);
            this.lblLeakLowerLimit.Name = "lblLeakLowerLimit";
            this.lblLeakLowerLimit.Size = new System.Drawing.Size(100, 29);
            this.lblLeakLowerLimit.TabIndex = 18;
            this.lblLeakLowerLimit.Text = "泄漏下限";
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
            // numInflationTime
            // 
            this.numInflationTime.DecimalPlaces = 1;
            this.numInflationTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numInflationTime.Location = new System.Drawing.Point(213, 136);
            this.numInflationTime.Name = "numInflationTime";
            this.numInflationTime.Size = new System.Drawing.Size(150, 29);
            this.numInflationTime.TabIndex = 21;
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
            // numInletUpperLimit
            // 
            this.numInletUpperLimit.DecimalPlaces = 3;
            this.numInletUpperLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numInletUpperLimit.Location = new System.Drawing.Point(213, 356);
            this.numInletUpperLimit.Name = "numInletUpperLimit";
            this.numInletUpperLimit.Size = new System.Drawing.Size(150, 29);
            this.numInletUpperLimit.TabIndex = 23;
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
            // numExhaustTime
            // 
            this.numExhaustTime.DecimalPlaces = 1;
            this.numExhaustTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numExhaustTime.Location = new System.Drawing.Point(213, 268);
            this.numExhaustTime.Name = "numExhaustTime";
            this.numExhaustTime.Size = new System.Drawing.Size(150, 29);
            this.numExhaustTime.TabIndex = 25;
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
            // numLeakThreshold
            // 
            this.numLeakThreshold.DecimalPlaces = 3;
            this.numLeakThreshold.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLeakThreshold.Location = new System.Drawing.Point(213, 444);
            this.numLeakThreshold.Name = "numLeakThreshold";
            this.numLeakThreshold.Size = new System.Drawing.Size(150, 29);
            this.numLeakThreshold.TabIndex = 27;
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
            // numLeakLowerLimit
            // 
            this.numLeakLowerLimit.DecimalPlaces = 3;
            this.numLeakLowerLimit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLeakLowerLimit.Location = new System.Drawing.Point(213, 488);
            this.numLeakLowerLimit.Name = "numLeakLowerLimit";
            this.numLeakLowerLimit.Size = new System.Drawing.Size(150, 29);
            this.numLeakLowerLimit.TabIndex = 29;
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
            ((System.ComponentModel.ISupportInitialize)(this.numInflationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStabilizationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletUpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInflationPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExhaustTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeakThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInletLowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeakLowerLimit)).EndInit();
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
    }
}