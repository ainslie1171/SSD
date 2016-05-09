using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MotorcycleTourManagment
{
    public partial class frm_Customer : Form
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataTable dataTable;
        private BindingSource bindingSource;
        private string currentCommand;

        public frm_Customer()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_NewCustomer form = new frm_NewCustomer();
            form.ShowDialog();
            UpdateGridContents();
        }

        private void btn_EditTour_Click(object sender, EventArgs e)
        {
            try
            {
                if (grd_Customer.ReadOnly)
                {
                    btn_Edit.Text = "Save Changes";
                }
                else
                {
                    btn_Edit.Text = "Edit";
                    grd_Customer.EndEdit();
                    dataAdapter.Update(dataTable);
                    UpdateGridContents();
                }
                grd_Customer.ReadOnly = !grd_Customer.ReadOnly;
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("There has been an error connecting to the database:" + Environment.NewLine + ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            List<int> rows = new List<int>();
            foreach (DataGridViewCell c in grd_Customer.SelectedCells)
            {
                if (!rows.Contains(c.RowIndex))
                    rows.Add(c.RowIndex);
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Are you sure you want to delete the following records?");
            sb.Append(Environment.NewLine);
            List<int> IDs = new List<int>();
            foreach (DataGridViewRow row in grd_Customer.Rows)
            {
                if (rows.Contains(row.Index))
                {
                    sb.Append("CustomerID: ");
                    sb.Append(row.Cells[0].Value.ToString());
                    sb.Append(Environment.NewLine);
                    IDs.Add((int)row.Cells[0].Value);
                }
            }


            DialogResult dialogResult = MessageBox.Show(sb.ToString(), "Deletion warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                DatabaseConnection conn = new DatabaseConnection();
                conn.Open();
                foreach (int i in IDs)
                {
                    conn.SendCommand("DELETE FROM tbl_Customer WHERE CustomerID='" + i.ToString() + "'");
                }
                conn.Close();
            }
            else if (dialogResult.Equals(DialogResult.No))
            {
                MessageBox.Show("Deletion canceled");
            }

            UpdateGridContents();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            currentCommand = "SELECT * FROM tbl_Customer";
            UpdateGridContents();
        }

        private void UpdateGridContents()
        {

            string condition = getFilters();
            if (!condition.Equals(" WHERE "))
            {
                condition = currentCommand + condition;
            }
            else
            {
                condition = currentCommand;
            }

            try
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.ssdConnectionString);
                dataAdapter = new SqlDataAdapter(condition, conn);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                bindingSource = new BindingSource { DataSource = dataTable };
                grd_Customer.DataSource = dataTable;
                grd_Customer.ReadOnly = true;
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("There has been an error connecting to the database:" + Environment.NewLine + ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private string getFilters()
        {
            string content = " WHERE ";

            if (!tbx_CustomerID.Text.Equals(""))
            {
                content += "(CustomerID LIKE '%" + tbx_CustomerID.Text + "%')";
            }

            if (!tbx_FirstName.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(FirstName LIKE '%" + tbx_FirstName.Text + "%')";
            }

            if (!tbx_LastName.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(LastName LIKE '%" + tbx_LastName.Text + "%')";
            }

            if (!tbx_Address.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(Address LIKE '%" + tbx_Address.Text + "%')";
            }

            if (!tbx_Age.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(Age LIKE '%" + tbx_Age.Text + "%')";
            }

            if (!tbx_Email.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(Email LIKE '%" + tbx_Email.Text + "%')";
            }

            if (!tbx_Phone.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(Phone LIKE '%" + tbx_Phone.Text + "%')";
            }

            if (!tbx_BikeRegNumber.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(BikeRegNumber LIKE '%" + tbx_BikeRegNumber.Text + "%')";
            }

            return content;
        }

        private void tbx_CustomerID_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_FirstName_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_LastName_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_Address_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_Age_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_Email_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_Phone_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_BikeRegNumber_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }
    }
}
