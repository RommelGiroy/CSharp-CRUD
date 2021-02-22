using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormUI
{
    public static class DataAccess
    {
        public static MySqlConnection con;

        public static void GetDBConnection()
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["MyContacts"].ConnectionString;

                using (con = new MySqlConnection(connection))
                {
                    con.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "My Contacts", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }
    }
}
