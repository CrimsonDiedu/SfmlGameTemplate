namespace PG2Lab8
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
            this.RadEmployee = new System.Windows.Forms.RadioButton();
            this.RadManager = new System.Windows.Forms.RadioButton();
            this.NudAge = new System.Windows.Forms.NumericUpDown();
            this.GrpData = new System.Windows.Forms.GroupBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.NudBonus = new System.Windows.Forms.NumericUpDown();
            this.NudSalary = new System.Windows.Forms.NumericUpDown();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.LstPeople = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).BeginInit();
            this.GrpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // RadEmployee
            // 
            this.RadEmployee.AutoSize = true;
            this.RadEmployee.Location = new System.Drawing.Point(16, 46);
            this.RadEmployee.Name = "RadEmployee";
            this.RadEmployee.Size = new System.Drawing.Size(104, 24);
            this.RadEmployee.TabIndex = 0;
            this.RadEmployee.TabStop = true;
            this.RadEmployee.Text = "Employee";
            this.RadEmployee.UseVisualStyleBackColor = true;
            // 
            // RadManager
            // 
            this.RadManager.AutoSize = true;
            this.RadManager.Location = new System.Drawing.Point(199, 46);
            this.RadManager.Name = "RadManager";
            this.RadManager.Size = new System.Drawing.Size(97, 24);
            this.RadManager.TabIndex = 1;
            this.RadManager.TabStop = true;
            this.RadManager.Text = "Manager";
            this.RadManager.UseVisualStyleBackColor = true;
            this.RadManager.CheckedChanged += new System.EventHandler(this.RadManager_CheckedChanged);
            // 
            // NudAge
            // 
            this.NudAge.Location = new System.Drawing.Point(16, 294);
            this.NudAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NudAge.Name = "NudAge";
            this.NudAge.Size = new System.Drawing.Size(120, 26);
            this.NudAge.TabIndex = 3;
            // 
            // GrpData
            // 
            this.GrpData.BackColor = System.Drawing.SystemColors.Control;
            this.GrpData.Controls.Add(this.lblBonus);
            this.GrpData.Controls.Add(this.lblSalary);
            this.GrpData.Controls.Add(this.lblAge);
            this.GrpData.Controls.Add(this.lblLastName);
            this.GrpData.Controls.Add(this.txtLastName);
            this.GrpData.Controls.Add(this.LblName);
            this.GrpData.Controls.Add(this.TxtName);
            this.GrpData.Controls.Add(this.NudBonus);
            this.GrpData.Controls.Add(this.NudSalary);
            this.GrpData.Controls.Add(this.RadEmployee);
            this.GrpData.Controls.Add(this.RadManager);
            this.GrpData.Controls.Add(this.NudAge);
            this.GrpData.Location = new System.Drawing.Point(12, 21);
            this.GrpData.Name = "GrpData";
            this.GrpData.Size = new System.Drawing.Size(413, 404);
            this.GrpData.TabIndex = 4;
            this.GrpData.TabStop = false;
            this.GrpData.Text = "Data Fields";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(121, 358);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(55, 20);
            this.lblBonus.TabIndex = 11;
            this.lblBonus.Text = "Bonus";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(195, 258);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(53, 20);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Salary";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 258);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 178);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(16, 218);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(232, 26);
            this.txtLastName.TabIndex = 8;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 87);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(51, 20);
            this.LblName.TabIndex = 5;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(16, 126);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(232, 26);
            this.TxtName.TabIndex = 6;
            // 
            // NudBonus
            // 
            this.NudBonus.DecimalPlaces = 2;
            this.NudBonus.Enabled = false;
            this.NudBonus.Location = new System.Drawing.Point(199, 356);
            this.NudBonus.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudBonus.Name = "NudBonus";
            this.NudBonus.Size = new System.Drawing.Size(120, 26);
            this.NudBonus.TabIndex = 5;
            this.NudBonus.ThousandsSeparator = true;
            // 
            // NudSalary
            // 
            this.NudSalary.DecimalPlaces = 2;
            this.NudSalary.Location = new System.Drawing.Point(200, 294);
            this.NudSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudSalary.Name = "NudSalary";
            this.NudSalary.Size = new System.Drawing.Size(120, 26);
            this.NudSalary.TabIndex = 4;
            this.NudSalary.ThousandsSeparator = true;
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Location = new System.Drawing.Point(28, 446);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(132, 43);
            this.BtnAddPerson.TabIndex = 12;
            this.BtnAddPerson.Text = "Add Person";
            this.BtnAddPerson.UseVisualStyleBackColor = true;
            this.BtnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // LstPeople
            // 
            this.LstPeople.FormattingEnabled = true;
            this.LstPeople.ItemHeight = 20;
            this.LstPeople.Location = new System.Drawing.Point(440, 21);
            this.LstPeople.Name = "LstPeople";
            this.LstPeople.Size = new System.Drawing.Size(573, 484);
            this.LstPeople.TabIndex = 5;
            this.LstPeople.SelectedIndexChanged += new System.EventHandler(this.LstPeople_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(212, 446);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 43);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove Person";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1025, 537);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.BtnAddPerson);
            this.Controls.Add(this.LstPeople);
            this.Controls.Add(this.GrpData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Employee Info (Sabian McElroy)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudAge)).EndInit();
            this.GrpData.ResumeLayout(false);
            this.GrpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RadEmployee;
        private System.Windows.Forms.RadioButton RadManager;
        private System.Windows.Forms.NumericUpDown NudAge;
        private System.Windows.Forms.GroupBox GrpData;
        private System.Windows.Forms.NumericUpDown NudBonus;
        private System.Windows.Forms.NumericUpDown NudSalary;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnAddPerson;
        private System.Windows.Forms.ListBox LstPeople;
        private System.Windows.Forms.Button btnRemove;
    }
}

