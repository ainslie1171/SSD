﻿namespace MotorcycleTourManagment
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MTour = new System.Windows.Forms.Button();
            this.btn_MCustomer = new System.Windows.Forms.Button();
            this.btn_Booking = new System.Windows.Forms.Button();
            this.btn_NCustomer = new System.Windows.Forms.Button();
            this.btn_NTour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Motorcycle Tour Managment System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_MTour
            // 
            this.btn_MTour.Location = new System.Drawing.Point(510, 90);
            this.btn_MTour.Name = "btn_MTour";
            this.btn_MTour.Size = new System.Drawing.Size(89, 64);
            this.btn_MTour.TabIndex = 2;
            this.btn_MTour.Text = "Modify tour information";
            this.btn_MTour.UseVisualStyleBackColor = true;
            // 
            // btn_MCustomer
            // 
            this.btn_MCustomer.Location = new System.Drawing.Point(415, 90);
            this.btn_MCustomer.Name = "btn_MCustomer";
            this.btn_MCustomer.Size = new System.Drawing.Size(89, 64);
            this.btn_MCustomer.TabIndex = 3;
            this.btn_MCustomer.Text = "Modify customer information";
            this.btn_MCustomer.UseVisualStyleBackColor = true;
            // 
            // btn_Booking
            // 
            this.btn_Booking.Location = new System.Drawing.Point(320, 90);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Size = new System.Drawing.Size(89, 64);
            this.btn_Booking.TabIndex = 4;
            this.btn_Booking.Text = "Add a \r\nnew booking";
            this.btn_Booking.UseVisualStyleBackColor = true;
            // 
            // btn_NCustomer
            // 
            this.btn_NCustomer.Location = new System.Drawing.Point(225, 90);
            this.btn_NCustomer.Name = "btn_NCustomer";
            this.btn_NCustomer.Size = new System.Drawing.Size(89, 64);
            this.btn_NCustomer.TabIndex = 5;
            this.btn_NCustomer.Text = "Add a \r\nnew customer";
            this.btn_NCustomer.UseVisualStyleBackColor = true;
            // 
            // btn_NTour
            // 
            this.btn_NTour.Location = new System.Drawing.Point(130, 90);
            this.btn_NTour.Name = "btn_NTour";
            this.btn_NTour.Size = new System.Drawing.Size(89, 64);
            this.btn_NTour.TabIndex = 8;
            this.btn_NTour.Text = "Add a \r\nnew tour";
            this.btn_NTour.UseVisualStyleBackColor = true;
            this.btn_NTour.Click += new System.EventHandler(this.btn_NTour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 314);
            this.Controls.Add(this.btn_MTour);
            this.Controls.Add(this.btn_MCustomer);
            this.Controls.Add(this.btn_Booking);
            this.Controls.Add(this.btn_NCustomer);
            this.Controls.Add(this.btn_NTour);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Motorcycle Tour Managment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MTour;
        private System.Windows.Forms.Button btn_MCustomer;
        private System.Windows.Forms.Button btn_Booking;
        private System.Windows.Forms.Button btn_NCustomer;
        private System.Windows.Forms.Button btn_NTour;
    }
}

