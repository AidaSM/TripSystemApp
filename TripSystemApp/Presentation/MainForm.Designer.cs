namespace TripSystemApp.Presentation
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
            this.btnTripPlanner = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTripPlanner
            // 
            this.btnTripPlanner.Location = new System.Drawing.Point(113, 103);
            this.btnTripPlanner.Name = "btnTripPlanner";
            this.btnTripPlanner.Size = new System.Drawing.Size(83, 54);
            this.btnTripPlanner.TabIndex = 0;
            this.btnTripPlanner.Text = "button1";
            this.btnTripPlanner.UseVisualStyleBackColor = true;
            this.btnTripPlanner.Click += new System.EventHandler(this.btnTripPlanner_Click_1);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(316, 103);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(80, 54);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "button2";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnTripPlanner);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTripPlanner;
        private System.Windows.Forms.Button btnBooking;
    }
}