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
            Tour tour = new Tour();
            tour.TourName = tbx_TourName.Text;
            tour.StartLocation = tbx_StartLocation.Text;
            tour.EndLocation = tbx_EndLocation.Text;
            tour.StartHotel = tbx_StartHotel.Text;
            tour.EndHotel = tbx_EndHotel.Text;
            tour.Route = tbx_Route.Text;
            tour.RouteNotes = tbx_RouteNotes.Text;
            tour.TourLeader = tbx_TourLeader.Text;
            

            string SQLCommand = "INSERT INTO tbl_Tour (TourName, StartLocation, EndLocation, StartHotel, EndHotel, Route, RouteNotes, TourLeader) Values ('" + tour.GetInfo() + "')";

            if(conn.SendCommand(SQLCommand))
            {
                //success
                MessageBox.Show("Success");
            }
            else
            {
                //failure
                MessageBox.Show("An error occured");
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
