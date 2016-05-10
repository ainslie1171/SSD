namespace MotorcycleTourManagment.Feedback
{
    partial class frm_Feedback
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
            this.grd_Feedback = new System.Windows.Forms.DataGridView();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Feedback)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Feedback
            // 
            this.grd_Feedback.AllowUserToAddRows = false;
            this.grd_Feedback.AllowUserToDeleteRows = false;
            this.grd_Feedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Feedback.Location = new System.Drawing.Point(28, 59);
            this.grd_Feedback.Name = "grd_Feedback";
            this.grd_Feedback.ReadOnly = true;
            this.grd_Feedback.Size = new System.Drawing.Size(384, 150);
            this.grd_Feedback.TabIndex = 0;
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(63, 265);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(88, 38);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "Add New Feedback";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(253, 265);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(88, 38);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete Feedback(s)";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 355);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.grd_Feedback);
            this.Name = "frm_Feedback";
            this.Text = "frm_Feedback";
            this.Load += new System.EventHandler(this.frm_Feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Feedback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Feedback;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Delete;
    }
}