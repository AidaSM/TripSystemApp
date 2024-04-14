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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(641, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 27);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // btnOpenTripPlanner
            // 
            this.btnOpenTripPlanner.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenTripPlanner.Location = new System.Drawing.Point(65, 376);
            this.btnOpenTripPlanner.Name = "btnOpenTripPlanner";
            this.btnOpenTripPlanner.Size = new System.Drawing.Size(162, 34);
            this.btnOpenTripPlanner.TabIndex = 1;
            this.btnOpenTripPlanner.Text = "Plan a trip!";
            this.btnOpenTripPlanner.UseVisualStyleBackColor = false;
            this.btnOpenTripPlanner.Click += new System.EventHandler(this.btnOpenTripPlanner_Click);
            // 
            // dataGridViewTrips
            // 
            this.dataGridViewTrips.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrips.Location = new System.Drawing.Point(65, 102);
            this.dataGridViewTrips.Name = "dataGridViewTrips";
            this.dataGridViewTrips.ReadOnly = true;
            this.dataGridViewTrips.Size = new System.Drawing.Size(696, 246);
            this.dataGridViewTrips.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your trips";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TripSystemApp.Properties.Resources.road_trip_activity_background_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}