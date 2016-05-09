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
    public partial class frm_Booking : Form
    {

        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataTable dataTable;
        private BindingSource bindingSource;
        private string currentCommand;

        public frm_Booking()
        {
            InitializeComponent();
        }

        private void frm_Booking_Load(object sender, EventArgs e)
        {
            currentCommand = "SELECT tbl_Customer.FirstName + ' ' + tbl_Customer.LastName AS CustomerName, tbl_Tour.TourName FROM tbl_Booking INNER JOIN tbl_Customer ON tbl_Booking.CustomerID=tbl_Customer.CustomerID INNER JOIN tbl_Tour ON tbl_Booking.TourID=tbl_Tour.TourID;";
            UpdateGridContents();
        }

        private void UpdateGridContents()
        {
            string condition = currentCommand;
            //string condition = getFilters();
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
                grd_Booking.DataSource = dataTable;
                grd_Booking.ReadOnly = true;
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("There has been an error connecting to the database:" + Environment.NewLine + ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Booking.frm_NewBooking form = new Booking.frm_NewBooking();
            form.ShowDialog();
            UpdateGridContents();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            List<int> rows = new List<int>();
            foreach (DataGridViewCell c in grd_Booking.SelectedCells)
                if (!rows.Contains(c.RowIndex))
                    rows.Add(c.RowIndex);

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ssdConnectionString);
            dataAdapter = new SqlDataAdapter("SELECT * FROM tbl_Booking", conn);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            List<int> CustomerIDs = new List<int>();
            List<int> TourIDs = new List<int>();
            int index = 0;
            foreach ( DataRow row in dataTable.Rows)
            {
                if (rows.Contains(index))
                {
                    TourIDs.Add((int)row[0]);
                    CustomerIDs.Add((int)row[1]);
                }
                index++;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the record(s)?", "Deletion warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                DatabaseConnection dbconn = new DatabaseConnection();
                dbconn.Open();
                index = 0;
                foreach (int i in TourIDs)
                {
                    dbconn.SendCommand("DELETE FROM tbl_Booking WHERE TourID='" + i.ToString() + "' AND CustomerID='"+ CustomerIDs[index] + "';");
                    index++;
                }
                dbconn.Close();
            }
            else if (dialogResult.Equals(DialogResult.No))
            {
                MessageBox.Show("Deletion canceled");
            }

            UpdateGridContents();
        }
    }
}
