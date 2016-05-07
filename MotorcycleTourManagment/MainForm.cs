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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_NTour_Click(object sender, EventArgs e)
        {
            frm_NewTour form = new frm_NewTour();
            form.ShowDialog();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            if(connection.Open())
            {
                MessageBox.Show("Connection Successfull!");
            }
            else
            {
                MessageBox.Show("Better luck next time =[");
            }
            connection.Close();
        }
    }
}
