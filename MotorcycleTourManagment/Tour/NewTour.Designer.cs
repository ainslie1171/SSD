namespace MotorcycleTourManagment
{
    partial class frm_NewTour
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tbx_TourName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_StartLocation = new System.Windows.Forms.TextBox();
            this.tbx_EndLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_StartHotel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_EndHotel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Route = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_RouteNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_TourLeader = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(12, 246);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(101, 40);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save Tour";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tbx_TourName
            // 
            this.tbx_TourName.Location = new System.Drawing.Point(144, 20);
            this.tbx_TourName.Name = "tbx_TourName";
            this.tbx_TourName.Size = new System.Drawing.Size(100, 20);
            this.tbx_TourName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tour Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Location";
            // 
            // tbx_StartLocation
            // 
            this.tbx_StartLocation.Location = new System.Drawing.Point(144, 46);
            this.tbx_StartLocation.Name = "tbx_StartLocation";
            this.tbx_StartLocation.Size = new System.Drawing.Size(100, 20);
            this.tbx_StartLocation.TabIndex = 1;
            // 
            // tbx_EndLocation
            // 
            this.tbx_EndLocation.Location = new System.Drawing.Point(144, 72);
            this.tbx_EndLocation.Name = "tbx_EndLocation";
            this.tbx_EndLocation.Size = new System.Drawing.Size(100, 20);
            this.tbx_EndLocation.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Location";
            // 
            // tbx_StartHotel
            // 
            this.tbx_StartHotel.Location = new System.Drawing.Point(144, 98);
            this.tbx_StartHotel.Name = "tbx_StartHotel";
            this.tbx_StartHotel.Size = new System.Drawing.Size(100, 20);
            this.tbx_StartHotel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Hotel";
            // 
            // tbx_EndHotel
            // 
            this.tbx_EndHotel.Location = new System.Drawing.Point(144, 124);
            this.tbx_EndHotel.Name = "tbx_EndHotel";
            this.tbx_EndHotel.Size = new System.Drawing.Size(100, 20);
            this.tbx_EndHotel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "End Hotel";
            // 
            // tbx_Route
            // 
            this.tbx_Route.Location = new System.Drawing.Point(144, 150);
            this.tbx_Route.Name = "tbx_Route";
            this.tbx_Route.Size = new System.Drawing.Size(100, 20);
            this.tbx_Route.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Route";
            // 
            // tbx_RouteNotes
            // 
            this.tbx_RouteNotes.Location = new System.Drawing.Point(144, 176);
            this.tbx_RouteNotes.Name = "tbx_RouteNotes";
            this.tbx_RouteNotes.Size = new System.Drawing.Size(100, 20);
            this.tbx_RouteNotes.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Route Notes";
            // 
            // tbx_TourLeader
            // 
            this.tbx_TourLeader.Location = new System.Drawing.Point(144, 202);
            this.tbx_TourLeader.Name = "tbx_TourLeader";
            this.tbx_TourLeader.Size = new System.Drawing.Size(100, 20);
            this.tbx_TourLeader.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tour Leader";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(171, 247);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(101, 38);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frm_NewTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_TourLeader);
            this.Controls.Add(this.tbx_RouteNotes);
            this.Controls.Add(this.tbx_Route);
            this.Controls.Add(this.tbx_EndHotel);
            this.Controls.Add(this.tbx_StartHotel);
            this.Controls.Add(this.tbx_EndLocation);
            this.Controls.Add(this.tbx_StartLocation);
            this.Controls.Add(this.tbx_TourName);
            this.Controls.Add(this.btn_Save);
            this.Name = "frm_NewTour";
            this.Text = "New Tour";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_NewTour_FormClosing);
            this.Load += new System.EventHandler(this.frm_NewTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tbx_TourName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_StartLocation;
        private System.Windows.Forms.TextBox tbx_EndLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_StartHotel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_EndHotel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Route;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_RouteNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_TourLeader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cancel;
    }
}