namespace MotorcycleTourManagment
{
    partial class frm_Customer
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_BikeRegNumber = new System.Windows.Forms.TextBox();
            this.tbx_Phone = new System.Windows.Forms.TextBox();
            this.tbx_Address = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.tbx_LastName = new System.Windows.Forms.TextBox();
            this.tbx_Age = new System.Windows.Forms.TextBox();
            this.tbx_FirstName = new System.Windows.Forms.TextBox();
            this.tbx_CustomerID = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.grd_Customer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(787, 465);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(93, 42);
            this.btn_Delete.TabIndex = 25;
            this.btn_Delete.Text = "Delete Customer";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(122, 465);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(93, 42);
            this.btn_Add.TabIndex = 24;
            this.btn_Add.Text = "Add New Customer";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filter:";
            // 
            // tbx_BikeRegNumber
            // 
            this.tbx_BikeRegNumber.Location = new System.Drawing.Point(831, 100);
            this.tbx_BikeRegNumber.Name = "tbx_BikeRegNumber";
            this.tbx_BikeRegNumber.Size = new System.Drawing.Size(81, 20);
            this.tbx_BikeRegNumber.TabIndex = 22;
            this.tbx_BikeRegNumber.TextChanged += new System.EventHandler(this.tbx_BikeRegNumber_TextChanged);
            // 
            // tbx_Phone
            // 
            this.tbx_Phone.Location = new System.Drawing.Point(729, 100);
            this.tbx_Phone.Name = "tbx_Phone";
            this.tbx_Phone.Size = new System.Drawing.Size(81, 20);
            this.tbx_Phone.TabIndex = 21;
            this.tbx_Phone.TextChanged += new System.EventHandler(this.tbx_Phone_TextChanged);
            // 
            // tbx_Address
            // 
            this.tbx_Address.Location = new System.Drawing.Point(433, 100);
            this.tbx_Address.Name = "tbx_Address";
            this.tbx_Address.Size = new System.Drawing.Size(81, 20);
            this.tbx_Address.TabIndex = 18;
            this.tbx_Address.TextChanged += new System.EventHandler(this.tbx_Address_TextChanged);
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(632, 100);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(81, 20);
            this.tbx_Email.TabIndex = 20;
            this.tbx_Email.TextChanged += new System.EventHandler(this.tbx_Email_TextChanged);
            // 
            // tbx_LastName
            // 
            this.tbx_LastName.Location = new System.Drawing.Point(331, 100);
            this.tbx_LastName.Name = "tbx_LastName";
            this.tbx_LastName.Size = new System.Drawing.Size(81, 20);
            this.tbx_LastName.TabIndex = 17;
            this.tbx_LastName.TextChanged += new System.EventHandler(this.tbx_LastName_TextChanged);
            // 
            // tbx_Age
            // 
            this.tbx_Age.Location = new System.Drawing.Point(532, 100);
            this.tbx_Age.Name = "tbx_Age";
            this.tbx_Age.Size = new System.Drawing.Size(81, 20);
            this.tbx_Age.TabIndex = 19;
            this.tbx_Age.TextChanged += new System.EventHandler(this.tbx_Age_TextChanged);
            // 
            // tbx_FirstName
            // 
            this.tbx_FirstName.Location = new System.Drawing.Point(235, 100);
            this.tbx_FirstName.Name = "tbx_FirstName";
            this.tbx_FirstName.Size = new System.Drawing.Size(81, 20);
            this.tbx_FirstName.TabIndex = 15;
            this.tbx_FirstName.TextChanged += new System.EventHandler(this.tbx_FirstName_TextChanged);
            // 
            // tbx_CustomerID
            // 
            this.tbx_CustomerID.Location = new System.Drawing.Point(134, 100);
            this.tbx_CustomerID.Name = "tbx_CustomerID";
            this.tbx_CustomerID.Size = new System.Drawing.Size(81, 20);
            this.tbx_CustomerID.TabIndex = 14;
            this.tbx_CustomerID.TextChanged += new System.EventHandler(this.tbx_CustomerID_TextChanged);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(468, 465);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(93, 42);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "Edit Customer";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_EditTour_Click);
            // 
            // grd_Customer
            // 
            this.grd_Customer.AllowUserToAddRows = false;
            this.grd_Customer.AllowUserToDeleteRows = false;
            this.grd_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Customer.Location = new System.Drawing.Point(76, 123);
            this.grd_Customer.Name = "grd_Customer";
            this.grd_Customer.Size = new System.Drawing.Size(844, 245);
            this.grd_Customer.TabIndex = 13;
            // 
            // frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 595);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_BikeRegNumber);
            this.Controls.Add(this.tbx_Phone);
            this.Controls.Add(this.tbx_Address);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.tbx_LastName);
            this.Controls.Add(this.tbx_Age);
            this.Controls.Add(this.tbx_FirstName);
            this.Controls.Add(this.tbx_CustomerID);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.grd_Customer);
            this.Name = "frm_Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_BikeRegNumber;
        private System.Windows.Forms.TextBox tbx_Phone;
        private System.Windows.Forms.TextBox tbx_Address;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.TextBox tbx_LastName;
        private System.Windows.Forms.TextBox tbx_Age;
        private System.Windows.Forms.TextBox tbx_FirstName;
        private System.Windows.Forms.TextBox tbx_CustomerID;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridView grd_Customer;
    }
}