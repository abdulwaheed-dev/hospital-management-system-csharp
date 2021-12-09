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
    public partial class frmPatientRegister : Form
    {
        public frmPatientRegister()
        {
            InitializeComponent();
            this.lblAddNewP.ForeColor = Color.FromArgb(34, 45, 49);
        }
        void clearFields()
        {
            this.txtPID.Text = "";
            this.txtPName.Text = "";
            this.txtPPhone.Text = "";
            this.txtPAddress.Text = "";
            this.txtPRoomNo.Text = "";
            this.txtPRoomFloor.Text = "";
            this.txtPDisease.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

            if (this.txtPName.Text == "" || this.txtPPhone.Text == "" ||
            this.txtPAddress.Text == "" || this.txtPRoomNo.Text == "" ||
            this.txtPRoomFloor.Text == "" || this.txtPDisease.Text == "")
            {
                MessageBox.Show("Please Fill all Fields");
            }
            else
            {
                DatabaseHMSDataContext context = new DatabaseHMSDataContext();
                PatientInfo newPatient = new PatientInfo();
                newPatient.Name = txtPName.Text;
                newPatient.Phone = txtPPhone.Text;
                newPatient.Address = txtPAddress.Text;
                newPatient.DiseaseName = txtPDisease.Text;
                newPatient.RoomNo = Convert.ToInt32(txtPRoomNo.Text);
                newPatient.RoomFloor = Convert.ToInt32(txtPRoomFloor.Text);
                
                context.PatientInfos.InsertOnSubmit(newPatient);
                context.SubmitChanges();
                MessageBox.Show("Patient Registered Successfully.");
                clearFields();
            
            }
            
        }
    }
}
