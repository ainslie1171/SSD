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
    public partial class frm_ViewTours : Form
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataTable dataTable;
        private BindingSource bindingSource;
        private string currentCommand;

        public frm_ViewTours()
        {
            InitializeComponent();
        }

        private void ViewTours_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourDataSet.Tour' table. You can move, or remove it, as needed.        
            //this.tourTableAdapter.Fill(this.tourDataSet.Tour);
            currentCommand = "SELECT * FROM tbl_Tour";
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
                grd_Tours.DataSource = dataTable;
                grd_Tours.ReadOnly = true;
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("There has been an error connecting to the database:" + Environment.NewLine + ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_EditTour_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (grd_Tours.ReadOnly)
                {
                    btn_EditTour.Text = "Save Changes";
                }
                else
                {
                    btn_EditTour.Text = "Edit";
                    grd_Tours.EndEdit();
                    dataAdapter.Update(dataTable);
                    UpdateGridContents();
                }
                grd_Tours.ReadOnly = !grd_Tours.ReadOnly;
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("There has been an error connecting to the database:" + Environment.NewLine + ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private string getFilters()
        {
            string content = " WHERE ";

            if(!tbx_TourID.Text.Equals(""))
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

        private void btn_Test_Click(object sender, EventArgs e)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            frm_NewTour form = new frm_NewTour();
            form.ShowDialog();
            UpdateGridContents();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            List<int> rows = new List<int>();
            foreach (DataGridViewCell c in grd_Tours.SelectedCells)
            {
                if (!rows.Contains(c.RowIndex))
                    rows.Add(c.RowIndex);
            }
            List<int> IDs = new List<int>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Are you sure you want to delete the following records?");
            sb.Append(Environment.NewLine);
            foreach (DataGridViewRow row in grd_Tours.Rows)
            {
                if (rows.Contains(row.Index))
                {
                    sb.Append("TourID: ");
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
                foreach(int i in IDs)
                {
                    conn.SendCommand("DELETE FROM tbl_Tour WHERE TourID='"+i.ToString()+"'");
                }
                conn.Close();
            }
            else if(dialogResult.Equals(DialogResult.No))
            {
                MessageBox.Show("Deletion canceled");
            }

            UpdateGridContents();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
