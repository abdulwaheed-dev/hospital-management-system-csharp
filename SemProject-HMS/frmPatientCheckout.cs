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
    public partial class frmPatientCheckout : Form
    {
        public frmPatientCheckout()
        {
            InitializeComponent();
        }

        int id = 0;
        DatabaseHMSDataContext context = new DatabaseHMSDataContext();
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtSearch.Text);

            PatientInfo pCheckout = context.PatientInfos.SingleOrDefault(x => x.PID == id);

            txtPID.Text = Convert.ToString(pCheckout.PID);
            txtPName.Text = pCheckout.Name;
            txtPPhone.Text = pCheckout.Phone;
            txtPAddress.Text = pCheckout.Address;
            txtPDisease.Text = pCheckout.DiseaseName;
            txtPRoomFloor.Text = Convert.ToString(pCheckout.RoomFloor);
            txtPRoomNo.Text = Convert.ToString(pCheckout.RoomNo);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DoctorInfo d = context.DoctorInfos.SingleOrDefault(x => x.DID == Convert.ToInt32(txtCheckoutBy.Text));

            PatientInfo pCheckout = context.PatientInfos.SingleOrDefault(x => x.PID == id);

            PatientCheckout pc = new PatientCheckout();

            pc.PID = Convert.ToInt32(txtPID.Text);
            pc.Name = txtPName.Text;
            pc.Phone = txtPPhone.Text;
            pc.Address = txtPAddress.Text;
            pc.DiseaseName = txtPDisease.Text;
            pc.RoomNo = Convert.ToInt32(txtPRoomNo.Text);
            pc.RoomFloor = Convert.ToInt32(txtPRoomFloor.Text);
            pc.CheckoutBy = d.Name.ToString();
            pc.BillCleared = cbBillClear.Checked.ToString();
            pc.Checkout = cbCheckout.Checked.ToString(); ;
            pc.DateCheckout = checkoutDate.Value;

            if (MessageBox.Show("Are you sure to checkout Patient?", "Checkout Patient", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.PatientCheckouts.InsertOnSubmit(pc);
                context.SubmitChanges();
                context.PatientInfos.DeleteOnSubmit(pCheckout);
                context.SubmitChanges();
                MessageBox.Show("Patient Checkout Successfull.");
                clearFields();
            }
        }
        void clearFields()
        {
            txtPID.Text = "";
            txtPName.Text = "";
            txtPPhone.Text = "";
            txtPAddress.Text = "";
            txtPDisease.Text = "";
            txtCheckoutBy.Text = "";
            txtPRoomFloor.Text = "";
            txtPRoomNo.Text = "";
            txtSearch.Text = "";
            cbBillClear.Checked = false;
            cbCheckout.Checked = false;
        }
    }
}
