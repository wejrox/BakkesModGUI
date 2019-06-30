namespace ConfigChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbKey1 = new System.Windows.Forms.ComboBox();
            this.cmbKey2 = new System.Windows.Forms.ComboBox();
            this.cmbKey4 = new System.Windows.Forms.ComboBox();
            this.txtGameSpeed = new System.Windows.Forms.TextBox();
            this.btnSpeedAdd = new System.Windows.Forms.Button();
            this.btnSpeedSub = new System.Windows.Forms.Button();
            this.cmbKey3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGameSpeed = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCommands = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCommand3 = new System.Windows.Forms.ComboBox();
            this.cmbCommand4 = new System.Windows.Forms.ComboBox();
            this.cmbCommand2 = new System.Windows.Forms.ComboBox();
            this.cmbCommand1 = new System.Windows.Forms.ComboBox();
            this.cmbMaps = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCustomConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkLoadMap = new System.Windows.Forms.CheckBox();
            this.chkGameSpeed = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.btnUnloadAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstUnloadedPlugins = new System.Windows.Forms.ListBox();
            this.btnEditConfig = new System.Windows.Forms.Button();
            this.btnLoadPlugin = new System.Windows.Forms.Button();
            this.btnUnloadPlugin = new System.Windows.Forms.Button();
            this.grpLoadedPlugins = new System.Windows.Forms.GroupBox();
            this.lstLoadedPlugins = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCustomConfig = new System.Windows.Forms.GroupBox();
            this.txtCustomConfig = new System.Windows.Forms.TextBox();
            this.btnRunInjector = new System.Windows.Forms.Button();
            this.btnApplyConfig = new System.Windows.Forms.Button();
            this.btnWiki = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabCustomConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpLoadedPlugins.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.grpCustomConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(493, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Config";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbKey1
            // 
            this.cmbKey1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey1.DropDownWidth = 200;
            this.cmbKey1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKey1.FormattingEnabled = true;
            this.cmbKey1.Location = new System.Drawing.Point(277, 38);
            this.cmbKey1.MaxDropDownItems = 5;
            this.cmbKey1.Name = "cmbKey1";
            this.cmbKey1.Size = new System.Drawing.Size(208, 21);
            this.cmbKey1.TabIndex = 1;
            // 
            // cmbKey2
            // 
            this.cmbKey2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey2.DropDownWidth = 200;
            this.cmbKey2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKey2.FormattingEnabled = true;
            this.cmbKey2.Location = new System.Drawing.Point(277, 65);
            this.cmbKey2.MaxDropDownItems = 5;
            this.cmbKey2.Name = "cmbKey2";
            this.cmbKey2.Size = new System.Drawing.Size(208, 21);
            this.cmbKey2.TabIndex = 2;
            // 
            // cmbKey4
            // 
            this.cmbKey4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey4.DropDownWidth = 200;
            this.cmbKey4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKey4.FormattingEnabled = true;
            this.cmbKey4.Location = new System.Drawing.Point(277, 119);
            this.cmbKey4.MaxDropDownItems = 5;
            this.cmbKey4.Name = "cmbKey4";
            this.cmbKey4.Size = new System.Drawing.Size(208, 21);
            this.cmbKey4.TabIndex = 3;
            // 
            // txtGameSpeed
            // 
            this.txtGameSpeed.Location = new System.Drawing.Point(327, 45);
            this.txtGameSpeed.Name = "txtGameSpeed";
            this.txtGameSpeed.ReadOnly = true;
            this.txtGameSpeed.Size = new System.Drawing.Size(63, 20);
            this.txtGameSpeed.TabIndex = 5;
            this.txtGameSpeed.Text = "1.0";
            this.txtGameSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSpeedAdd
            // 
            this.btnSpeedAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSpeedAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSpeedAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSpeedAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSpeedAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpeedAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedAdd.Location = new System.Drawing.Point(396, 43);
            this.btnSpeedAdd.Name = "btnSpeedAdd";
            this.btnSpeedAdd.Size = new System.Drawing.Size(23, 21);
            this.btnSpeedAdd.TabIndex = 7;
            this.btnSpeedAdd.Text = "+";
            this.btnSpeedAdd.UseVisualStyleBackColor = false;
            this.btnSpeedAdd.Click += new System.EventHandler(this.btnSpeedAdd_Click);
            // 
            // btnSpeedSub
            // 
            this.btnSpeedSub.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSpeedSub.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSpeedSub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSpeedSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSpeedSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpeedSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedSub.Location = new System.Drawing.Point(298, 43);
            this.btnSpeedSub.Name = "btnSpeedSub";
            this.btnSpeedSub.Size = new System.Drawing.Size(23, 21);
            this.btnSpeedSub.TabIndex = 8;
            this.btnSpeedSub.Text = "-";
            this.btnSpeedSub.UseVisualStyleBackColor = false;
            this.btnSpeedSub.Click += new System.EventHandler(this.btnSpeedSub_Click);
            // 
            // cmbKey3
            // 
            this.cmbKey3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKey3.DropDownWidth = 200;
            this.cmbKey3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKey3.FormattingEnabled = true;
            this.cmbKey3.Location = new System.Drawing.Point(277, 92);
            this.cmbKey3.MaxDropDownItems = 5;
            this.cmbKey3.Name = "cmbKey3";
            this.cmbKey3.Size = new System.Drawing.Size(208, 21);
            this.cmbKey3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Game Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbGameSpeed
            // 
            this.cmbGameSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGameSpeed.FormattingEnabled = true;
            this.cmbGameSpeed.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "zero",
            "Q",
            "W",
            "E",
            "R",
            "T",
            "Y",
            "U",
            "I",
            "O",
            "P",
            "A",
            "S",
            "D",
            "F",
            "G",
            "H",
            "J",
            "K",
            "L",
            "Z",
            "X",
            "C",
            "V",
            "B",
            "N",
            "M",
            "Tilde",
            "Underscore",
            "Equals",
            "LeftBracket",
            "RightBracket",
            "Backslash",
            "Comma",
            "Period",
            "Slash",
            "Tab",
            "Caps-Lock",
            "LeftShift",
            "RightShift",
            "LeftControl",
            "RightControl",
            "LeftAlt",
            "RightAlt",
            "SpaceBar",
            "Left",
            "Up",
            "Down",
            "Right",
            "Home",
            "End",
            "Insert",
            "PageUp",
            "Delete",
            "PageDown",
            "NumLock",
            "Divide",
            "Multiply",
            "Subtract",
            "Add",
            "NumPadOne",
            "NumPadTwo",
            "NumPadThree",
            "NumPadFour",
            "NumPadFive",
            "NumPadSix",
            "NumPadSeven",
            "NumPadEight",
            "NumPadNine",
            "NumPadZero",
            "Decimal"});
            this.cmbGameSpeed.Location = new System.Drawing.Point(211, 43);
            this.cmbGameSpeed.Name = "cmbGameSpeed";
            this.cmbGameSpeed.Size = new System.Drawing.Size(72, 21);
            this.cmbGameSpeed.TabIndex = 16;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Location = new System.Drawing.Point(493, 344);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load Config";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCommands
            // 
            this.btnCommands.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCommands.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCommands.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCommands.Location = new System.Drawing.Point(12, 344);
            this.btnCommands.Name = "btnCommands";
            this.btnCommands.Size = new System.Drawing.Size(113, 23);
            this.btnCommands.TabIndex = 21;
            this.btnCommands.Text = "Console Commands";
            this.btnCommands.UseVisualStyleBackColor = false;
            this.btnCommands.Click += new System.EventHandler(this.btnCommands_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "To apply these settings in training mode, \r\nClick \"Apply Config\"";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(171, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 43);
            this.panel1.TabIndex = 23;
            // 
            // cmbCommand3
            // 
            this.cmbCommand3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommand3.DropDownWidth = 200;
            this.cmbCommand3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCommand3.FormattingEnabled = true;
            this.cmbCommand3.Location = new System.Drawing.Point(63, 92);
            this.cmbCommand3.MaxDropDownItems = 5;
            this.cmbCommand3.Name = "cmbCommand3";
            this.cmbCommand3.Size = new System.Drawing.Size(208, 21);
            this.cmbCommand3.TabIndex = 27;
            // 
            // cmbCommand4
            // 
            this.cmbCommand4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommand4.DropDownWidth = 200;
            this.cmbCommand4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCommand4.FormattingEnabled = true;
            this.cmbCommand4.Location = new System.Drawing.Point(63, 119);
            this.cmbCommand4.MaxDropDownItems = 5;
            this.cmbCommand4.Name = "cmbCommand4";
            this.cmbCommand4.Size = new System.Drawing.Size(208, 21);
            this.cmbCommand4.TabIndex = 26;
            // 
            // cmbCommand2
            // 
            this.cmbCommand2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommand2.DropDownWidth = 200;
            this.cmbCommand2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCommand2.FormattingEnabled = true;
            this.cmbCommand2.Location = new System.Drawing.Point(63, 65);
            this.cmbCommand2.MaxDropDownItems = 5;
            this.cmbCommand2.Name = "cmbCommand2";
            this.cmbCommand2.Size = new System.Drawing.Size(208, 21);
            this.cmbCommand2.TabIndex = 25;
            // 
            // cmbCommand1
            // 
            this.cmbCommand1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommand1.DropDownWidth = 200;
            this.cmbCommand1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCommand1.FormattingEnabled = true;
            this.cmbCommand1.Location = new System.Drawing.Point(63, 38);
            this.cmbCommand1.MaxDropDownItems = 5;
            this.cmbCommand1.Name = "cmbCommand1";
            this.cmbCommand1.Size = new System.Drawing.Size(208, 21);
            this.cmbCommand1.TabIndex = 24;
            // 
            // cmbMaps
            // 
            this.cmbMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaps.DropDownWidth = 200;
            this.cmbMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaps.FormattingEnabled = true;
            this.cmbMaps.Location = new System.Drawing.Point(211, 70);
            this.cmbMaps.MaxDropDownItems = 5;
            this.cmbMaps.Name = "cmbMaps";
            this.cmbMaps.Size = new System.Drawing.Size(208, 21);
            this.cmbMaps.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Map to Load";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Key/Button";
            // 
            // tabCustomConfig
            // 
            this.tabCustomConfig.Controls.Add(this.tabPage1);
            this.tabCustomConfig.Controls.Add(this.tabPage2);
            this.tabCustomConfig.Controls.Add(this.tabPage3);
            this.tabCustomConfig.Controls.Add(this.tabPage4);
            this.tabCustomConfig.Location = new System.Drawing.Point(12, 12);
            this.tabCustomConfig.Name = "tabCustomConfig";
            this.tabCustomConfig.SelectedIndex = 0;
            this.tabCustomConfig.Size = new System.Drawing.Size(560, 288);
            this.tabCustomConfig.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnAddRow);
            this.tabPage1.Controls.Add(this.btnRemoveRow);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbKey1);
            this.tabPage1.Controls.Add(this.cmbKey2);
            this.tabPage1.Controls.Add(this.cmbKey4);
            this.tabPage1.Controls.Add(this.cmbCommand3);
            this.tabPage1.Controls.Add(this.cmbCommand4);
            this.tabPage1.Controls.Add(this.cmbCommand2);
            this.tabPage1.Controls.Add(this.cmbKey3);
            this.tabPage1.Controls.Add(this.cmbCommand1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bindings";
            // 
            // btnAddRow
            // 
            this.btnAddRow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddRow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRow.Location = new System.Drawing.Point(195, 174);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 33;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemoveRow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemoveRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveRow.Location = new System.Drawing.Point(276, 174);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveRow.TabIndex = 32;
            this.btnRemoveRow.Text = "Remove Row";
            this.btnRemoveRow.UseVisualStyleBackColor = false;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.chkLoadMap);
            this.tabPage2.Controls.Add(this.chkGameSpeed);
            this.tabPage2.Controls.Add(this.cmbMaps);
            this.tabPage2.Controls.Add(this.btnSpeedAdd);
            this.tabPage2.Controls.Add(this.btnSpeedSub);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtGameSpeed);
            this.tabPage2.Controls.Add(this.cmbGameSpeed);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other Options";
            // 
            // chkLoadMap
            // 
            this.chkLoadMap.AutoSize = true;
            this.chkLoadMap.Location = new System.Drawing.Point(115, 73);
            this.chkLoadMap.Name = "chkLoadMap";
            this.chkLoadMap.Size = new System.Drawing.Size(15, 14);
            this.chkLoadMap.TabIndex = 31;
            this.chkLoadMap.UseVisualStyleBackColor = true;
            // 
            // chkGameSpeed
            // 
            this.chkGameSpeed.AutoSize = true;
            this.chkGameSpeed.Location = new System.Drawing.Point(115, 48);
            this.chkGameSpeed.Name = "chkGameSpeed";
            this.chkGameSpeed.Size = new System.Drawing.Size(15, 14);
            this.chkGameSpeed.TabIndex = 30;
            this.chkGameSpeed.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnLoadAll);
            this.tabPage3.Controls.Add(this.btnUnloadAll);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.btnEditConfig);
            this.tabPage3.Controls.Add(this.btnLoadPlugin);
            this.tabPage3.Controls.Add(this.btnUnloadPlugin);
            this.tabPage3.Controls.Add(this.grpLoadedPlugins);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(552, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Plugins";
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLoadAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadAll.Location = new System.Drawing.Point(241, 151);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(66, 23);
            this.btnLoadAll.TabIndex = 7;
            this.btnLoadAll.Text = "<<";
            this.btnLoadAll.UseVisualStyleBackColor = false;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // btnUnloadAll
            // 
            this.btnUnloadAll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUnloadAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnloadAll.Location = new System.Drawing.Point(241, 180);
            this.btnUnloadAll.Name = "btnUnloadAll";
            this.btnUnloadAll.Size = new System.Drawing.Size(66, 23);
            this.btnUnloadAll.TabIndex = 6;
            this.btnUnloadAll.Text = ">>";
            this.btnUnloadAll.UseVisualStyleBackColor = false;
            this.btnUnloadAll.Click += new System.EventHandler(this.btnUnloadAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstUnloadedPlugins);
            this.groupBox1.Location = new System.Drawing.Point(313, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unloaded Plugins";
            // 
            // lstUnloadedPlugins
            // 
            this.lstUnloadedPlugins.FormattingEnabled = true;
            this.lstUnloadedPlugins.Location = new System.Drawing.Point(6, 19);
            this.lstUnloadedPlugins.Name = "lstUnloadedPlugins";
            this.lstUnloadedPlugins.Size = new System.Drawing.Size(220, 186);
            this.lstUnloadedPlugins.TabIndex = 0;
            this.lstUnloadedPlugins.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstUnloadedPlugins_MouseDoubleClick);
            // 
            // btnEditConfig
            // 
            this.btnEditConfig.Location = new System.Drawing.Point(3, 222);
            this.btnEditConfig.Name = "btnEditConfig";
            this.btnEditConfig.Size = new System.Drawing.Size(232, 37);
            this.btnEditConfig.TabIndex = 4;
            this.btnEditConfig.Text = "Edit config for selected plugin";
            this.btnEditConfig.UseVisualStyleBackColor = true;
            this.btnEditConfig.Click += new System.EventHandler(this.btnEditConfig_Click);
            // 
            // btnLoadPlugin
            // 
            this.btnLoadPlugin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLoadPlugin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadPlugin.Location = new System.Drawing.Point(241, 22);
            this.btnLoadPlugin.Name = "btnLoadPlugin";
            this.btnLoadPlugin.Size = new System.Drawing.Size(66, 23);
            this.btnLoadPlugin.TabIndex = 3;
            this.btnLoadPlugin.Text = "<";
            this.btnLoadPlugin.UseVisualStyleBackColor = false;
            this.btnLoadPlugin.Click += new System.EventHandler(this.btnLoadPlugin_Click);
            // 
            // btnUnloadPlugin
            // 
            this.btnUnloadPlugin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUnloadPlugin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnloadPlugin.Location = new System.Drawing.Point(241, 51);
            this.btnUnloadPlugin.Name = "btnUnloadPlugin";
            this.btnUnloadPlugin.Size = new System.Drawing.Size(66, 23);
            this.btnUnloadPlugin.TabIndex = 2;
            this.btnUnloadPlugin.Text = ">";
            this.btnUnloadPlugin.UseVisualStyleBackColor = false;
            this.btnUnloadPlugin.Click += new System.EventHandler(this.btnUnloadPlugin_Click);
            // 
            // grpLoadedPlugins
            // 
            this.grpLoadedPlugins.Controls.Add(this.lstLoadedPlugins);
            this.grpLoadedPlugins.Location = new System.Drawing.Point(3, 3);
            this.grpLoadedPlugins.Name = "grpLoadedPlugins";
            this.grpLoadedPlugins.Size = new System.Drawing.Size(230, 210);
            this.grpLoadedPlugins.TabIndex = 1;
            this.grpLoadedPlugins.TabStop = false;
            this.grpLoadedPlugins.Text = "Loaded Plugins";
            // 
            // lstLoadedPlugins
            // 
            this.lstLoadedPlugins.FormattingEnabled = true;
            this.lstLoadedPlugins.Location = new System.Drawing.Point(6, 19);
            this.lstLoadedPlugins.Name = "lstLoadedPlugins";
            this.lstLoadedPlugins.Size = new System.Drawing.Size(220, 186);
            this.lstLoadedPlugins.TabIndex = 0;
            this.lstLoadedPlugins.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstLoadedPlugins_MouseDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.grpCustomConfig);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(552, 262);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Custom Config";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Be careful, as this code is run unchecked for errors!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Any code entered into here will be saved to a configuration file and run when you" +
    " click \'Apply Config\'\r\n";
            // 
            // grpCustomConfig
            // 
            this.grpCustomConfig.Controls.Add(this.txtCustomConfig);
            this.grpCustomConfig.Location = new System.Drawing.Point(3, 36);
            this.grpCustomConfig.Name = "grpCustomConfig";
            this.grpCustomConfig.Size = new System.Drawing.Size(546, 223);
            this.grpCustomConfig.TabIndex = 0;
            this.grpCustomConfig.TabStop = false;
            this.grpCustomConfig.Text = "Configuration Code";
            // 
            // txtCustomConfig
            // 
            this.txtCustomConfig.Location = new System.Drawing.Point(6, 19);
            this.txtCustomConfig.Multiline = true;
            this.txtCustomConfig.Name = "txtCustomConfig";
            this.txtCustomConfig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomConfig.Size = new System.Drawing.Size(534, 198);
            this.txtCustomConfig.TabIndex = 0;
            // 
            // btnRunInjector
            // 
            this.btnRunInjector.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRunInjector.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRunInjector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunInjector.Location = new System.Drawing.Point(245, 306);
            this.btnRunInjector.Name = "btnRunInjector";
            this.btnRunInjector.Size = new System.Drawing.Size(92, 32);
            this.btnRunInjector.TabIndex = 33;
            this.btnRunInjector.Text = "Start Training";
            this.btnRunInjector.UseVisualStyleBackColor = false;
            this.btnRunInjector.Click += new System.EventHandler(this.btnRunInjector_Click);
            // 
            // btnApplyConfig
            // 
            this.btnApplyConfig.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnApplyConfig.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnApplyConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplyConfig.Location = new System.Drawing.Point(245, 344);
            this.btnApplyConfig.Name = "btnApplyConfig";
            this.btnApplyConfig.Size = new System.Drawing.Size(92, 23);
            this.btnApplyConfig.TabIndex = 34;
            this.btnApplyConfig.Text = "Apply Config";
            this.btnApplyConfig.UseVisualStyleBackColor = false;
            this.btnApplyConfig.Click += new System.EventHandler(this.btnApplyConfig_Click);
            // 
            // btnWiki
            // 
            this.btnWiki.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWiki.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWiki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWiki.Location = new System.Drawing.Point(12, 315);
            this.btnWiki.Name = "btnWiki";
            this.btnWiki.Size = new System.Drawing.Size(113, 23);
            this.btnWiki.TabIndex = 35;
            this.btnWiki.Text = "Wiki";
            this.btnWiki.UseVisualStyleBackColor = false;
            this.btnWiki.Click += new System.EventHandler(this.btnWiki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 379);
            this.Controls.Add(this.btnWiki);
            this.Controls.Add(this.btnApplyConfig);
            this.Controls.Add(this.btnRunInjector);
            this.Controls.Add(this.tabCustomConfig);
            this.Controls.Add(this.btnCommands);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BakkesModGUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCustomConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpLoadedPlugins.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.grpCustomConfig.ResumeLayout(false);
            this.grpCustomConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbKey1;
        private System.Windows.Forms.ComboBox cmbKey2;
        private System.Windows.Forms.ComboBox cmbKey4;
        private System.Windows.Forms.TextBox txtGameSpeed;
        private System.Windows.Forms.Button btnSpeedAdd;
        private System.Windows.Forms.Button btnSpeedSub;
        private System.Windows.Forms.ComboBox cmbKey3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGameSpeed;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCommands;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCommand3;
        private System.Windows.Forms.ComboBox cmbCommand4;
        private System.Windows.Forms.ComboBox cmbCommand2;
        private System.Windows.Forms.ComboBox cmbCommand1;
        private System.Windows.Forms.ComboBox cmbMaps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabCustomConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.CheckBox chkLoadMap;
        private System.Windows.Forms.CheckBox chkGameSpeed;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnRunInjector;
        private System.Windows.Forms.Button btnApplyConfig;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLoadPlugin;
        private System.Windows.Forms.Button btnUnloadPlugin;
        private System.Windows.Forms.GroupBox grpLoadedPlugins;
        private System.Windows.Forms.ListBox lstLoadedPlugins;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpCustomConfig;
        private System.Windows.Forms.TextBox txtCustomConfig;
        private System.Windows.Forms.Button btnEditConfig;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.Button btnUnloadAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstUnloadedPlugins;
        private System.Windows.Forms.Button btnWiki;
    }
}

