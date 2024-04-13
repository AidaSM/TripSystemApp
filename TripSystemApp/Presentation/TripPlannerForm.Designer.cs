namespace TripSystemApp.Presentation
{
    partial class TripPlannerForm
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
            this.btnSearchDestinations = new System.Windows.Forms.Button();
            this.btnSearchAccommodations = new System.Windows.Forms.Button();
            this.btnSearchTransportation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchDestinations
            // 
            this.btnSearchDestinations.Location = new System.Drawing.Point(130, 102);
            this.btnSearchDestinations.Name = "btnSearchDestinations";
            this.btnSearchDestinations.Size = new System.Drawing.Size(87, 60);
            this.btnSearchDestinations.TabIndex = 0;
            this.btnSearchDestinations.Text = "button1";
            this.btnSearchDestinations.UseVisualStyleBackColor = true;
            this.btnSearchDestinations.Click += new System.EventHandler(this.btnSearchDestinations_Click);
            // 
            // btnSearchAccommodations
            // 
            this.btnSearchAccommodations.Location = new System.Drawing.Point(259, 109);
            this.btnSearchAccommodations.Name = "btnSearchAccommodations";
            this.btnSearchAccommodations.Size = new System.Drawing.Size(119, 52);
            this.btnSearchAccommodations.TabIndex = 1;
            this.btnSearchAccommodations.Text = "button2";
            this.btnSearchAccommodations.UseVisualStyleBackColor = true;
            this.btnSearchAccommodations.Click += new System.EventHandler(this.btnSearchAccommodations_Click);
            // 
            // btnSearchTransportation
            // 
            this.btnSearchTransportation.Location = new System.Drawing.Point(422, 111);
            this.btnSearchTransportation.Name = "btnSearchTransportation";
            this.btnSearchTransportation.Size = new System.Drawing.Size(70, 49);
            this.btnSearchTransportation.TabIndex = 2;
            this.btnSearchTransportation.Text = "button3";
            this.btnSearchTransportation.UseVisualStyleBackColor = true;
            this.btnSearchTransportation.Click += new System.EventHandler(this.btnSearchTransportation_Click);
            // 
            // TripPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchTransportation);
            this.Controls.Add(this.btnSearchAccommodations);
            this.Controls.Add(this.btnSearchDestinations);
            this.Name = "TripPlanner";
            this.Text = "TripPlanner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDestinations;
        private System.Windows.Forms.Button btnSearchAccommodations;
        private System.Windows.Forms.Button btnSearchTransportation;
    }
}