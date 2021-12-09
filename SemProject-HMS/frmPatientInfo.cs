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
    public partial class frmPatientInfo : Form
    {
        public frmPatientInfo()
        {
            InitializeComponent();
            getData();
        }
        void getData()
        {
            DatabaseHMSDataContext context = new DatabaseHMSDataContext();
            this.gvPatientsInfo.DataSource = context.PatientInfos;
        }
        void clearFields()
        {
            txtPID.Text = "";
            txtPName.Text = "";
            txtPPhone.Text = "";
            txtPAdress.Text = "";
            txtPDisease.Text = "";
            txtPRoomFloor.Text = "";
            txtPRoomNo.Text = "";
        }

        private void gvPatientsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvPatientsInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    gvPatientsInfo.CurrentRow.Selected = true;
                    txtPID.Text = gvPatientsInfo.Rows[e.RowIndex].Cells["PID"].FormattedValue.ToString();
                    txtPName.Text = gvPatientsInfo.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    txtPPhone.Text = gvPatientsInfo.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
                    txtPAdress.Text = gvPatientsInfo.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                    txtPDisease.Text = gvPatientsInfo.Rows[e.RowIndex].Cells["DiseaseName"].FormattedValue.ToString();
                    txtPRoomNo.Text = gvPatientsInfo.Rows[e.RowIndex].Cells["RoomNo"].FormattedValue.ToString();
                    txtPRoomFloor.Text = gvPatientsInfo.Rows[e.RowIndex].Cells["RoomFloor"].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Display its Data.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtPID.Text);
            using (var context = new DatabaseHMSDataContext())
            {
                PatientInfo UpdateRecord = context.PatientInfos.SingleOrDefault(record => record.PID == id);
                UpdateRecord.Name = txtPName.Text;
                UpdateRecord.Phone = txtPPhone.Text;
                UpdateRecord.Address = txtPAdress.Text;
                UpdateRecord.DiseaseName = txtPDisease.Text;
                UpdateRecord.RoomFloor = Convert.ToInt32(txtPRoomFloor.Text);
                UpdateRecord.RoomNo = Convert.ToInt32(txtPRoomNo.Text);

                context.SubmitChanges();
                MessageBox.Show("Record Updated Successfully.");
                getData();
                clearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtPID.Text);
            using (var context = new DatabaseHMSDataContext())
            {
                PatientInfo deleteRecord = context.PatientInfos.SingleOrDefault(record => record.PID == id);
                if (MessageBox.Show("Are you sure to Delete Record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.PatientInfos.DeleteOnSubmit(deleteRecord);
                    context.SubmitChanges();
                    MessageBox.Show("Record deleted Successfully.");
                }
                getData();
                clearFields();
            }
        }

        private void txtPSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtPSearch.Text == "")
            {
                getData();
            }
            else 
            {
                string searchName = txtPSearch.Text;
                DatabaseHMSDataContext context = new DatabaseHMSDataContext();
                IEnumerable<PatientInfo> searched = from s in context.PatientInfos where s.Name.Contains(searchName) select s;
                this.gvPatientsInfo.DataSource = searched;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Patients Information";//Header
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
            printer.PrintDataGridView(this.gvPatientsInfo);
        }
    }
}
