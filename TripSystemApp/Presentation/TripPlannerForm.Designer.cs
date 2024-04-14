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
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.lblDestinatie = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbAccommodationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTransportType = new System.Windows.Forms.ComboBox();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSearchResults = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChoose = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChooseAccomm = new System.Windows.Forms.Button();
            this.btnSearchAccomm = new System.Windows.Forms.Button();
            this.dataGridViewAccommodations = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnSearchReturn = new System.Windows.Forms.Button();
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccommodations)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(160, 33);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(200, 20);
            this.txtDestination.TabIndex = 0;
            this.txtDestination.Text = "Paris, France";
            // 
            // lblDestinatie
            // 
            this.lblDestinatie.AutoSize = true;
            this.lblDestinatie.Location = new System.Drawing.Point(31, 37);
            this.lblDestinatie.Name = "lblDestinatie";
            this.lblDestinatie.Size = new System.Drawing.Size(66, 13);
            this.lblDestinatie.TabIndex = 1;
            this.lblDestinatie.Text = "Destination: ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(547, 251);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbAccommodationType
            // 
            this.cmbAccommodationType.FormattingEnabled = true;
            this.cmbAccommodationType.Items.AddRange(new object[] {
            "Hotel",
            "Lodge",
            "Apartment",
            "Resort"});
            this.cmbAccommodationType.Location = new System.Drawing.Point(156, 69);
            this.cmbAccommodationType.Name = "cmbAccommodationType";
            this.cmbAccommodationType.Size = new System.Drawing.Size(102, 21);
            this.cmbAccommodationType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Accommodation Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Transport Type";
            // 
            // cmbTransportType
            // 
            this.cmbTransportType.FormattingEnabled = true;
            this.cmbTransportType.Items.AddRange(new object[] {
            "Flight",
            "Train",
            "Bus",
            "Ferry",
            "Car Rental"});
            this.cmbTransportType.Location = new System.Drawing.Point(160, 100);
            this.cmbTransportType.Name = "cmbTransportType";
            this.cmbTransportType.Size = new System.Drawing.Size(200, 21);
            this.cmbTransportType.TabIndex = 6;
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Location = new System.Drawing.Point(160, 133);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDepartureDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Date";
            // 
            // dataGridViewSearchResults
            // 
            this.dataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResults.Location = new System.Drawing.Point(34, 188);
            this.dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            this.dataGridViewSearchResults.Size = new System.Drawing.Size(445, 243);
            this.dataGridViewSearchResults.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departure: ";
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(160, 66);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(200, 20);
            this.txtDeparture.TabIndex = 13;
            this.txtDeparture.Text = "New York City, United States";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 490);
            this.tabControlMain.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChoose);
            this.tabPage1.Controls.Add(this.txtDestination);
            this.tabPage1.Controls.Add(this.dataGridViewSearchResults);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtpDepartureDate);
            this.tabPage1.Controls.Add(this.lblDestinatie);
            this.tabPage1.Controls.Add(this.txtDeparture);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbTransportType);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "StartTrip";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(547, 317);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(174, 28);
            this.btnChoose.TabIndex = 15;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChooseAccomm);
            this.tabPage2.Controls.Add(this.btnSearchAccomm);
            this.tabPage2.Controls.Add(this.dataGridViewAccommodations);
            this.tabPage2.Controls.Add(this.cmbAccommodationType);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EndTrip";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChooseAccomm
            // 
            this.btnChooseAccomm.Location = new System.Drawing.Point(528, 265);
            this.btnChooseAccomm.Name = "btnChooseAccomm";
            this.btnChooseAccomm.Size = new System.Drawing.Size(174, 28);
            this.btnChooseAccomm.TabIndex = 17;
            this.btnChooseAccomm.Text = "Choose";
            this.btnChooseAccomm.UseVisualStyleBackColor = true;
            // 
            // btnSearchAccomm
            // 
            this.btnSearchAccomm.Location = new System.Drawing.Point(528, 199);
            this.btnSearchAccomm.Name = "btnSearchAccomm";
            this.btnSearchAccomm.Size = new System.Drawing.Size(174, 28);
            this.btnSearchAccomm.TabIndex = 16;
            this.btnSearchAccomm.Text = "Search";
            this.btnSearchAccomm.UseVisualStyleBackColor = true;
            this.btnSearchAccomm.Click += new System.EventHandler(this.btnSearchReturn_Click);
            // 
            // dataGridViewAccommodations
            // 
            this.dataGridViewAccommodations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccommodations.Location = new System.Drawing.Point(26, 142);
            this.dataGridViewAccommodations.Name = "dataGridViewAccommodations";
            this.dataGridViewAccommodations.Size = new System.Drawing.Size(445, 243);
            this.dataGridViewAccommodations.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnFinish);
            this.tabPage3.Controls.Add(this.btnSearchReturn);
            this.tabPage3.Controls.Add(this.dataGridViewReturn);
            this.tabPage3.Controls.Add(this.dtpReturnDate);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(545, 263);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(174, 28);
            this.btnFinish.TabIndex = 22;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnSearchReturn
            // 
            this.btnSearchReturn.Location = new System.Drawing.Point(545, 197);
            this.btnSearchReturn.Name = "btnSearchReturn";
            this.btnSearchReturn.Size = new System.Drawing.Size(174, 28);
            this.btnSearchReturn.TabIndex = 21;
            this.btnSearchReturn.Text = "Search";
            this.btnSearchReturn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Location = new System.Drawing.Point(43, 140);
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.Size = new System.Drawing.Size(445, 243);
            this.dataGridViewReturn.TabIndex = 20;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(169, 74);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReturnDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Return Date";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 464);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TripPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.tabControlMain);
            this.Name = "TripPlannerForm";
            this.Text = "TripPlannerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccommodations)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblDestinatie;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbAccommodationType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTransportType;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSearchResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DataGridView dataGridViewAccommodations;
        private System.Windows.Forms.Button btnChooseAccomm;
        private System.Windows.Forms.Button btnSearchAccomm;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnSearchReturn;
        private System.Windows.Forms.DataGridView dataGridViewReturn;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
    }
}