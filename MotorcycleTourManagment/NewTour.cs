using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcycleTourManagment
{
    public partial class frm_NewTour : Form
    {

        private DatabaseConnection conn;

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

            string SQLCommand = "INSERT INTO Tour (TourName, StartLocation, EndLocation, StartHotel, EndHotel, Route, RouteNotes, TourLeader) Values ('" + TourName + "','" + StartLocation + "','" + EndLocation + "','" + StartHotel + "','" + EndHotel + "','" + Route + "','" + RouteNotes + "','" + TourLeader + "')";

            if(conn.SendCommand(SQLCommand))
            {
                //success
            }
            else
            {
                //failure
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NewTour_FormClosing(Object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void frm_NewTour_Load(object sender, EventArgs e)
        {
            conn = new DatabaseConnection();
        }
    }
}
