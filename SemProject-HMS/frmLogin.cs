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
    public partial class frmLogin : Form
    {
        string NameOfUser = "";
        public frmLogin()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(236, 210, 161);
            this.lblTitle.ForeColor = Color.FromArgb(229, 81, 81);
            this.lblLogin.ForeColor = Color.FromArgb(86, 119, 160);
            this.lblBar.BackColor = Color.FromArgb(24, 30, 56);
            lblInfo.ForeColor = Color.FromArgb(0, 0, 64);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            frmNewAcc NewAccForm = new frmNewAcc();
            this.Hide();
            NewAccForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblInfo.Text = "Enter both Username,Password";
            }
            else
            {
                try
                {
                    DatabaseHMSDataContext context = new DatabaseHMSDataContext();
                    var user = (from s in context.logins
                                where s.Username == txtUsername.Text
                                select s).First();
                    if (user.Password == txtPassword.Text)
                    {
                        NameOfUser = user.FirstName +" "+ user.LastName;
                        this.Hide();
                        new frmDashboard(NameOfUser).ShowDialog();
                    }
                    else
                    {
                        lblInfo.Text = "Incorrect Username or Password";
                    }
                }
                catch(Exception)
                {
                    lblInfo.Text = "Incorrect Username or Password";
                }
            }
            

        }
    }
}
