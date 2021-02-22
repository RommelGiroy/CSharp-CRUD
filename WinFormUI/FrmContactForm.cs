using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class FrmContactForm : Form
    {
        Person p = new Person();
        public FrmContactForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to cancel!", "Contact Form", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            p.FirstName = txtFirstName.Text;
            p.LastName = txtLastName.Text;
            p.MobileNo = txtMobileNo.Text;
            p.Email = txtEmail.Text;
            p.InsertContact();

            this.Close();
        }
    }
}
