namespace MotorcycleTourManagment.Booking
{
    partial class frm_NewBooking
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
            this.gbx_Customer = new System.Windows.Forms.GroupBox();
            this.gbx_Tour = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Leader = new System.Windows.Forms.TextBox();
            this.tbx_RouteNotes = new System.Windows.Forms.TextBox();
            this.tbx_Route = new System.Windows.Forms.TextBox();
            this.tbx_EndLocation = new System.Windows.Forms.TextBox();
            this.tbx_EndHotel = new System.Windows.Forms.TextBox();
            this.tbx_StartLocation = new System.Windows.Forms.TextBox();
            this.tbx_StartHotel = new System.Windows.Forms.TextBox();
            this.tbx_TourName = new System.Windows.Forms.TextBox();
            this.tbx_TourID = new System.Windows.Forms.TextBox();
            this.grd_Tours = new System.Windows.Forms.DataGridView();
            this.btn_Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_BikeRegNumber = new System.Windows.Forms.TextBox();
            this.tbx_Phone = new System.Windows.Forms.TextBox();
            this.tbx_Address = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.tbx_LastName = new System.Windows.Forms.TextBox();
            this.tbx_Age = new System.Windows.Forms.TextBox();
            this.tbx_FirstName = new System.Windows.Forms.TextBox();
            this.tbx_CustomerID = new System.Windows.Forms.TextBox();
            this.grd_Customer = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gbx_Customer.SuspendLayout();
            this.gbx_Tour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Tours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Customer
            // 
            this.gbx_Customer.Controls.Add(this.gbx_Tour);
            this.gbx_Customer.Controls.Add(this.btn_Next);
            this.gbx_Customer.Controls.Add(this.label1);
            this.gbx_Customer.Controls.Add(this.tbx_BikeRegNumber);
            this.gbx_Customer.Controls.Add(this.tbx_Phone);
            this.gbx_Customer.Controls.Add(this.tbx_Address);
            this.gbx_Customer.Controls.Add(this.tbx_Email);
            this.gbx_Customer.Controls.Add(this.tbx_LastName);
            this.gbx_Customer.Controls.Add(this.tbx_Age);
            this.gbx_Customer.Controls.Add(this.tbx_FirstName);
            this.gbx_Customer.Controls.Add(this.tbx_CustomerID);
            this.gbx_Customer.Controls.Add(this.grd_Customer);
            this.gbx_Customer.Location = new System.Drawing.Point(46, 37);
            this.gbx_Customer.Name = "gbx_Customer";
            this.gbx_Customer.Size = new System.Drawing.Size(955, 396);
            this.gbx_Customer.TabIndex = 33;
            this.gbx_Customer.TabStop = false;
            this.gbx_Customer.Text = "Select a Customer(s)";
            // 
            // gbx_Tour
            // 
            this.gbx_Tour.Controls.Add(this.btn_Add);
            this.gbx_Tour.Controls.Add(this.label2);
            this.gbx_Tour.Controls.Add(this.tbx_Leader);
            this.gbx_Tour.Controls.Add(this.tbx_RouteNotes);
            this.gbx_Tour.Controls.Add(this.tbx_Route);
            this.gbx_Tour.Controls.Add(this.tbx_EndLocation);
            this.gbx_Tour.Controls.Add(this.tbx_EndHotel);
            this.gbx_Tour.Controls.Add(this.tbx_StartLocation);
            this.gbx_Tour.Controls.Add(this.tbx_StartHotel);
            this.gbx_Tour.Controls.Add(this.tbx_TourName);
            this.gbx_Tour.Controls.Add(this.tbx_TourID);
            this.gbx_Tour.Controls.Add(this.grd_Tours);
            this.gbx_Tour.Location = new System.Drawing.Point(0, 0);
            this.gbx_Tour.Name = "gbx_Tour";
            this.gbx_Tour.Size = new System.Drawing.Size(955, 396);
            this.gbx_Tour.TabIndex = 34;
            this.gbx_Tour.TabStop = false;
            this.gbx_Tour.Text = "Select a Tour";
            this.gbx_Tour.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filter:";
            // 
            // tbx_Leader
            // 
            this.tbx_Leader.Location = new System.Drawing.Point(859, 64);
            this.tbx_Leader.Name = "tbx_Leader";
            this.tbx_Leader.Size = new System.Drawing.Size(81, 20);
            this.tbx_Leader.TabIndex = 20;
            this.tbx_Leader.TextChanged += new System.EventHandler(this.tbx_Leader_TextChanged);
            // 
            // tbx_RouteNotes
            // 
            this.tbx_RouteNotes.Location = new System.Drawing.Point(760, 64);
            this.tbx_RouteNotes.Name = "tbx_RouteNotes";
            this.tbx_RouteNotes.Size = new System.Drawing.Size(81, 20);
            this.tbx_RouteNotes.TabIndex = 19;
            this.tbx_RouteNotes.TextChanged += new System.EventHandler(this.tbx_RouteNotes_TextChanged);
            // 
            // tbx_Route
            // 
            this.tbx_Route.Location = new System.Drawing.Point(658, 64);
            this.tbx_Route.Name = "tbx_Route";
            this.tbx_Route.Size = new System.Drawing.Size(81, 20);
            this.tbx_Route.TabIndex = 18;
            this.tbx_Route.TextChanged += new System.EventHandler(this.tbx_Route_TextChanged);
            // 
            // tbx_EndLocation
            // 
            this.tbx_EndLocation.Location = new System.Drawing.Point(362, 64);
            this.tbx_EndLocation.Name = "tbx_EndLocation";
            this.tbx_EndLocation.Size = new System.Drawing.Size(81, 20);
            this.tbx_EndLocation.TabIndex = 15;
            this.tbx_EndLocation.TextChanged += new System.EventHandler(this.tbx_EndLocation_TextChanged);
            // 
            // tbx_EndHotel
            // 
            this.tbx_EndHotel.Location = new System.Drawing.Point(561, 64);
            this.tbx_EndHotel.Name = "tbx_EndHotel";
            this.tbx_EndHotel.Size = new System.Drawing.Size(81, 20);
            this.tbx_EndHotel.TabIndex = 17;
            this.tbx_EndHotel.TextChanged += new System.EventHandler(this.tbx_EndHotel_TextChanged);
            // 
            // tbx_StartLocation
            // 
            this.tbx_StartLocation.Location = new System.Drawing.Point(260, 64);
            this.tbx_StartLocation.Name = "tbx_StartLocation";
            this.tbx_StartLocation.Size = new System.Drawing.Size(81, 20);
            this.tbx_StartLocation.TabIndex = 14;
            this.tbx_StartLocation.TextChanged += new System.EventHandler(this.tbx_StartLocation_TextChanged);
            // 
            // tbx_StartHotel
            // 
            this.tbx_StartHotel.Location = new System.Drawing.Point(461, 64);
            this.tbx_StartHotel.Name = "tbx_StartHotel";
            this.tbx_StartHotel.Size = new System.Drawing.Size(81, 20);
            this.tbx_StartHotel.TabIndex = 16;
            this.tbx_StartHotel.TextChanged += new System.EventHandler(this.tbx_StartHotel_TextChanged);
            // 
            // tbx_TourName
            // 
            this.tbx_TourName.Location = new System.Drawing.Point(164, 64);
            this.tbx_TourName.Name = "tbx_TourName";
            this.tbx_TourName.Size = new System.Drawing.Size(81, 20);
            this.tbx_TourName.TabIndex = 12;
            this.tbx_TourName.TextChanged += new System.EventHandler(this.tbx_TourName_TextChanged);
            // 
            // tbx_TourID
            // 
            this.tbx_TourID.Location = new System.Drawing.Point(63, 64);
            this.tbx_TourID.Name = "tbx_TourID";
            this.tbx_TourID.Size = new System.Drawing.Size(81, 20);
            this.tbx_TourID.TabIndex = 11;
            this.tbx_TourID.TextChanged += new System.EventHandler(this.tbx_TourID_TextChanged);
            // 
            // grd_Tours
            // 
            this.grd_Tours.AllowUserToAddRows = false;
            this.grd_Tours.AllowUserToDeleteRows = false;
            this.grd_Tours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Tours.Location = new System.Drawing.Point(5, 87);
            this.grd_Tours.Name = "grd_Tours";
            this.grd_Tours.Size = new System.Drawing.Size(944, 245);
            this.grd_Tours.TabIndex = 10;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(815, 347);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 43;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Filter:";
            // 
            // tbx_BikeRegNumber
            // 
            this.tbx_BikeRegNumber.Location = new System.Drawing.Point(809, 58);
            this.tbx_BikeRegNumber.Name = "tbx_BikeRegNumber";
            this.tbx_BikeRegNumber.Size = new System.Drawing.Size(81, 20);
            this.tbx_BikeRegNumber.TabIndex = 42;
            this.tbx_BikeRegNumber.TextChanged += new System.EventHandler(this.tbx_BikeRegNumber_TextChanged);
            // 
            // tbx_Phone
            // 
            this.tbx_Phone.Location = new System.Drawing.Point(707, 58);
            this.tbx_Phone.Name = "tbx_Phone";
            this.tbx_Phone.Size = new System.Drawing.Size(81, 20);
            this.tbx_Phone.TabIndex = 41;
            this.tbx_Phone.TextChanged += new System.EventHandler(this.tbx_Phone_TextChanged);
            // 
            // tbx_Address
            // 
            this.tbx_Address.Location = new System.Drawing.Point(411, 58);
            this.tbx_Address.Name = "tbx_Address";
            this.tbx_Address.Size = new System.Drawing.Size(81, 20);
            this.tbx_Address.TabIndex = 38;
            this.tbx_Address.TextChanged += new System.EventHandler(this.tbx_Address_TextChanged);
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(610, 58);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(81, 20);
            this.tbx_Email.TabIndex = 40;
            this.tbx_Email.TextChanged += new System.EventHandler(this.tbx_Email_TextChanged);
            // 
            // tbx_LastName
            // 
            this.tbx_LastName.Location = new System.Drawing.Point(309, 58);
            this.tbx_LastName.Name = "tbx_LastName";
            this.tbx_LastName.Size = new System.Drawing.Size(81, 20);
            this.tbx_LastName.TabIndex = 37;
            this.tbx_LastName.TextChanged += new System.EventHandler(this.tbx_LastName_TextChanged);
            // 
            // tbx_Age
            // 
            this.tbx_Age.Location = new System.Drawing.Point(510, 58);
            this.tbx_Age.Name = "tbx_Age";
            this.tbx_Age.Size = new System.Drawing.Size(81, 20);
            this.tbx_Age.TabIndex = 39;
            this.tbx_Age.TextChanged += new System.EventHandler(this.tbx_Age_TextChanged);
            // 
            // tbx_FirstName
            // 
            this.tbx_FirstName.Location = new System.Drawing.Point(213, 58);
            this.tbx_FirstName.Name = "tbx_FirstName";
            this.tbx_FirstName.Size = new System.Drawing.Size(81, 20);
            this.tbx_FirstName.TabIndex = 35;
            this.tbx_FirstName.TextChanged += new System.EventHandler(this.tbx_FirstName_TextChanged);
            // 
            // tbx_CustomerID
            // 
            this.tbx_CustomerID.Location = new System.Drawing.Point(112, 58);
            this.tbx_CustomerID.Name = "tbx_CustomerID";
            this.tbx_CustomerID.Size = new System.Drawing.Size(81, 20);
            this.tbx_CustomerID.TabIndex = 34;
            this.tbx_CustomerID.TextChanged += new System.EventHandler(this.tbx_CustomerID_TextChanged);
            // 
            // grd_Customer
            // 
            this.grd_Customer.AllowUserToAddRows = false;
            this.grd_Customer.AllowUserToDeleteRows = false;
            this.grd_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Customer.Location = new System.Drawing.Point(54, 81);
            this.grd_Customer.Name = "grd_Customer";
            this.grd_Customer.Size = new System.Drawing.Size(844, 245);
            this.grd_Customer.TabIndex = 33;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(859, 356);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.Text = "Finish";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frm_NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 519);
            this.Controls.Add(this.gbx_Customer);
            this.Name = "frm_NewBooking";
            this.Text = "frm_NewBooking";
            this.Load += new System.EventHandler(this.frm_NewBooking_Load);
            this.gbx_Customer.ResumeLayout(false);
            this.gbx_Customer.PerformLayout();
            this.gbx_Tour.ResumeLayout(false);
            this.gbx_Tour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Tours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Customer;
        private System.Windows.Forms.GroupBox gbx_Tour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_BikeRegNumber;
        private System.Windows.Forms.TextBox tbx_Phone;
        private System.Windows.Forms.TextBox tbx_Address;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.TextBox tbx_LastName;
        private System.Windows.Forms.TextBox tbx_Age;
        private System.Windows.Forms.TextBox tbx_FirstName;
        private System.Windows.Forms.TextBox tbx_CustomerID;
        private System.Windows.Forms.DataGridView grd_Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Leader;
        private System.Windows.Forms.TextBox tbx_RouteNotes;
        private System.Windows.Forms.TextBox tbx_Route;
        private System.Windows.Forms.TextBox tbx_EndLocation;
        private System.Windows.Forms.TextBox tbx_EndHotel;
        private System.Windows.Forms.TextBox tbx_StartLocation;
        private System.Windows.Forms.TextBox tbx_StartHotel;
        private System.Windows.Forms.TextBox tbx_TourName;
        private System.Windows.Forms.TextBox tbx_TourID;
        private System.Windows.Forms.DataGridView grd_Tours;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Add;
    }
}