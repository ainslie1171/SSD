using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MotorcycleTourManagment
{
    class DatabaseConnection
    {
        private string m_connectionString = "user id=user;password=password;server=ainslie.noip.me;;database=ssd";
        private SqlConnection m_conn;
        private bool m_connectionStatus;

        public DatabaseConnection()
        {
            m_conn = new SqlConnection(m_connectionString);
            m_connectionStatus = false;
        }

        public void setConnectionString(string connectionString)
        {
            m_connectionString = connectionString;
        }

        public bool Open()
        {
            while (!m_connectionStatus)
            {
                try
                {
                    m_conn.Open();
                    m_connectionStatus = true;
                }
                catch (SqlException ex)
                {
                    DialogResult dialogResult = MessageBox.Show("There has been an error connecting to the database:" + Environment.NewLine + ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult.Equals(DialogResult.Cancel))
                    {
                        m_conn.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public void Close()
        {
            if(m_connectionStatus)
            {
                m_conn.Close();
            }
        }

        public bool SendCommand(string command)
        {
            if (!Open()) return false;
            bool Result = false;
            SqlCommand SqlCom = new SqlCommand(command, m_conn);
            while (!Result)
            {
                try
                {
                    SqlCom.ExecuteNonQuery();
                    Result = true;
                }
                catch (Exception w)
                {
                    DialogResult dialogResult = MessageBox.Show("There has been an error within the database." + Environment.NewLine + w.Message, "Data Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult.Equals(DialogResult.Cancel))
                    {
                        Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
