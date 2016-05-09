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
    public partial class frm_NewCustomer : Form
    {
        private DatabaseConnection conn;

        public frm_NewCustomer()
        {
            InitializeComponent();
            conn = new DatabaseConnection();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = tbx_FirstName.Text;
            customer.LastName = tbx_LastName.Text;
            customer.Address = tbx_Address.Text;
            customer.Age = tbx_Age.Text;
            customer.Email = tbx_Email.Text;
            customer.Phone = tbx_Phone.Text;
            customer.BikeRegNumber = tbx_BikeRegNumber.Text;

            string SQLCommand = "INSERT INTO tbl_Customer (FirstName, LastName, Address, Age, Email, Phone, BikeRegNumber) Values ('" + customer.GetInfo() + "')";

            if (conn.SendCommand(SQLCommand))
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

        private void frm_NewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
