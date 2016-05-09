namespace MotorcycleTourManagment
{
    partial class frm_Booking
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
            this.grd_Booking = new System.Windows.Forms.DataGridView();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Booking)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Booking
            // 
            this.grd_Booking.AllowUserToAddRows = false;
            this.grd_Booking.AllowUserToDeleteRows = false;
            this.grd_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Booking.Location = new System.Drawing.Point(12, 12);
            this.grd_Booking.Name = "grd_Booking";
            this.grd_Booking.ReadOnly = true;
            this.grd_Booking.Size = new System.Drawing.Size(243, 237);
            this.grd_Booking.TabIndex = 0;
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(332, 26);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(102, 31);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "Add New Booking";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(332, 84);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(102, 31);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete Booking(s)";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 261);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.grd_Booking);
            this.Name = "frm_Booking";
            this.Text = "frm_Booking";
            this.Load += new System.EventHandler(this.frm_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Booking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Booking;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Delete;
    }
}