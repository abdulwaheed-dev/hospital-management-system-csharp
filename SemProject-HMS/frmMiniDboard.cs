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
    public partial class frmMiniDboard : Form
    {
        public frmMiniDboard()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(236, 210, 161);
            this.lblPatientRegister.ForeColor = Color.White;
            this.lblPatientRegisterCount.ForeColor = Color.Red;
            this.lblTotalPatient.ForeColor = Color.White;
            this.lblTotalPatientCount.ForeColor = Color.Yellow;
            this.lblPatientCheckout.ForeColor = Color.White;
            this.lblPatientCheckoutCount.ForeColor = Color.DarkBlue;
            this.lblDoctor.ForeColor = Color.White;
            this.lblDoctorCount.ForeColor = Color.LightSeaGreen;
            this.lblQuote.ForeColor = Color.White;
            this.lblQuoteA.ForeColor = Color.White;
            this.lblBottom.ForeColor = Color.White;
            setLabelText();
        }
        void setLabelText()
        {
            DatabaseHMSDataContext context = new DatabaseHMSDataContext();
            int pReg = (from s in context.PatientInfos select s).Count();
            this.lblPatientRegisterCount.Text = Convert.ToString(pReg);
            this.lblTotalPatientCount.Text = Convert.ToString(pReg);
            int pCh = (from s in context.PatientCheckouts select s).Count();
            this.lblPatientCheckoutCount.Text = Convert.ToString(pCh);
            int d = (from s in context.DoctorInfos select s).Count();
            this.lblDoctorCount.Text = Convert.ToString(d);

        }
    }
}
