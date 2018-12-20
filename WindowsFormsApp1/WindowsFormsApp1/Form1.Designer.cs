namespace WindowsFormsApp1
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
            this.TxtMain = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMain
            // 
            this.TxtMain.Location = new System.Drawing.Point(221, 44);
            this.TxtMain.Name = "TxtMain";
            this.TxtMain.Size = new System.Drawing.Size(331, 26);
            this.TxtMain.TabIndex = 0;
            this.TxtMain.TextChanged += new System.EventHandler(this.TxtMain_TextChanged);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Location = new System.Drawing.Point(728, 641);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(75, 23);
            this.ButtonEnter.TabIndex = 1;
            this.ButtonEnter.Text = "button1";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 838);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.TxtMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMain;
        private System.Windows.Forms.Button ButtonEnter;
    }
}

