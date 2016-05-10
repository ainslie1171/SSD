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

namespace MotorcycleTourManagment.Feedback
{
    public partial class frm_NewFeedback : Form
    {

        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataTable dataTable;
        private BindingSource bindingSource;
        private string currentCommand;
        private bool Tour = false;
        private int CustomerID;
        private int TourID;
        private DatabaseConnection dbConn;

        public frm_NewFeedback()
        {
            InitializeComponent();
        }

        private void frm_NewFeedback_Load(object sender, EventArgs e)
        {
            currentCommand = "SELECT * FROM tbl_Customer";
            UpdateGridContents();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //SQL Stuff

            int row = grd_Customer.SelectedCells[0].RowIndex;
            CustomerID = (int)grd_Customer.Rows[row].Cells[0].Value;

            currentCommand = "SELECT * FROM tbl_Tour";
            gbx_Tour.Show();
            Tour = true;
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
                if (Tour)
                {
                    grd_Tours.DataSource = dataTable;
                    grd_Tours.ReadOnly = true;
                }
                else
                {
                    grd_Customer.DataSource = dataTable;
                    grd_Customer.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("There has been an error connecting to the database:" + Environment.NewLine + ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private string getFilters()
        {
            string content = " WHERE ";

            //Customer
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

            //Tour
            if (!tbx_TourID.Text.Equals(""))
            {
                content += "(TourID LIKE '%" + tbx_TourID.Text + "%')";
            }

            if (!tbx_TourName.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(TourName LIKE '%" + tbx_TourName.Text + "%')";
            }

            if (!tbx_StartLocation.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(StartLocation LIKE '%" + tbx_StartLocation.Text + "%')";
            }

            if (!tbx_EndLocation.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(EndLocation LIKE '%" + tbx_EndLocation.Text + "%')";
            }

            if (!tbx_StartHotel.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(StartHotel LIKE '%" + tbx_StartHotel.Text + "%')";
            }

            if (!tbx_EndHotel.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(EndHotel LIKE '%" + tbx_EndHotel.Text + "%')";
            }

            if (!tbx_Route.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(Route LIKE '%" + tbx_Route.Text + "%')";
            }

            if (!tbx_RouteNotes.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(RouteNotes LIKE '%" + tbx_RouteNotes.Text + "%')";
            }

            if (!tbx_Leader.Text.Equals(""))
            {
                if (!content.Equals(" WHERE ")) content += "AND";
                content += "(TourLeader LIKE '%" + tbx_Leader.Text + "%')";
            }

            return content;
        }

        private void tbx_TourID_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_TourName_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_StartLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_EndLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_StartHotel_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_EndHotel_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_Route_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_RouteNotes_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
        }

        private void tbx_Leader_TextChanged(object sender, EventArgs e)
        {
            UpdateGridContents();
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

        private void btn_Next2_Click(object sender, EventArgs e)
        {
            int row = grd_Tours.SelectedCells[0].RowIndex;
            TourID = (int)grd_Tours.Rows[row].Cells[0].Value;
            gbx_Feedback.Show();
            gbx_Tour.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dbConn = new DatabaseConnection();
            dbConn.SendCommand("INSERT INTO tbl_Feedback (CustomerID, TourID, Feedback) VALUES ('" + CustomerID.ToString() + "', '" + TourID.ToString() + "', '" + tbx_Feedback.Text +"');");
            dbConn.Close();
            this.Close();
        }



    }
}
