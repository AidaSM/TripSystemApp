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
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnOpenTripPlanner = new System.Windows.Forms.Button();
            this.dataGridViewTrips = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(706, 27);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // btnOpenTripPlanner
            // 
            this.btnOpenTripPlanner.Location = new System.Drawing.Point(65, 375);
            this.btnOpenTripPlanner.Name = "btnOpenTripPlanner";
            this.btnOpenTripPlanner.Size = new System.Drawing.Size(134, 20);
            this.btnOpenTripPlanner.TabIndex = 1;
            this.btnOpenTripPlanner.Text = "Plan a trip!";
            this.btnOpenTripPlanner.UseVisualStyleBackColor = true;
            this.btnOpenTripPlanner.Click += new System.EventHandler(this.btnOpenTripPlanner_Click);
            // 
            // dataGridViewTrips
            // 
            this.dataGridViewTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrips.Location = new System.Drawing.Point(65, 114);
            this.dataGridViewTrips.Name = "dataGridViewTrips";
            this.dataGridViewTrips.Size = new System.Drawing.Size(577, 187);
            this.dataGridViewTrips.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTrips);
            this.Controls.Add(this.btnOpenTripPlanner);
            this.Controls.Add(this.lblUsername);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnOpenTripPlanner;
        private System.Windows.Forms.DataGridView dataGridViewTrips;
    }
}