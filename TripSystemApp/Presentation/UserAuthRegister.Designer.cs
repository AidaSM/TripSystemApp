namespace TripSystemApp.Presentation
{
    partial class UserAuthRegister
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
            this.txtAuthEmail = new System.Windows.Forms.TextBox();
            this.txtAuthPass = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegPass1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtRegPass2 = new System.Windows.Forms.TextBox();
            this.txtRegFirstName = new System.Windows.Forms.TextBox();
            this.txtRegLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAuthEmail
            // 
            this.txtAuthEmail.Location = new System.Drawing.Point(54, 113);
            this.txtAuthEmail.Name = "txtAuthEmail";
            this.txtAuthEmail.Size = new System.Drawing.Size(237, 20);
            this.txtAuthEmail.TabIndex = 1;
            // 
            // txtAuthPass
            // 
            this.txtAuthPass.Location = new System.Drawing.Point(54, 183);
            this.txtAuthPass.Name = "txtAuthPass";
            this.txtAuthPass.Size = new System.Drawing.Size(237, 20);
            this.txtAuthPass.TabIndex = 2;
            this.txtAuthPass.UseSystemPasswordChar = true;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(454, 63);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(237, 20);
            this.txtRegEmail.TabIndex = 3;
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(454, 113);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(237, 20);
            this.txtRegUsername.TabIndex = 4;
            // 
            // txtRegPass1
            // 
            this.txtRegPass1.Location = new System.Drawing.Point(454, 160);
            this.txtRegPass1.Name = "txtRegPass1";
            this.txtRegPass1.Size = new System.Drawing.Size(237, 20);
            this.txtRegPass1.TabIndex = 5;
            this.txtRegPass1.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(108, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "button1";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(516, 359);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(107, 36);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "button2";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtRegPass2
            // 
            this.txtRegPass2.Location = new System.Drawing.Point(454, 207);
            this.txtRegPass2.Name = "txtRegPass2";
            this.txtRegPass2.Size = new System.Drawing.Size(237, 20);
            this.txtRegPass2.TabIndex = 8;
            this.txtRegPass2.UseSystemPasswordChar = true;
            // 
            // txtRegFirstName
            // 
            this.txtRegFirstName.Location = new System.Drawing.Point(454, 253);
            this.txtRegFirstName.Name = "txtRegFirstName";
            this.txtRegFirstName.Size = new System.Drawing.Size(237, 20);
            this.txtRegFirstName.TabIndex = 9;
            // 
            // txtRegLastName
            // 
            this.txtRegLastName.Location = new System.Drawing.Point(454, 305);
            this.txtRegLastName.Name = "txtRegLastName";
            this.txtRegLastName.Size = new System.Drawing.Size(237, 20);
            this.txtRegLastName.TabIndex = 10;
            // 
            // UserAuthRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRegLastName);
            this.Controls.Add(this.txtRegFirstName);
            this.Controls.Add(this.txtRegPass2);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtRegPass1);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.txtAuthPass);
            this.Controls.Add(this.txtAuthEmail);
            this.Name = "UserAuthRegister";
            this.Text = "UserAuthRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthEmail;
        private System.Windows.Forms.TextBox txtAuthPass;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegPass1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtRegPass2;
        private System.Windows.Forms.TextBox txtRegFirstName;
        private System.Windows.Forms.TextBox txtRegLastName;
    }
}