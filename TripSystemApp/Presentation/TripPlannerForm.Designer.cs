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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTransportTypeReturn = new System.Windows.Forms.ComboBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnSearchReturn = new System.Windows.Forms.Button();
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnBookTrip = new System.Windows.Forms.Button();
            this.lblTransportTypeReturn = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblAccommodation = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblTransportTypeDeparture = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccommodations)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            this.tabPage4.SuspendLayout();
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
            this.lblDestinatie.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDestinatie.Location = new System.Drawing.Point(31, 37);
            this.lblDestinatie.Name = "lblDestinatie";
            this.lblDestinatie.Size = new System.Drawing.Size(86, 16);
            this.lblDestinatie.TabIndex = 1;
            this.lblDestinatie.Text = "Destination: ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(524, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(174, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.cmbAccommodationType.Location = new System.Drawing.Point(177, 76);
            this.cmbAccommodationType.Name = "cmbAccommodationType";
            this.cmbAccommodationType.Size = new System.Drawing.Size(169, 21);
            this.cmbAccommodationType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Accommodation Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
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
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Date";
            // 
            // dataGridViewSearchResults
            // 
            this.dataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResults.Location = new System.Drawing.Point(34, 188);
            this.dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            this.dataGridViewSearchResults.ReadOnly = true;
            this.dataGridViewSearchResults.Size = new System.Drawing.Size(703, 243);
            this.dataGridViewSearchResults.TabIndex = 12;
            this.dataGridViewSearchResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchResults_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(31, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
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
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::TripSystemApp.Properties.Resources.road_trip_activity_background_free_vector;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.btnChoose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnChoose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnChoose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChoose.Location = new System.Drawing.Point(524, 124);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(174, 28);
            this.btnChoose.TabIndex = 15;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::TripSystemApp.Properties.Resources.road_trip_activity_background_free_vector;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tabPage2.Text = "Accommodation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChooseAccomm
            // 
            this.btnChooseAccomm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnChooseAccomm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnChooseAccomm.Location = new System.Drawing.Point(522, 112);
            this.btnChooseAccomm.Name = "btnChooseAccomm";
            this.btnChooseAccomm.Size = new System.Drawing.Size(174, 28);
            this.btnChooseAccomm.TabIndex = 17;
            this.btnChooseAccomm.Text = "Choose";
            this.btnChooseAccomm.UseVisualStyleBackColor = false;
            this.btnChooseAccomm.Click += new System.EventHandler(this.btnChooseAccomm_Click);
            // 
            // btnSearchAccomm
            // 
            this.btnSearchAccomm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchAccomm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchAccomm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchAccomm.Location = new System.Drawing.Point(522, 46);
            this.btnSearchAccomm.Name = "btnSearchAccomm";
            this.btnSearchAccomm.Size = new System.Drawing.Size(174, 28);
            this.btnSearchAccomm.TabIndex = 16;
            this.btnSearchAccomm.Text = "Search";
            this.btnSearchAccomm.UseVisualStyleBackColor = false;
            this.btnSearchAccomm.Click += new System.EventHandler(this.btnSearchReturn_Click);
            // 
            // dataGridViewAccommodations
            // 
            this.dataGridViewAccommodations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccommodations.Location = new System.Drawing.Point(30, 182);
            this.dataGridViewAccommodations.Name = "dataGridViewAccommodations";
            this.dataGridViewAccommodations.ReadOnly = true;
            this.dataGridViewAccommodations.Size = new System.Drawing.Size(709, 243);
            this.dataGridViewAccommodations.TabIndex = 13;
            this.dataGridViewAccommodations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccommodations_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::TripSystemApp.Properties.Resources.road_trip_activity_background_free_vector;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.cmbTransportTypeReturn);
            this.tabPage3.Controls.Add(this.btnFinish);
            this.tabPage3.Controls.Add(this.btnSearchReturn);
            this.tabPage3.Controls.Add(this.dataGridViewReturn);
            this.tabPage3.Controls.Add(this.dtpReturnDate);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "EndTrip";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(53, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Transport Type";
            // 
            // cmbTransportTypeReturn
            // 
            this.cmbTransportTypeReturn.FormattingEnabled = true;
            this.cmbTransportTypeReturn.Items.AddRange(new object[] {
            "Flight",
            "Train",
            "Bus",
            "Ferry",
            "Car Rental"});
            this.cmbTransportTypeReturn.Location = new System.Drawing.Point(182, 42);
            this.cmbTransportTypeReturn.Name = "cmbTransportTypeReturn";
            this.cmbTransportTypeReturn.Size = new System.Drawing.Size(200, 21);
            this.cmbTransportTypeReturn.TabIndex = 23;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFinish.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFinish.Location = new System.Drawing.Point(535, 100);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(174, 28);
            this.btnFinish.TabIndex = 22;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnSearchReturn
            // 
            this.btnSearchReturn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSearchReturn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchReturn.Location = new System.Drawing.Point(535, 34);
            this.btnSearchReturn.Name = "btnSearchReturn";
            this.btnSearchReturn.Size = new System.Drawing.Size(174, 28);
            this.btnSearchReturn.TabIndex = 21;
            this.btnSearchReturn.Text = "Search";
            this.btnSearchReturn.UseVisualStyleBackColor = false;
            this.btnSearchReturn.Click += new System.EventHandler(this.btnSearchReturn_Click_1);
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Location = new System.Drawing.Point(34, 191);
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.Size = new System.Drawing.Size(693, 243);
            this.dataGridViewReturn.TabIndex = 20;
            this.dataGridViewReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturn_CellContentClick);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(182, 84);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReturnDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(53, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Return Date";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::TripSystemApp.Properties.Resources.sunset_or_sunrise_on_the_beach_landscape_with_beautiful_pink_sky_and_sun_reflection_over_the_water_summer_vacation_background_cartoon_concept_vector;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.lblTotalCost);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.btnBookTrip);
            this.tabPage4.Controls.Add(this.lblTransportTypeReturn);
            this.tabPage4.Controls.Add(this.lblReturnDate);
            this.tabPage4.Controls.Add(this.lblAccommodation);
            this.tabPage4.Controls.Add(this.lblStartDate);
            this.tabPage4.Controls.Add(this.lblDeparture);
            this.tabPage4.Controls.Add(this.lblDestination);
            this.tabPage4.Controls.Add(this.lblTransportTypeDeparture);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 464);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "BookTrip";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnBookTrip
            // 
            this.btnBookTrip.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBookTrip.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBookTrip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBookTrip.Location = new System.Drawing.Point(287, 393);
            this.btnBookTrip.Name = "btnBookTrip";
            this.btnBookTrip.Size = new System.Drawing.Size(137, 49);
            this.btnBookTrip.TabIndex = 34;
            this.btnBookTrip.Text = "Book Trip";
            this.btnBookTrip.UseVisualStyleBackColor = false;
            this.btnBookTrip.Click += new System.EventHandler(this.btnBookTrip_Click);
            // 
            // lblTransportTypeReturn
            // 
            this.lblTransportTypeReturn.AutoSize = true;
            this.lblTransportTypeReturn.BackColor = System.Drawing.Color.Indigo;
            this.lblTransportTypeReturn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportTypeReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTransportTypeReturn.Location = new System.Drawing.Point(409, 235);
            this.lblTransportTypeReturn.Name = "lblTransportTypeReturn";
            this.lblTransportTypeReturn.Size = new System.Drawing.Size(100, 16);
            this.lblTransportTypeReturn.TabIndex = 33;
            this.lblTransportTypeReturn.Text = "Transport Type";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.BackColor = System.Drawing.Color.Indigo;
            this.lblReturnDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReturnDate.Location = new System.Drawing.Point(409, 271);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(82, 16);
            this.lblReturnDate.TabIndex = 32;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lblAccommodation
            // 
            this.lblAccommodation.AutoSize = true;
            this.lblAccommodation.BackColor = System.Drawing.Color.Indigo;
            this.lblAccommodation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccommodation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAccommodation.Location = new System.Drawing.Point(409, 199);
            this.lblAccommodation.Name = "lblAccommodation";
            this.lblAccommodation.Size = new System.Drawing.Size(144, 16);
            this.lblAccommodation.TabIndex = 31;
            this.lblAccommodation.Text = "Accommodation Type";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Indigo;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStartDate.Location = new System.Drawing.Point(409, 163);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(70, 16);
            this.lblStartDate.TabIndex = 29;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.BackColor = System.Drawing.Color.Indigo;
            this.lblDeparture.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeparture.Location = new System.Drawing.Point(409, 91);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(78, 16);
            this.lblDeparture.TabIndex = 30;
            this.lblDeparture.Text = "Departure: ";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.BackColor = System.Drawing.Color.Indigo;
            this.lblDestination.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDestination.Location = new System.Drawing.Point(409, 55);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(86, 16);
            this.lblDestination.TabIndex = 27;
            this.lblDestination.Text = "Destination: ";
            // 
            // lblTransportTypeDeparture
            // 
            this.lblTransportTypeDeparture.AutoSize = true;
            this.lblTransportTypeDeparture.BackColor = System.Drawing.Color.Indigo;
            this.lblTransportTypeDeparture.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportTypeDeparture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTransportTypeDeparture.Location = new System.Drawing.Point(409, 127);
            this.lblTransportTypeDeparture.Name = "lblTransportTypeDeparture";
            this.lblTransportTypeDeparture.Size = new System.Drawing.Size(100, 16);
            this.lblTransportTypeDeparture.TabIndex = 28;
            this.lblTransportTypeDeparture.Text = "Transport Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Indigo;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(172, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Transport Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Indigo;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(172, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Return Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Indigo;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(172, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Accommodation Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Indigo;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(172, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Start Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Indigo;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(172, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Departure: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Indigo;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(172, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Destination: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Indigo;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(172, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Transport Type:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTotalCost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalCost.Location = new System.Drawing.Point(409, 307);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(82, 16);
            this.lblTotalCost.TabIndex = 36;
            this.lblTotalCost.Text = "Return Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(172, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "Total cost:";
            // 
            // TripPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTransportTypeReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTransportTypeReturn;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblAccommodation;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblTransportTypeDeparture;
        private System.Windows.Forms.Button btnBookTrip;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label15;
    }
}