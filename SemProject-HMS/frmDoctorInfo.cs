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
    public partial class frmDoctorInfo : Form
    {
        public frmDoctorInfo()
        {
            InitializeComponent();
            getData();
        }

        void getData()
        {
            DatabaseHMSDataContext context = new DatabaseHMSDataContext();
            this.gvDoctorInfo.DataSource = context.DoctorInfos;
        }
        void clearFields()
        {
            txtDID.Text = "";
            txtDName.Text = "";
            txtDPhone.Text = "";
            txtDAddress.Text = "";
            txtDPosition.Text = "";
            txtDQualification.Text = "";
        }

        private void gvDoctorInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvDoctorInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    gvDoctorInfo.CurrentRow.Selected = true;
                    txtDID.Text = gvDoctorInfo.Rows[e.RowIndex].Cells["DID"].FormattedValue.ToString();
                    txtDName.Text = gvDoctorInfo.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    txtDPhone.Text = gvDoctorInfo.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
                    txtDAddress.Text = gvDoctorInfo.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                    txtDQualification.Text = gvDoctorInfo.Rows[e.RowIndex].Cells["Qualification"].FormattedValue.ToString();
                    txtDPosition.Text = gvDoctorInfo.Rows[e.RowIndex].Cells["Position"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Display its Data.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDID.Text);
            using (var context = new DatabaseHMSDataContext())
            {
                DoctorInfo deleteRecord = context.DoctorInfos.SingleOrDefault(record => record.DID == id);
                if (MessageBox.Show("Are you sure to Delete Record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.DoctorInfos.DeleteOnSubmit(deleteRecord);
                    context.SubmitChanges();
                    MessageBox.Show("Record deleted Successfully.");
                }
                getData();
                clearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDID.Text);
            using (var context = new DatabaseHMSDataContext())
            {
                DoctorInfo UpdateRecord = context.DoctorInfos.SingleOrDefault(record => record.DID == id);
                UpdateRecord.Name = txtDName.Text;
                UpdateRecord.Phone = txtDPhone.Text;
                UpdateRecord.Address = txtDAddress.Text;
                UpdateRecord.Qualification = txtDQualification.Text;
                UpdateRecord.Position = txtDPosition.Text;

                context.SubmitChanges();
                MessageBox.Show("Record Updated Successfully.");
                getData();
                clearFields();
            }
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
                IEnumerable<DoctorInfo> searched = from s in context.DoctorInfos where s.Name.Contains(searchName) select s;
                this.gvDoctorInfo.DataSource = searched;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Init print datagridview
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Doctors Information";//Header
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
            printer.PrintDataGridView(this.gvDoctorInfo);
        }
    }
}
