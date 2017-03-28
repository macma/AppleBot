namespace AppleBot
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
            this.btn_start = new System.Windows.Forms.Button();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPage3 = new System.Windows.Forms.Button();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCapcha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(139, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(115, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Open Browser";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(12, 12);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(121, 21);
            this.cbxUser.TabIndex = 16;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(421, 11);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPage3
            // 
            this.btnPage3.Location = new System.Drawing.Point(502, 11);
            this.btnPage3.Name = "btnPage3";
            this.btnPage3.Size = new System.Drawing.Size(75, 23);
            this.btnPage3.TabIndex = 18;
            this.btnPage3.Text = "Page3";
            this.btnPage3.UseVisualStyleBackColor = true;
            this.btnPage3.Click += new System.EventHandler(this.btnPage3_Click);
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Location = new System.Drawing.Point(584, 12);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(102, 23);
            this.btnCheckAvailability.TabIndex = 19;
            this.btnCheckAvailability.Text = "Check Availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(12, 40);
            this.txtAvailable.Multiline = true;
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(356, 26);
            this.txtAvailable.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 545);
            this.panel1.TabIndex = 21;
            // 
            // tbCapcha
            // 
            this.tbCapcha.Location = new System.Drawing.Point(315, 13);
            this.tbCapcha.Name = "tbCapcha";
            this.tbCapcha.Size = new System.Drawing.Size(100, 20);
            this.tbCapcha.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 629);
            this.Controls.Add(this.tbCapcha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.btnPage3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPage3;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCapcha;
    }
}

