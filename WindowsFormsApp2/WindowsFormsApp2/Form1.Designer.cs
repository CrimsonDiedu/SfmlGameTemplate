namespace WindowsFormsApp2
{
    partial class Form1
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
            this.LblRace = new System.Windows.Forms.Label();
            this.GRP_BasicInfo = new System.Windows.Forms.GroupBox();
            this.LblClass = new System.Windows.Forms.Label();
            this.CbxRace = new System.Windows.Forms.ComboBox();
            this.NudAge = new System.Windows.Forms.NumericUpDown();
            this.LblAge = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.CbxClass = new System.Windows.Forms.ComboBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.BtnRoll = new System.Windows.Forms.Button();
            this.GrpStats = new System.Windows.Forms.GroupBox();
            this.LblPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NudCharisma = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NudWisdom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NudIntelligence = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NudConstitution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NudDexterity = new System.Windows.Forms.NumericUpDown();
            this.LblStrength = new System.Windows.Forms.Label();
            this.NudStrength = new System.Windows.Forms.NumericUpDown();
            this.LbxCharacters = new System.Windows.Forms.ListBox();
            this.GrpSpecific = new System.Windows.Forms.GroupBox();
            this.CbxCS2familiar = new System.Windows.Forms.ComboBox();
            this.CbxCS1 = new System.Windows.Forms.ComboBox();
            this.CbxCS2size = new System.Windows.Forms.ComboBox();
            this.NudCS1 = new System.Windows.Forms.NumericUpDown();
            this.LblClassSpecific2 = new System.Windows.Forms.Label();
            this.LblClassSpecific1 = new System.Windows.Forms.Label();
            this.lblCP1 = new System.Windows.Forms.Label();
            this.MtpMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GRP_BasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).BeginInit();
            this.GrpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStrength)).BeginInit();
            this.GrpSpecific.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCS1)).BeginInit();
            this.MtpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblRace
            // 
            this.LblRace.AutoSize = true;
            this.LblRace.Location = new System.Drawing.Point(17, 175);
            this.LblRace.Name = "LblRace";
            this.LblRace.Size = new System.Drawing.Size(47, 20);
            this.LblRace.TabIndex = 0;
            this.LblRace.Text = "Race";
            this.LblRace.Click += new System.EventHandler(this.LBL_Click);
            // 
            // GRP_BasicInfo
            // 
            this.GRP_BasicInfo.Controls.Add(this.LblClass);
            this.GRP_BasicInfo.Controls.Add(this.CbxRace);
            this.GRP_BasicInfo.Controls.Add(this.NudAge);
            this.GRP_BasicInfo.Controls.Add(this.LblAge);
            this.GRP_BasicInfo.Controls.Add(this.TxtLastName);
            this.GRP_BasicInfo.Controls.Add(this.TxtFirstName);
            this.GRP_BasicInfo.Controls.Add(this.LblLastName);
            this.GRP_BasicInfo.Controls.Add(this.CbxClass);
            this.GRP_BasicInfo.Controls.Add(this.LblFirstName);
            this.GRP_BasicInfo.Controls.Add(this.LblRace);
            this.GRP_BasicInfo.Location = new System.Drawing.Point(95, 44);
            this.GRP_BasicInfo.Name = "GRP_BasicInfo";
            this.GRP_BasicInfo.Size = new System.Drawing.Size(319, 248);
            this.GRP_BasicInfo.TabIndex = 1;
            this.GRP_BasicInfo.TabStop = false;
            this.GRP_BasicInfo.Text = "Basic Info";
            this.GRP_BasicInfo.UseCompatibleTextRendering = true;
            // 
            // LblClass
            // 
            this.LblClass.AutoSize = true;
            this.LblClass.Location = new System.Drawing.Point(18, 217);
            this.LblClass.Name = "LblClass";
            this.LblClass.Size = new System.Drawing.Size(48, 20);
            this.LblClass.TabIndex = 11;
            this.LblClass.Text = "Class";
            // 
            // CbxRace
            // 
            this.CbxRace.BackColor = System.Drawing.SystemColors.Control;
            this.CbxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxRace.FormattingEnabled = true;
            this.CbxRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Halfling",
            "Human"});
            this.CbxRace.Location = new System.Drawing.Point(140, 172);
            this.CbxRace.Name = "CbxRace";
            this.CbxRace.Size = new System.Drawing.Size(121, 28);
            this.CbxRace.TabIndex = 10;
            this.CbxRace.SelectedIndexChanged += new System.EventHandler(this.CbxRace_SelectedIndexChanged);
            // 
            // NudAge
            // 
            this.NudAge.Location = new System.Drawing.Point(139, 132);
            this.NudAge.Name = "NudAge";
            this.NudAge.Size = new System.Drawing.Size(120, 26);
            this.NudAge.TabIndex = 9;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(17, 134);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(38, 20);
            this.LblAge.TabIndex = 2;
            this.LblAge.Text = "Age";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(139, 92);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(121, 26);
            this.TxtLastName.TabIndex = 7;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(139, 52);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(121, 26);
            this.TxtFirstName.TabIndex = 6;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(17, 93);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(86, 20);
            this.LblLastName.TabIndex = 5;
            this.LblLastName.Text = "Last Name";
            // 
            // CbxClass
            // 
            this.CbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxClass.FormattingEnabled = true;
            this.CbxClass.Items.AddRange(new object[] {
            "Cleric",
            "Fighter",
            "Monk",
            "Paladin",
            "Rogue",
            "Sorcerer",
            "Druid",
            "Ranger",
            "Wizard"});
            this.CbxClass.Location = new System.Drawing.Point(139, 214);
            this.CbxClass.Name = "CbxClass";
            this.CbxClass.Size = new System.Drawing.Size(121, 28);
            this.CbxClass.TabIndex = 3;
            this.CbxClass.SelectedIndexChanged += new System.EventHandler(this.CbxClass_SelectedIndexChanged_1);
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(17, 52);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(86, 20);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "First Name";
            // 
            // BtnRoll
            // 
            this.BtnRoll.Location = new System.Drawing.Point(106, 337);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(75, 33);
            this.BtnRoll.TabIndex = 8;
            this.BtnRoll.Text = "Roll";
            this.BtnRoll.UseVisualStyleBackColor = true;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // GrpStats
            // 
            this.GrpStats.Controls.Add(this.LblPoints);
            this.GrpStats.Controls.Add(this.label5);
            this.GrpStats.Controls.Add(this.NudCharisma);
            this.GrpStats.Controls.Add(this.label4);
            this.GrpStats.Controls.Add(this.BtnRoll);
            this.GrpStats.Controls.Add(this.NudWisdom);
            this.GrpStats.Controls.Add(this.label3);
            this.GrpStats.Controls.Add(this.NudIntelligence);
            this.GrpStats.Controls.Add(this.label2);
            this.GrpStats.Controls.Add(this.NudConstitution);
            this.GrpStats.Controls.Add(this.label1);
            this.GrpStats.Controls.Add(this.NudDexterity);
            this.GrpStats.Controls.Add(this.LblStrength);
            this.GrpStats.Controls.Add(this.NudStrength);
            this.GrpStats.Location = new System.Drawing.Point(95, 298);
            this.GrpStats.Name = "GrpStats";
            this.GrpStats.Size = new System.Drawing.Size(319, 385);
            this.GrpStats.TabIndex = 9;
            this.GrpStats.TabStop = false;
            this.GrpStats.Text = "Stats";
            this.GrpStats.Enter += new System.EventHandler(this.GrpStats_Enter);
            // 
            // LblPoints
            // 
            this.LblPoints.AutoSize = true;
            this.LblPoints.Location = new System.Drawing.Point(18, 292);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(111, 20);
            this.LblPoints.TabIndex = 11;
            this.LblPoints.Text = "Points Left: 20";
            this.LblPoints.Click += new System.EventHandler(this.LblPoints_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Charisma";
            // 
            // NudCharisma
            // 
            this.NudCharisma.Location = new System.Drawing.Point(140, 256);
            this.NudCharisma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudCharisma.Name = "NudCharisma";
            this.NudCharisma.Size = new System.Drawing.Size(120, 26);
            this.NudCharisma.TabIndex = 20;
            this.NudCharisma.ValueChanged += new System.EventHandler(this.NudCharisma_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Wisdom";
            // 
            // NudWisdom
            // 
            this.NudWisdom.Location = new System.Drawing.Point(140, 210);
            this.NudWisdom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudWisdom.Name = "NudWisdom";
            this.NudWisdom.Size = new System.Drawing.Size(120, 26);
            this.NudWisdom.TabIndex = 18;
            this.NudWisdom.ValueChanged += new System.EventHandler(this.NudWisdom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Intelligence";
            // 
            // NudIntelligence
            // 
            this.NudIntelligence.Location = new System.Drawing.Point(140, 164);
            this.NudIntelligence.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudIntelligence.Name = "NudIntelligence";
            this.NudIntelligence.Size = new System.Drawing.Size(120, 26);
            this.NudIntelligence.TabIndex = 16;
            this.NudIntelligence.ValueChanged += new System.EventHandler(this.NudIntelligence_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Constitution";
            // 
            // NudConstitution
            // 
            this.NudConstitution.Location = new System.Drawing.Point(140, 118);
            this.NudConstitution.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudConstitution.Name = "NudConstitution";
            this.NudConstitution.Size = new System.Drawing.Size(120, 26);
            this.NudConstitution.TabIndex = 14;
            this.NudConstitution.ValueChanged += new System.EventHandler(this.NudConstitution_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dexterity";
            // 
            // NudDexterity
            // 
            this.NudDexterity.Location = new System.Drawing.Point(140, 72);
            this.NudDexterity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudDexterity.Name = "NudDexterity";
            this.NudDexterity.Size = new System.Drawing.Size(120, 26);
            this.NudDexterity.TabIndex = 12;
            this.NudDexterity.ValueChanged += new System.EventHandler(this.NudDexterity_ValueChanged);
            // 
            // LblStrength
            // 
            this.LblStrength.AutoSize = true;
            this.LblStrength.Location = new System.Drawing.Point(18, 26);
            this.LblStrength.Name = "LblStrength";
            this.LblStrength.Size = new System.Drawing.Size(71, 20);
            this.LblStrength.TabIndex = 10;
            this.LblStrength.Text = "Strength";
            // 
            // NudStrength
            // 
            this.NudStrength.Location = new System.Drawing.Point(140, 26);
            this.NudStrength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudStrength.Name = "NudStrength";
            this.NudStrength.Size = new System.Drawing.Size(120, 26);
            this.NudStrength.TabIndex = 10;
            this.NudStrength.ValueChanged += new System.EventHandler(this.NudStrength_ValueChanged);
            // 
            // LbxCharacters
            // 
            this.LbxCharacters.FormattingEnabled = true;
            this.LbxCharacters.ItemHeight = 20;
            this.LbxCharacters.Location = new System.Drawing.Point(460, 44);
            this.LbxCharacters.Name = "LbxCharacters";
            this.LbxCharacters.Size = new System.Drawing.Size(479, 664);
            this.LbxCharacters.TabIndex = 11;
            this.LbxCharacters.SelectedIndexChanged += new System.EventHandler(this.LbxCharacters_SelectedIndexChanged);
            // 
            // GrpSpecific
            // 
            this.GrpSpecific.Controls.Add(this.CbxCS2familiar);
            this.GrpSpecific.Controls.Add(this.CbxCS1);
            this.GrpSpecific.Controls.Add(this.CbxCS2size);
            this.GrpSpecific.Controls.Add(this.NudCS1);
            this.GrpSpecific.Controls.Add(this.LblClassSpecific2);
            this.GrpSpecific.Controls.Add(this.LblClassSpecific1);
            this.GrpSpecific.Controls.Add(this.lblCP1);
            this.GrpSpecific.Location = new System.Drawing.Point(95, 714);
            this.GrpSpecific.Name = "GrpSpecific";
            this.GrpSpecific.Size = new System.Drawing.Size(319, 138);
            this.GrpSpecific.TabIndex = 12;
            this.GrpSpecific.TabStop = false;
            this.GrpSpecific.Text = "Class Specific";
            // 
            // CbxCS2familiar
            // 
            this.CbxCS2familiar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCS2familiar.FormattingEnabled = true;
            this.CbxCS2familiar.Items.AddRange(new object[] {
            "Bat",
            "Owl",
            "Toad"});
            this.CbxCS2familiar.Location = new System.Drawing.Point(176, 96);
            this.CbxCS2familiar.Name = "CbxCS2familiar";
            this.CbxCS2familiar.Size = new System.Drawing.Size(121, 28);
            this.CbxCS2familiar.TabIndex = 18;
            this.CbxCS2familiar.Visible = false;
            // 
            // CbxCS1
            // 
            this.CbxCS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCS1.FormattingEnabled = true;
            this.CbxCS1.Items.AddRange(new object[] {
            "Bear",
            "Cat",
            "Hawk",
            "Wolf"});
            this.CbxCS1.Location = new System.Drawing.Point(177, 57);
            this.CbxCS1.Name = "CbxCS1";
            this.CbxCS1.Size = new System.Drawing.Size(121, 28);
            this.CbxCS1.TabIndex = 17;
            this.CbxCS1.Visible = false;
            // 
            // CbxCS2size
            // 
            this.CbxCS2size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCS2size.FormattingEnabled = true;
            this.CbxCS2size.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.CbxCS2size.Location = new System.Drawing.Point(176, 96);
            this.CbxCS2size.Name = "CbxCS2size";
            this.CbxCS2size.Size = new System.Drawing.Size(121, 28);
            this.CbxCS2size.TabIndex = 12;
            this.CbxCS2size.Visible = false;
            this.CbxCS2size.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NudCS1
            // 
            this.NudCS1.Location = new System.Drawing.Point(177, 57);
            this.NudCS1.Name = "NudCS1";
            this.NudCS1.Size = new System.Drawing.Size(120, 26);
            this.NudCS1.TabIndex = 16;
            this.NudCS1.Visible = false;
            // 
            // LblClassSpecific2
            // 
            this.LblClassSpecific2.AutoSize = true;
            this.LblClassSpecific2.Location = new System.Drawing.Point(24, 104);
            this.LblClassSpecific2.Name = "LblClassSpecific2";
            this.LblClassSpecific2.Size = new System.Drawing.Size(12, 20);
            this.LblClassSpecific2.TabIndex = 15;
            this.LblClassSpecific2.Text = "\'";
            this.LblClassSpecific2.Click += new System.EventHandler(this.LblClassSpecific2_Click);
            // 
            // LblClassSpecific1
            // 
            this.LblClassSpecific1.AutoSize = true;
            this.LblClassSpecific1.Location = new System.Drawing.Point(24, 57);
            this.LblClassSpecific1.Name = "LblClassSpecific1";
            this.LblClassSpecific1.Size = new System.Drawing.Size(12, 20);
            this.LblClassSpecific1.TabIndex = 14;
            this.LblClassSpecific1.Text = "\'";
            // 
            // lblCP1
            // 
            this.lblCP1.AutoSize = true;
            this.lblCP1.Location = new System.Drawing.Point(18, 40);
            this.lblCP1.Name = "lblCP1";
            this.lblCP1.Size = new System.Drawing.Size(0, 20);
            this.lblCP1.TabIndex = 14;
            // 
            // MtpMenu
            // 
            this.MtpMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MtpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.MtpMenu.Location = new System.Drawing.Point(0, 0);
            this.MtpMenu.Name = "MtpMenu";
            this.MtpMenu.Size = new System.Drawing.Size(993, 33);
            this.MtpMenu.TabIndex = 13;
            this.MtpMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterToolStripMenuItem,
            this.listToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(131, 30);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // characterToolStripMenuItem
            // 
            this.characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            this.characterToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.characterToolStripMenuItem.Text = "Character";
            this.characterToolStripMenuItem.Click += new System.EventHandler(this.characterToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.actionsToolStripMenuItem.Text = "Actions";
            this.actionsToolStripMenuItem.Click += new System.EventHandler(this.actionsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 878);
            this.Controls.Add(this.GrpSpecific);
            this.Controls.Add(this.LbxCharacters);
            this.Controls.Add(this.MtpMenu);
            this.Controls.Add(this.GrpStats);
            this.Controls.Add(this.GRP_BasicInfo);
            this.MainMenuStrip = this.MtpMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.GRP_BasicInfo.ResumeLayout(false);
            this.GRP_BasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).EndInit();
            this.GrpStats.ResumeLayout(false);
            this.GrpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStrength)).EndInit();
            this.GrpSpecific.ResumeLayout(false);
            this.GrpSpecific.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudCS1)).EndInit();
            this.MtpMenu.ResumeLayout(false);
            this.MtpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRace;
        private System.Windows.Forms.GroupBox GRP_BasicInfo;
        private System.Windows.Forms.ComboBox CbxClass;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.GroupBox GrpStats;
        private System.Windows.Forms.NumericUpDown NudAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudCharisma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudWisdom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudIntelligence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudConstitution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudDexterity;
        private System.Windows.Forms.Label LblStrength;
        private System.Windows.Forms.NumericUpDown NudStrength;
        private System.Windows.Forms.Label LblPoints;
        private System.Windows.Forms.ListBox LbxCharacters;
        private System.Windows.Forms.ComboBox CbxRace;
        private System.Windows.Forms.Label LblClass;
        private System.Windows.Forms.GroupBox GrpSpecific;
        private System.Windows.Forms.MenuStrip MtpMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label lblCP1;
        private System.Windows.Forms.Label LblClassSpecific1;
        private System.Windows.Forms.Label LblClassSpecific2;
        private System.Windows.Forms.NumericUpDown NudCS1;
        private System.Windows.Forms.ComboBox CbxCS2size;
        private System.Windows.Forms.ComboBox CbxCS1;
        private System.Windows.Forms.ComboBox CbxCS2familiar;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
    }
}

