using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemProject_HMS
{
    public partial class frmNewAcc : Form
    {
        public frmNewAcc()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(236, 210, 161);
            this.lblWelcome.BackColor = Color.FromArgb(217, 173, 102);
            this.lblWelcome.ForeColor = Color.FromArgb(23, 29, 55);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.txtUsername.Text = "";
            this.txtPassword.Text = "";
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if(this.txtFirstName.Text == "" || this.txtLastName.Text == "" || 
               this.txtUsername.Text == "" || this.txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                DatabaseHMSDataContext context = new DatabaseHMSDataContext();
                login newRecord = new login();
                newRecord.FirstName = txtFirstName.Text;
                newRecord.LastName = txtLastName.Text;
                newRecord.Username = txtUsername.Text;
                newRecord.Password = txtPassword.Text;
                context.logins.InsertOnSubmit(newRecord);
                context.SubmitChanges();
                MessageBox.Show("Account created successfully.\nThanks for signing up.");
            }
        }
    }
}
