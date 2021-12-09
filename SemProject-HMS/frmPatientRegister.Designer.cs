
namespace SemProject_HMS
{
    partial class frmPatientRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddNewP = new System.Windows.Forms.Label();
            this.txtPName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPDisease = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPRoomFloor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtPID
            // 
            this.txtPID.Animated = true;
            this.txtPID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPID.BorderRadius = 10;
            this.txtPID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPID.DefaultText = "";
            this.txtPID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPID.DisabledState.Parent = this.txtPID;
            this.txtPID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPID.Enabled = false;
            this.txtPID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPID.FocusedState.Parent = this.txtPID;
            this.txtPID.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPID.HoverState.Parent = this.txtPID;
            this.txtPID.Location = new System.Drawing.Point(63, 86);
            this.txtPID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPID.Name = "txtPID";
            this.txtPID.PasswordChar = '\0';
            this.txtPID.PlaceholderText = "Patient ID";
            this.txtPID.ReadOnly = true;
            this.txtPID.SelectedText = "";
            this.txtPID.ShadowDecoration.Parent = this.txtPID;
            this.txtPID.Size = new System.Drawing.Size(250, 43);
            this.txtPID.TabIndex = 0;
            // 
            // lblAddNewP
            // 
            this.lblAddNewP.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewP.Location = new System.Drawing.Point(27, 24);
            this.lblAddNewP.Name = "lblAddNewP";
            this.lblAddNewP.Size = new System.Drawing.Size(213, 34);
            this.lblAddNewP.TabIndex = 1;
            this.lblAddNewP.Text = "Add New Patient";
            // 
            // txtPName
            // 
            this.txtPName.Animated = true;
            this.txtPName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPName.BorderRadius = 10;
            this.txtPName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPName.DefaultText = "";
            this.txtPName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPName.DisabledState.Parent = this.txtPName;
            this.txtPName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPName.FocusedState.Parent = this.txtPName;
            this.txtPName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPName.HoverState.Parent = this.txtPName;
            this.txtPName.Location = new System.Drawing.Point(63, 156);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.Name = "txtPName";
            this.txtPName.PasswordChar = '\0';
            this.txtPName.PlaceholderText = "Name";
            this.txtPName.SelectedText = "";
            this.txtPName.ShadowDecoration.Parent = this.txtPName;
            this.txtPName.Size = new System.Drawing.Size(250, 43);
            this.txtPName.TabIndex = 2;
            // 
            // txtPAddress
            // 
            this.txtPAddress.Animated = true;
            this.txtPAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPAddress.BorderRadius = 10;
            this.txtPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPAddress.DefaultText = "";
            this.txtPAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPAddress.DisabledState.Parent = this.txtPAddress;
            this.txtPAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPAddress.FocusedState.Parent = this.txtPAddress;
            this.txtPAddress.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPAddress.HoverState.Parent = this.txtPAddress;
            this.txtPAddress.Location = new System.Drawing.Point(63, 226);
            this.txtPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPAddress.Name = "txtPAddress";
            this.txtPAddress.PasswordChar = '\0';
            this.txtPAddress.PlaceholderText = "Address";
            this.txtPAddress.SelectedText = "";
            this.txtPAddress.ShadowDecoration.Parent = this.txtPAddress;
            this.txtPAddress.Size = new System.Drawing.Size(604, 43);
            this.txtPAddress.TabIndex = 3;
            // 
            // txtPPhone
            // 
            this.txtPPhone.Animated = true;
            this.txtPPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPPhone.BorderRadius = 10;
            this.txtPPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPPhone.DefaultText = "";
            this.txtPPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPhone.DisabledState.Parent = this.txtPPhone;
            this.txtPPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPhone.FocusedState.Parent = this.txtPPhone;
            this.txtPPhone.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPhone.HoverState.Parent = this.txtPPhone;
            this.txtPPhone.Location = new System.Drawing.Point(63, 296);
            this.txtPPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPhone.Name = "txtPPhone";
            this.txtPPhone.PasswordChar = '\0';
            this.txtPPhone.PlaceholderText = "Phone";
            this.txtPPhone.SelectedText = "";
            this.txtPPhone.ShadowDecoration.Parent = this.txtPPhone;
            this.txtPPhone.Size = new System.Drawing.Size(250, 43);
            this.txtPPhone.TabIndex = 4;
            // 
            // txtPDisease
            // 
            this.txtPDisease.Animated = true;
            this.txtPDisease.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPDisease.BorderRadius = 10;
            this.txtPDisease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPDisease.DefaultText = "";
            this.txtPDisease.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPDisease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPDisease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDisease.DisabledState.Parent = this.txtPDisease;
            this.txtPDisease.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDisease.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDisease.FocusedState.Parent = this.txtPDisease;
            this.txtPDisease.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPDisease.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDisease.HoverState.Parent = this.txtPDisease;
            this.txtPDisease.Location = new System.Drawing.Point(417, 296);
            this.txtPDisease.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDisease.Name = "txtPDisease";
            this.txtPDisease.PasswordChar = '\0';
            this.txtPDisease.PlaceholderText = "Disease";
            this.txtPDisease.SelectedText = "";
            this.txtPDisease.ShadowDecoration.Parent = this.txtPDisease;
            this.txtPDisease.Size = new System.Drawing.Size(250, 43);
            this.txtPDisease.TabIndex = 5;
            // 
            // txtPRoomFloor
            // 
            this.txtPRoomFloor.Animated = true;
            this.txtPRoomFloor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomFloor.BorderRadius = 10;
            this.txtPRoomFloor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPRoomFloor.DefaultText = "";
            this.txtPRoomFloor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPRoomFloor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPRoomFloor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRoomFloor.DisabledState.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRoomFloor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomFloor.FocusedState.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPRoomFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomFloor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomFloor.HoverState.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.Location = new System.Drawing.Point(417, 366);
            this.txtPRoomFloor.Margin = new System.Windows.Forms.Padding(4);
            this.txtPRoomFloor.Name = "txtPRoomFloor";
            this.txtPRoomFloor.PasswordChar = '\0';
            this.txtPRoomFloor.PlaceholderText = "Room Floor";
            this.txtPRoomFloor.SelectedText = "";
            this.txtPRoomFloor.ShadowDecoration.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.Size = new System.Drawing.Size(250, 43);
            this.txtPRoomFloor.TabIndex = 7;
            // 
            // txtPRoomNo
            // 
            this.txtPRoomNo.Animated = true;
            this.txtPRoomNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomNo.BorderRadius = 10;
            this.txtPRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPRoomNo.DefaultText = "";
            this.txtPRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRoomNo.DisabledState.Parent = this.txtPRoomNo;
            this.txtPRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomNo.FocusedState.Parent = this.txtPRoomNo;
            this.txtPRoomNo.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomNo.HoverState.Parent = this.txtPRoomNo;
            this.txtPRoomNo.Location = new System.Drawing.Point(63, 366);
            this.txtPRoomNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPRoomNo.Name = "txtPRoomNo";
            this.txtPRoomNo.PasswordChar = '\0';
            this.txtPRoomNo.PlaceholderText = "Room No";
            this.txtPRoomNo.SelectedText = "";
            this.txtPRoomNo.ShadowDecoration.Parent = this.txtPRoomNo;
            this.txtPRoomNo.Size = new System.Drawing.Size(250, 43);
            this.txtPRoomNo.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.BorderRadius = 10;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.btnClear.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(173, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(112, 45);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Animated = true;
            this.btnAddPatient.BorderRadius = 10;
            this.btnAddPatient.CheckedState.Parent = this.btnAddPatient;
            this.btnAddPatient.CustomImages.Parent = this.btnAddPatient;
            this.btnAddPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.btnAddPatient.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.HoverState.Parent = this.btnAddPatient;
            this.btnAddPatient.Location = new System.Drawing.Point(390, 446);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.ShadowDecoration.Parent = this.btnAddPatient;
            this.btnAddPatient.Size = new System.Drawing.Size(187, 45);
            this.btnAddPatient.TabIndex = 14;
            this.btnAddPatient.Text = "Add New Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // frmPatientRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(744, 541);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.txtPRoomNo);
            this.Controls.Add(this.txtPRoomFloor);
            this.Controls.Add(this.txtPDisease);
            this.Controls.Add(this.txtPPhone);
            this.Controls.Add(this.txtPAddress);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.lblAddNewP);
            this.Controls.Add(this.txtPID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatientRegister";
            this.Text = "frmPatientRegister";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtPID;
        private System.Windows.Forms.Label lblAddNewP;
        private Guna.UI2.WinForms.Guna2TextBox txtPName;
        private Guna.UI2.WinForms.Guna2TextBox txtPAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtPPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPDisease;
        private Guna.UI2.WinForms.Guna2TextBox txtPRoomFloor;
        private Guna.UI2.WinForms.Guna2TextBox txtPRoomNo;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
    }
}