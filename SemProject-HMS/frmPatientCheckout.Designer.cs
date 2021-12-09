
namespace SemProject_HMS
{
    partial class frmPatientCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientCheckout));
            this.lblPatientCheckout = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtPRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPRoomFloor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPDisease = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.txtCheckoutBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbCheckout = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbBillClear = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkoutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPatientCheckout
            // 
            this.lblPatientCheckout.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientCheckout.Location = new System.Drawing.Point(12, 19);
            this.lblPatientCheckout.Name = "lblPatientCheckout";
            this.lblPatientCheckout.Size = new System.Drawing.Size(213, 34);
            this.lblPatientCheckout.TabIndex = 47;
            this.lblPatientCheckout.Text = "Patient Checkout";
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(70, 61);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search by ID";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(517, 51);
            this.txtSearch.TabIndex = 53;
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(45, 45);
            this.btnSearch.Location = new System.Drawing.Point(594, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(80, 51);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtPRoomNo.Enabled = false;
            this.txtPRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomNo.FocusedState.Parent = this.txtPRoomNo;
            this.txtPRoomNo.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomNo.HoverState.Parent = this.txtPRoomNo;
            this.txtPRoomNo.Location = new System.Drawing.Point(61, 311);
            this.txtPRoomNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPRoomNo.Name = "txtPRoomNo";
            this.txtPRoomNo.PasswordChar = '\0';
            this.txtPRoomNo.PlaceholderText = "Room No";
            this.txtPRoomNo.ReadOnly = true;
            this.txtPRoomNo.SelectedText = "";
            this.txtPRoomNo.ShadowDecoration.Parent = this.txtPRoomNo;
            this.txtPRoomNo.Size = new System.Drawing.Size(250, 35);
            this.txtPRoomNo.TabIndex = 62;
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
            this.txtPRoomFloor.Enabled = false;
            this.txtPRoomFloor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomFloor.FocusedState.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPRoomFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomFloor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomFloor.HoverState.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.Location = new System.Drawing.Point(415, 311);
            this.txtPRoomFloor.Margin = new System.Windows.Forms.Padding(4);
            this.txtPRoomFloor.Name = "txtPRoomFloor";
            this.txtPRoomFloor.PasswordChar = '\0';
            this.txtPRoomFloor.PlaceholderText = "Room Floor";
            this.txtPRoomFloor.ReadOnly = true;
            this.txtPRoomFloor.SelectedText = "";
            this.txtPRoomFloor.ShadowDecoration.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.Size = new System.Drawing.Size(250, 35);
            this.txtPRoomFloor.TabIndex = 61;
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
            this.txtPDisease.Enabled = false;
            this.txtPDisease.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDisease.FocusedState.Parent = this.txtPDisease;
            this.txtPDisease.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPDisease.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDisease.HoverState.Parent = this.txtPDisease;
            this.txtPDisease.Location = new System.Drawing.Point(415, 256);
            this.txtPDisease.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDisease.Name = "txtPDisease";
            this.txtPDisease.PasswordChar = '\0';
            this.txtPDisease.PlaceholderText = "Disease";
            this.txtPDisease.ReadOnly = true;
            this.txtPDisease.SelectedText = "";
            this.txtPDisease.ShadowDecoration.Parent = this.txtPDisease;
            this.txtPDisease.Size = new System.Drawing.Size(250, 35);
            this.txtPDisease.TabIndex = 59;
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
            this.txtPPhone.Enabled = false;
            this.txtPPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPhone.FocusedState.Parent = this.txtPPhone;
            this.txtPPhone.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPhone.HoverState.Parent = this.txtPPhone;
            this.txtPPhone.Location = new System.Drawing.Point(61, 256);
            this.txtPPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPhone.Name = "txtPPhone";
            this.txtPPhone.PasswordChar = '\0';
            this.txtPPhone.PlaceholderText = "Phone";
            this.txtPPhone.ReadOnly = true;
            this.txtPPhone.SelectedText = "";
            this.txtPPhone.ShadowDecoration.Parent = this.txtPPhone;
            this.txtPPhone.Size = new System.Drawing.Size(250, 35);
            this.txtPPhone.TabIndex = 58;
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
            this.txtPAddress.Enabled = false;
            this.txtPAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPAddress.FocusedState.Parent = this.txtPAddress;
            this.txtPAddress.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPAddress.HoverState.Parent = this.txtPAddress;
            this.txtPAddress.Location = new System.Drawing.Point(61, 201);
            this.txtPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtPAddress.Name = "txtPAddress";
            this.txtPAddress.PasswordChar = '\0';
            this.txtPAddress.PlaceholderText = "Address";
            this.txtPAddress.ReadOnly = true;
            this.txtPAddress.SelectedText = "";
            this.txtPAddress.ShadowDecoration.Parent = this.txtPAddress;
            this.txtPAddress.Size = new System.Drawing.Size(604, 35);
            this.txtPAddress.TabIndex = 57;
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
            this.txtPName.Enabled = false;
            this.txtPName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPName.FocusedState.Parent = this.txtPName;
            this.txtPName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPName.HoverState.Parent = this.txtPName;
            this.txtPName.Location = new System.Drawing.Point(415, 146);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.Name = "txtPName";
            this.txtPName.PasswordChar = '\0';
            this.txtPName.PlaceholderText = "Name";
            this.txtPName.ReadOnly = true;
            this.txtPName.SelectedText = "";
            this.txtPName.ShadowDecoration.Parent = this.txtPName;
            this.txtPName.Size = new System.Drawing.Size(250, 35);
            this.txtPName.TabIndex = 56;
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
            this.txtPID.Location = new System.Drawing.Point(61, 146);
            this.txtPID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPID.Name = "txtPID";
            this.txtPID.PasswordChar = '\0';
            this.txtPID.PlaceholderText = "Patient ID";
            this.txtPID.ReadOnly = true;
            this.txtPID.SelectedText = "";
            this.txtPID.ShadowDecoration.Parent = this.txtPID;
            this.txtPID.Size = new System.Drawing.Size(250, 35);
            this.txtPID.TabIndex = 55;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Animated = true;
            this.btnCheckout.BorderRadius = 10;
            this.btnCheckout.CheckedState.Parent = this.btnCheckout;
            this.btnCheckout.CustomImages.Parent = this.btnCheckout;
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.btnCheckout.Font = new System.Drawing.Font("Constantia", 20.25F);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.HoverState.Parent = this.btnCheckout;
            this.btnCheckout.Location = new System.Drawing.Point(229, 477);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.ShadowDecoration.Parent = this.btnCheckout;
            this.btnCheckout.Size = new System.Drawing.Size(250, 50);
            this.btnCheckout.TabIndex = 63;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtCheckoutBy
            // 
            this.txtCheckoutBy.Animated = true;
            this.txtCheckoutBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtCheckoutBy.BorderRadius = 10;
            this.txtCheckoutBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheckoutBy.DefaultText = "";
            this.txtCheckoutBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCheckoutBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCheckoutBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckoutBy.DisabledState.Parent = this.txtCheckoutBy;
            this.txtCheckoutBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckoutBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCheckoutBy.FocusedState.Parent = this.txtCheckoutBy;
            this.txtCheckoutBy.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtCheckoutBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtCheckoutBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCheckoutBy.HoverState.Parent = this.txtCheckoutBy;
            this.txtCheckoutBy.Location = new System.Drawing.Point(61, 371);
            this.txtCheckoutBy.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckoutBy.Name = "txtCheckoutBy";
            this.txtCheckoutBy.PasswordChar = '\0';
            this.txtCheckoutBy.PlaceholderText = "Checkout By(Doctor)";
            this.txtCheckoutBy.SelectedText = "";
            this.txtCheckoutBy.ShadowDecoration.Parent = this.txtCheckoutBy;
            this.txtCheckoutBy.Size = new System.Drawing.Size(247, 35);
            this.txtCheckoutBy.TabIndex = 64;
            // 
            // cbCheckout
            // 
            this.cbCheckout.Animated = true;
            this.cbCheckout.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCheckout.CheckedState.BorderRadius = 0;
            this.cbCheckout.CheckedState.BorderThickness = 0;
            this.cbCheckout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCheckout.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cbCheckout.Location = new System.Drawing.Point(109, 416);
            this.cbCheckout.Name = "cbCheckout";
            this.cbCheckout.Size = new System.Drawing.Size(150, 25);
            this.cbCheckout.TabIndex = 68;
            this.cbCheckout.Text = "Checkout";
            this.cbCheckout.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.cbCheckout.UncheckedState.BorderRadius = 0;
            this.cbCheckout.UncheckedState.BorderThickness = 0;
            this.cbCheckout.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // cbBillClear
            // 
            this.cbBillClear.Animated = true;
            this.cbBillClear.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBillClear.CheckedState.BorderRadius = 0;
            this.cbBillClear.CheckedState.BorderThickness = 0;
            this.cbBillClear.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBillClear.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cbBillClear.Location = new System.Drawing.Point(109, 446);
            this.cbBillClear.Name = "cbBillClear";
            this.cbBillClear.Size = new System.Drawing.Size(150, 25);
            this.cbBillClear.TabIndex = 69;
            this.cbBillClear.Text = "Bill Cleared";
            this.cbBillClear.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.cbBillClear.UncheckedState.BorderRadius = 0;
            this.cbBillClear.UncheckedState.BorderThickness = 0;
            this.cbBillClear.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // checkoutDate
            // 
            this.checkoutDate.Animated = true;
            this.checkoutDate.BackColor = System.Drawing.Color.Transparent;
            this.checkoutDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.checkoutDate.BorderRadius = 5;
            this.checkoutDate.BorderThickness = 1;
            this.checkoutDate.CheckedState.Parent = this.checkoutDate;
            this.checkoutDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.checkoutDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.checkoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkoutDate.HoverState.Parent = this.checkoutDate;
            this.checkoutDate.Location = new System.Drawing.Point(415, 386);
            this.checkoutDate.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.checkoutDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.checkoutDate.Name = "checkoutDate";
            this.checkoutDate.ShadowDecoration.Parent = this.checkoutDate;
            this.checkoutDate.Size = new System.Drawing.Size(250, 35);
            this.checkoutDate.TabIndex = 70;
            this.checkoutDate.Value = new System.DateTime(2021, 7, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Checkout Date:";
            // 
            // frmPatientCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(744, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkoutDate);
            this.Controls.Add(this.cbBillClear);
            this.Controls.Add(this.cbCheckout);
            this.Controls.Add(this.txtCheckoutBy);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.txtPRoomNo);
            this.Controls.Add(this.txtPRoomFloor);
            this.Controls.Add(this.txtPDisease);
            this.Controls.Add(this.txtPPhone);
            this.Controls.Add(this.txtPAddress);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblPatientCheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatientCheckout";
            this.Text = "frmPatientCheckout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPatientCheckout;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtPRoomNo;
        private Guna.UI2.WinForms.Guna2TextBox txtPRoomFloor;
        private Guna.UI2.WinForms.Guna2TextBox txtPDisease;
        private Guna.UI2.WinForms.Guna2TextBox txtPPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtPName;
        private Guna.UI2.WinForms.Guna2TextBox txtPID;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2TextBox txtCheckoutBy;
        private Guna.UI2.WinForms.Guna2CheckBox cbCheckout;
        private Guna.UI2.WinForms.Guna2CheckBox cbBillClear;
        private Guna.UI2.WinForms.Guna2DateTimePicker checkoutDate;
        private System.Windows.Forms.Label label1;
    }
}