using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MotorcycleTourManagment
{
    public partial class frm_NewTour : Form
    {

        private string connectionString = "SERVER=localhost; DATABASE=ssd; Uid=root; Pwd=password;";
        private MySqlConnection conn;

        private bool OpenConnection(ref MySqlException exOut)
        {
            try
            {
                conn.Open();
                return true;
            }
             catch (MySqlException ex)
             {
                 exOut = ex;
                 return false;
             }
        }

        private void CloseConnection()
        {
            conn.Close();
        }

        public frm_NewTour()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string TourName = tbx_TourName.Text;
            string StartLocation = tbx_StartLocation.Text;
            string EndLocation = tbx_EndLocation.Text;
            string StartHotel = tbx_StartHotel.Text;
            string EndHotel = tbx_EndHotel.Text;
            string Route = tbx_Route.Text;
            string RouteNotes = tbx_RouteNotes.Text;
            string TourLeader = tbx_TourLeader.Text;
            MySqlException ex = null;
            bool Result = OpenConnection(ref ex);
            while (!Result)
            {
                DialogResult dialogResult = MessageBox.Show("There has been an error connecting to the database:" + Environment.NewLine + ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dialogResult.Equals(DialogResult.Retry))
                {
                    Result = OpenConnection(ref ex);
                }
                if (dialogResult.Equals(DialogResult.Cancel))
                {
                    CloseConnection();
                    return;
                }
            }

            MessageBox.Show("Connection Successful");

            Result = false; 
            while (!Result)
            {
                try
                {
                    Result = true;
                    MySqlCommand mySqlCom = new MySqlCommand("INSERT INTO Tour (TourName, StartLocation, EndLocation, StartHotel, EndHotel, Route, RouteNotes, TourLeader) Values ('" + TourName + "','" + StartLocation + "','" + EndLocation + "','" + StartHotel + "','" + EndHotel + "','" + Route + "','" + RouteNotes + "','" + TourLeader + "')", conn);
                    mySqlCom.ExecuteNonQuery();
                    MessageBox.Show("Update succesful!");
                }
                catch (Exception w)
                {
                    DialogResult dialogResult = MessageBox.Show("There has been an error within the database." + Environment.NewLine + w.Message, "Data Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult.Equals(DialogResult.Retry))
                    {
                        Result = false;
                    }
                    if (dialogResult.Equals(DialogResult.Cancel))
                    {
                        CloseConnection();
                        return;
                    }
                }
            }
            CloseConnection();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NewTour_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (!conn.State.Equals(ConnectionState.Closed))
            {
                CloseConnection();
            }
        }

        private void frm_NewTour_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
        }
    }
}
