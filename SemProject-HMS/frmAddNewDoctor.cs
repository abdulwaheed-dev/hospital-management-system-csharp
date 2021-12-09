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
    public partial class frmAddNewDoctor : Form
    {
        public frmAddNewDoctor()
        {
            InitializeComponent();
        }

        void clearFields()
        {
            this.txtDID.Text = "";
            this.txtDName.Text = "";
            this.txtDPhone.Text = "";
            this.txtDAddress.Text = "";
            this.txtDPosition.Text = "";
            this.txtDQualification.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            if(this.txtDName.Text == ""||this.txtDPhone.Text == ""||this.txtDAddress.Text == ""||
            this.txtDPosition.Text == ""||this.txtDQualification.Text == "")
            {
                MessageBox.Show("Please Fill All the Feilds.");
            }
            else
            {
                DatabaseHMSDataContext context = new DatabaseHMSDataContext();
                DoctorInfo newDoctor = new DoctorInfo();
                newDoctor.Name = txtDName.Text;
                newDoctor.Phone = txtDPhone.Text;
                newDoctor.Address = txtDAddress.Text;
                newDoctor.Qualification = txtDQualification.Text;
                newDoctor.Position = txtDPosition.Text;
                context.DoctorInfos.InsertOnSubmit(newDoctor);
                context.SubmitChanges();
                MessageBox.Show("Account created successfully.\nWelcome to HMS Hospital\nMr."+newDoctor.Name.ToString());
                clearFields();
            }
        }
    }
}
