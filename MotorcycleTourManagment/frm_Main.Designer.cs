namespace MotorcycleTourManagment
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
            this.btn_Tour = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Bookings = new System.Windows.Forms.Button();
            this.btn_Feedback = new System.Windows.Forms.Button();
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
            // btn_Tour
            // 
            this.btn_Tour.Location = new System.Drawing.Point(81, 84);
            this.btn_Tour.Name = "btn_Tour";
            this.btn_Tour.Size = new System.Drawing.Size(89, 64);
            this.btn_Tour.TabIndex = 2;
            this.btn_Tour.Text = "Tours";
            this.btn_Tour.UseVisualStyleBackColor = true;
            this.btn_Tour.Click += new System.EventHandler(this.btn_MTour_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(512, 155);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(97, 23);
            this.btn_Test.TabIndex = 9;
            this.btn_Test.Text = "Test Connection";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Visible = false;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Location = new System.Drawing.Point(247, 84);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(89, 64);
            this.btn_Customer.TabIndex = 2;
            this.btn_Customer.Text = "Customers";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Bookings
            // 
            this.btn_Bookings.Location = new System.Drawing.Point(418, 84);
            this.btn_Bookings.Name = "btn_Bookings";
            this.btn_Bookings.Size = new System.Drawing.Size(89, 64);
            this.btn_Bookings.TabIndex = 2;
            this.btn_Bookings.Text = "Bookings";
            this.btn_Bookings.UseVisualStyleBackColor = true;
            this.btn_Bookings.Click += new System.EventHandler(this.btn_Bookings_Click);
            // 
            // btn_Feedback
            // 
            this.btn_Feedback.Location = new System.Drawing.Point(580, 84);
            this.btn_Feedback.Name = "btn_Feedback";
            this.btn_Feedback.Size = new System.Drawing.Size(89, 64);
            this.btn_Feedback.TabIndex = 2;
            this.btn_Feedback.Text = "Feedback";
            this.btn_Feedback.UseVisualStyleBackColor = true;
            this.btn_Feedback.Click += new System.EventHandler(this.btn_Feedback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 190);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_Feedback);
            this.Controls.Add(this.btn_Bookings);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_Tour);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Motorcycle Tour Managment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Tour;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Bookings;
        private System.Windows.Forms.Button btn_Feedback;
    }
}

