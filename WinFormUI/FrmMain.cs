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

namespace WinFormUI
{
    public partial class FrmMain : Form
    {
        Person p = new Person();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmContactForm frm = new FrmContactForm();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit this program", "My Contacts", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmMain_Activated(object sender, EventArgs e)
        {
            p.LoadData("SELECT * FROM my_contact", dgvContacts);
        }

        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvContacts.Tag = dgvContacts.Item(0, e.RowIndex).Value;
        }
    }
}
