namespace MotorcycleTourManagment
{
    partial class frm_ViewTours
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
            this.components = new System.ComponentModel.Container();
            this.grd_Tours = new System.Windows.Forms.DataGridView();
            this.tourDataSet = new MotorcycleTourManagment.TourDataSet();
            this.tourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourTableAdapter = new MotorcycleTourManagment.TourDataSetTableAdapters.TourTableAdapter();
            this.btn_EditTour = new System.Windows.Forms.Button();
            this.tbx_TourID = new System.Windows.Forms.TextBox();
            this.tbx_TourName = new System.Windows.Forms.TextBox();
            this.tbx_StartLocation = new System.Windows.Forms.TextBox();
            this.tbx_EndLocation = new System.Windows.Forms.TextBox();
            this.tbx_StartHotel = new System.Windows.Forms.TextBox();
            this.tbx_EndHotel = new System.Windows.Forms.TextBox();
            this.tbx_Route = new System.Windows.Forms.TextBox();
            this.tbx_RouteNotes = new System.Windows.Forms.TextBox();
            this.tbx_Leader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Test = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Tours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Tours
            // 
            this.grd_Tours.AllowUserToAddRows = false;
            this.grd_Tours.AllowUserToDeleteRows = false;
            this.grd_Tours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Tours.Location = new System.Drawing.Point(11, 27);
            this.grd_Tours.Name = "grd_Tours";
            this.grd_Tours.Size = new System.Drawing.Size(944, 245);
            this.grd_Tours.TabIndex = 0;
            this.grd_Tours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tourDataSet
            // 
            this.tourDataSet.DataSetName = "TourDataSet";
            this.tourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourBindingSource
            // 
            this.tourBindingSource.DataMember = "Tour";
            this.tourBindingSource.DataSource = this.tourDataSet;
            // 
            // tourTableAdapter
            // 
            this.tourTableAdapter.ClearBeforeFill = true;
            // 
            // btn_EditTour
            // 
            this.btn_EditTour.Location = new System.Drawing.Point(441, 366);
            this.btn_EditTour.Name = "btn_EditTour";
            this.btn_EditTour.Size = new System.Drawing.Size(85, 33);
            this.btn_EditTour.TabIndex = 0;
            this.btn_EditTour.Text = "Edit Tour";
            this.btn_EditTour.UseVisualStyleBackColor = true;
            this.btn_EditTour.Click += new System.EventHandler(this.btn_EditTour_Click);
            // 
            // tbx_TourID
            // 
            this.tbx_TourID.Location = new System.Drawing.Point(69, 4);
            this.tbx_TourID.Name = "tbx_TourID";
            this.tbx_TourID.Size = new System.Drawing.Size(81, 20);
            this.tbx_TourID.TabIndex = 1;
            this.tbx_TourID.TextChanged += new System.EventHandler(this.tbx_TourID_TextChanged);
            // 
            // tbx_TourName
            // 
            this.tbx_TourName.Location = new System.Drawing.Point(170, 4);
            this.tbx_TourName.Name = "tbx_TourName";
            this.tbx_TourName.Size = new System.Drawing.Size(81, 20);
            this.tbx_TourName.TabIndex = 2;
            this.tbx_TourName.TextChanged += new System.EventHandler(this.tbx_TourName_TextChanged);
            // 
            // tbx_StartLocation
            // 
            this.tbx_StartLocation.Location = new System.Drawing.Point(266, 4);
            this.tbx_StartLocation.Name = "tbx_StartLocation";
            this.tbx_StartLocation.Size = new System.Drawing.Size(81, 20);
            this.tbx_StartLocation.TabIndex = 3;
            this.tbx_StartLocation.TextChanged += new System.EventHandler(this.tbx_StartLocation_TextChanged);
            // 
            // tbx_EndLocation
            // 
            this.tbx_EndLocation.Location = new System.Drawing.Point(368, 4);
            this.tbx_EndLocation.Name = "tbx_EndLocation";
            this.tbx_EndLocation.Size = new System.Drawing.Size(81, 20);
            this.tbx_EndLocation.TabIndex = 4;
            this.tbx_EndLocation.TextChanged += new System.EventHandler(this.tbx_EndLocation_TextChanged);
            // 
            // tbx_StartHotel
            // 
            this.tbx_StartHotel.Location = new System.Drawing.Point(467, 4);
            this.tbx_StartHotel.Name = "tbx_StartHotel";
            this.tbx_StartHotel.Size = new System.Drawing.Size(81, 20);
            this.tbx_StartHotel.TabIndex = 5;
            this.tbx_StartHotel.TextChanged += new System.EventHandler(this.tbx_StartHotel_TextChanged);
            // 
            // tbx_EndHotel
            // 
            this.tbx_EndHotel.Location = new System.Drawing.Point(567, 4);
            this.tbx_EndHotel.Name = "tbx_EndHotel";
            this.tbx_EndHotel.Size = new System.Drawing.Size(81, 20);
            this.tbx_EndHotel.TabIndex = 6;
            this.tbx_EndHotel.TextChanged += new System.EventHandler(this.tbx_EndHotel_TextChanged);
            // 
            // tbx_Route
            // 
            this.tbx_Route.Location = new System.Drawing.Point(664, 4);
            this.tbx_Route.Name = "tbx_Route";
            this.tbx_Route.Size = new System.Drawing.Size(81, 20);
            this.tbx_Route.TabIndex = 7;
            this.tbx_Route.TextChanged += new System.EventHandler(this.tbx_Route_TextChanged);
            // 
            // tbx_RouteNotes
            // 
            this.tbx_RouteNotes.Location = new System.Drawing.Point(766, 4);
            this.tbx_RouteNotes.Name = "tbx_RouteNotes";
            this.tbx_RouteNotes.Size = new System.Drawing.Size(81, 20);
            this.tbx_RouteNotes.TabIndex = 8;
            this.tbx_RouteNotes.TextChanged += new System.EventHandler(this.tbx_RouteNotes_TextChanged);
            // 
            // tbx_Leader
            // 
            this.tbx_Leader.Location = new System.Drawing.Point(865, 4);
            this.tbx_Leader.Name = "tbx_Leader";
            this.tbx_Leader.Size = new System.Drawing.Size(81, 20);
            this.tbx_Leader.TabIndex = 9;
            this.tbx_Leader.TextChanged += new System.EventHandler(this.tbx_Leader_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(880, 465);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 0;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Visible = false;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add New Tour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(746, 366);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(85, 33);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete Tour";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_ViewTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 500);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Leader);
            this.Controls.Add(this.tbx_RouteNotes);
            this.Controls.Add(this.tbx_Route);
            this.Controls.Add(this.tbx_EndLocation);
            this.Controls.Add(this.tbx_EndHotel);
            this.Controls.Add(this.tbx_StartLocation);
            this.Controls.Add(this.tbx_StartHotel);
            this.Controls.Add(this.tbx_TourName);
            this.Controls.Add(this.tbx_TourID);
            this.Controls.Add(this.btn_EditTour);
            this.Controls.Add(this.grd_Tours);
            this.Name = "frm_ViewTours";
            this.Text = "ViewTours";
            this.Load += new System.EventHandler(this.ViewTours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Tours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Tours;
        private TourDataSet tourDataSet;
        private System.Windows.Forms.BindingSource tourBindingSource;
        private TourDataSetTableAdapters.TourTableAdapter tourTableAdapter;
        private System.Windows.Forms.Button btn_EditTour;
        private System.Windows.Forms.TextBox tbx_TourID;
        private System.Windows.Forms.TextBox tbx_TourName;
        private System.Windows.Forms.TextBox tbx_StartLocation;
        private System.Windows.Forms.TextBox tbx_EndLocation;
        private System.Windows.Forms.TextBox tbx_StartHotel;
        private System.Windows.Forms.TextBox tbx_EndHotel;
        private System.Windows.Forms.TextBox tbx_Route;
        private System.Windows.Forms.TextBox tbx_RouteNotes;
        private System.Windows.Forms.TextBox tbx_Leader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Delete;
    }
}