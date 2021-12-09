using DGVPrinterHelper;
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
    public partial class frmViewPatientCheckout : Form
    {
        public frmViewPatientCheckout()
        {
            InitializeComponent();
            getData();
        }
        
        void getData()
        {
            DatabaseHMSDataContext context = new DatabaseHMSDataContext();
            this.gvPatientsCheckout.DataSource = context.PatientCheckouts;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                getData();
            }
            else
            {
                string searchName = txtSearch.Text;
                DatabaseHMSDataContext context = new DatabaseHMSDataContext();
                IEnumerable<PatientCheckout> searched = from s in context.PatientCheckouts where s.Name.Contains(searchName) select s;
                this.gvPatientsCheckout.DataSource = searched;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Init print datagridview
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Patients Report";//Header
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "FoxLearn";//Footer
            printer.FooterSpacing = 15;
            //Print landscape mode
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(this.gvPatientsCheckout);
        }
    }
}
