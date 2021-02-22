using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WinFormUI
{
    public class Person
    {
        public int id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }

        public void InsertContact()
        {
            try
            {                
                using (MySqlCommand cmd = new MySqlCommand("InsertContact", DataAccess.con))
                {
                    DataAccess.con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("first_name", FirstName);
                    cmd.Parameters.AddWithValue("last_name", LastName);
                    cmd.Parameters.AddWithValue("mobile_no", MobileNo);
                    cmd.Parameters.AddWithValue("email", Email);
                    cmd.ExecuteNonQuery(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "My Contacts", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadData(string sql, DataGridView datagrid)
        {
            DataAccess.GetDBConnection();

            using (MySqlDataAdapter da = new MySqlDataAdapter(sql, DataAccess.con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagrid.DataSource = dt;
            }
        }
    }
}
