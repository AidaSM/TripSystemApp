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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.txtRegUsername.Location = new System.Drawing.Point(454, 111);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(237, 20);
            this.txtRegUsername.TabIndex = 4;
            // 
            // txtRegPass1
            // 
            this.txtRegPass1.Location = new System.Drawing.Point(454, 159);
            this.txtRegPass1.Name = "txtRegPass1";
            this.txtRegPass1.Size = new System.Drawing.Size(237, 20);
            this.txtRegPass1.TabIndex = 5;
            this.txtRegPass1.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogin.Location = new System.Drawing.Point(101, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReg.Location = new System.Drawing.Point(517, 352);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(107, 36);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
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
            this.txtRegFirstName.Location = new System.Drawing.Point(454, 255);
            this.txtRegFirstName.Name = "txtRegFirstName";
            this.txtRegFirstName.Size = new System.Drawing.Size(237, 20);
            this.txtRegFirstName.TabIndex = 9;
            // 
            // txtRegLastName
            // 
            this.txtRegLastName.Location = new System.Drawing.Point(454, 303);
            this.txtRegLastName.Name = "txtRegLastName";
            this.txtRegLastName.Size = new System.Drawing.Size(237, 20);
            this.txtRegLastName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Confirm password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "First name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Last name:";
            // 
            // UserAuthRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TripSystemApp.Properties.Resources.road_trip_activity_background_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}