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
    public partial class frmDashboard : Form
    {
        frmMiniDboard FormMiniDboard = new frmMiniDboard() { TopLevel = false, TopMost = true };
        public frmDashboard()
        {
            InitializeComponent();
            this.timerForTime.Enabled = true;
            this.timerForTime.Start();
            this.BackColor = Color.FromArgb(236, 210, 161);
            this.lblWelcome.BackColor = Color.FromArgb(217, 173, 102);
            this.lblWelcome.ForeColor = Color.FromArgb(23, 29, 55);
            this.panelDashboard.BackColor = Color.FromArgb(34, 45, 49);     
            
            this.pDashboard.Controls.Add(FormMiniDboard);
            FormMiniDboard.Show();
        }
        public frmDashboard(string name)
        {
            InitializeComponent();
            this.timerForTime.Enabled = true;
            this.timerForTime.Start();
            this.BackColor = Color.FromArgb(236, 210, 161);
            this.lblWelcome.BackColor = Color.FromArgb(217, 173, 102);
            this.lblWelcome.ForeColor = Color.FromArgb(23, 29, 55);
            this.panelDashboard.BackColor = Color.FromArgb(34, 45, 49);
            this.lblUsername.Text = name;
            this.pDashboard.Controls.Add(FormMiniDboard);
            FormMiniDboard.Show();
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

        private void timerForTime_Tick(object sender, EventArgs e)
        {
            this.lblTimer.Text = System.DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Text = "Dashboard";
            this.pDashboard.Controls.Clear();
            this.pDashboard.Controls.Add(FormMiniDboard);
            FormMiniDboard.Show();
        }

        private void btnPatientRegister_Click(object sender, EventArgs e)
        {
            this.Text = "Register New Patient";
            frmPatientRegister FormPatientRegister = new frmPatientRegister() { TopLevel = false, TopMost = true };
            this.pDashboard.Controls.Clear();
            this.pDashboard.Controls.Add(FormPatientRegister);
            FormPatientRegister.Show();
        }

        private void btnAddNewDoctor_Click(object sender, EventArgs e)
        {
            this.Text = "Register New Doctor";
            frmAddNewDoctor FormAddNewDoctor = new frmAddNewDoctor() { TopLevel = false, TopMost = true };
            this.pDashboard.Controls.Clear();
            this.pDashboard.Controls.Add(FormAddNewDoctor);
            FormAddNewDoctor.Show();
        }

        private void btnPatientInfo_Click(object sender, EventArgs e)
        {
            this.Text = "Patient Information";
            frmPatientInfo FormPatientInfo = new frmPatientInfo() { TopLevel = false, TopMost = true };
            this.pDashboard.Controls.Clear();
            this.pDashboard.Controls.Add(FormPatientInfo);
            FormPatientInfo.Show();
        }

        private void btnDoctorInfo_Click(object sender, EventArgs e)
        {
            this.Text = "Doctor Information";
            frmDoctorInfo FormDoctorInfo = new frmDoctorInfo() { TopLevel = false, TopMost = true };
            this.pDashboard.Controls.Clear();
            this.pDashboard.Controls.Add(FormDoctorInfo);
            FormDoctorInfo.Show();
        }

        private void btnPatientCheckout_Click(object sender, EventArgs e)
        {
            this.Text = "Patient Checkout";
            frmPatientCheckout FormPatientCheckout = new frmPatientCheckout() { TopLevel = false, TopMost = true };
            this.pDashboard.Controls.Clear();
            this.pDashboard.Controls.Add(FormPatientCheckout);
            FormPatientCheckout.Show();
        }

        private void btnViewPatientCheckout_Click(object sender, EventArgs e)
        {
            this.Text = "Patient Checkout";
            frmViewPatientCheckout FormViewCheckout = new frmViewPatientCheckout() { TopLevel = false, TopMost = true };
            this.pDashboard.Controls.Clear();
            this.pDashboard.Controls.Add(FormViewCheckout);
            FormViewCheckout.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            this.Text = "About Us";
            frmAboutus FormAboutUs = new frmAboutus() { TopLevel = false, TopMost = true };
            this.pDashboard.Controls.Clear();
            this.pDashboard.Controls.Add(FormAboutUs);
            FormAboutUs.Show();
        }
    }
}
