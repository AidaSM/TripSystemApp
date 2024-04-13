namespace TripSystemApp.Presentation
{
    partial class BookingForm
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
            this.btnBookAccommodation = new System.Windows.Forms.Button();
            this.btnBookTransportation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBookAccommodation
            // 
            this.btnBookAccommodation.Location = new System.Drawing.Point(98, 100);
            this.btnBookAccommodation.Name = "btnBookAccommodation";
            this.btnBookAccommodation.Size = new System.Drawing.Size(118, 71);
            this.btnBookAccommodation.TabIndex = 0;
            this.btnBookAccommodation.Text = "button1";
            this.btnBookAccommodation.UseVisualStyleBackColor = true;
            this.btnBookAccommodation.Click += new System.EventHandler(this.btnBookAccommodation_Click);
            // 
            // btnBookTransportation
            // 
            this.btnBookTransportation.Location = new System.Drawing.Point(303, 100);
            this.btnBookTransportation.Name = "btnBookTransportation";
            this.btnBookTransportation.Size = new System.Drawing.Size(122, 60);
            this.btnBookTransportation.TabIndex = 1;
            this.btnBookTransportation.Text = "button2";
            this.btnBookTransportation.UseVisualStyleBackColor = true;
            this.btnBookTransportation.Click += new System.EventHandler(this.btnBookTransportation_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBookTransportation);
            this.Controls.Add(this.btnBookAccommodation);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookAccommodation;
        private System.Windows.Forms.Button btnBookTransportation;
    }
}