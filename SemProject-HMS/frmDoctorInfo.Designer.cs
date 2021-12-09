
namespace SemProject_HMS
{
    partial class frmDoctorInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDQualification = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtDPosition = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDID = new Guna.UI2.WinForms.Guna2TextBox();
            this.gvDoctorInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddNewP = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctorInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDQualification
            // 
            this.txtDQualification.Animated = true;
            this.txtDQualification.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDQualification.BorderRadius = 5;
            this.txtDQualification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDQualification.DefaultText = "";
            this.txtDQualification.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDQualification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDQualification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDQualification.DisabledState.Parent = this.txtDQualification;
            this.txtDQualification.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDQualification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDQualification.FocusedState.Parent = this.txtDQualification;
            this.txtDQualification.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDQualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDQualification.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDQualification.HoverState.Parent = this.txtDQualification;
            this.txtDQualification.Location = new System.Drawing.Point(30, 429);
            this.txtDQualification.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDQualification.Name = "txtDQualification";
            this.txtDQualification.PasswordChar = '\0';
            this.txtDQualification.PlaceholderText = "Qualification";
            this.txtDQualification.SelectedText = "";
            this.txtDQualification.ShadowDecoration.Parent = this.txtDQualification;
            this.txtDQualification.Size = new System.Drawing.Size(440, 33);
            this.txtDQualification.TabIndex = 30;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.btnDelete.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(320, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.btnUpdate.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(150, 485);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(110, 40);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDPosition
            // 
            this.txtDPosition.Animated = true;
            this.txtDPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDPosition.BorderRadius = 5;
            this.txtDPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDPosition.DefaultText = "";
            this.txtDPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDPosition.DisabledState.Parent = this.txtDPosition;
            this.txtDPosition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDPosition.FocusedState.Parent = this.txtDPosition;
            this.txtDPosition.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDPosition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDPosition.HoverState.Parent = this.txtDPosition;
            this.txtDPosition.Location = new System.Drawing.Point(510, 379);
            this.txtDPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDPosition.Name = "txtDPosition";
            this.txtDPosition.PasswordChar = '\0';
            this.txtDPosition.PlaceholderText = "Position";
            this.txtDPosition.SelectedText = "";
            this.txtDPosition.ShadowDecoration.Parent = this.txtDPosition;
            this.txtDPosition.Size = new System.Drawing.Size(200, 33);
            this.txtDPosition.TabIndex = 27;
            // 
            // txtDPhone
            // 
            this.txtDPhone.Animated = true;
            this.txtDPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDPhone.BorderRadius = 5;
            this.txtDPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDPhone.DefaultText = "";
            this.txtDPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDPhone.DisabledState.Parent = this.txtDPhone;
            this.txtDPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDPhone.FocusedState.Parent = this.txtDPhone;
            this.txtDPhone.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDPhone.HoverState.Parent = this.txtDPhone;
            this.txtDPhone.Location = new System.Drawing.Point(510, 329);
            this.txtDPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDPhone.Name = "txtDPhone";
            this.txtDPhone.PasswordChar = '\0';
            this.txtDPhone.PlaceholderText = "Phone";
            this.txtDPhone.SelectedText = "";
            this.txtDPhone.ShadowDecoration.Parent = this.txtDPhone;
            this.txtDPhone.Size = new System.Drawing.Size(200, 33);
            this.txtDPhone.TabIndex = 26;
            // 
            // txtDAddress
            // 
            this.txtDAddress.Animated = true;
            this.txtDAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDAddress.BorderRadius = 5;
            this.txtDAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDAddress.DefaultText = "";
            this.txtDAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDAddress.DisabledState.Parent = this.txtDAddress;
            this.txtDAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDAddress.FocusedState.Parent = this.txtDAddress;
            this.txtDAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDAddress.HoverState.Parent = this.txtDAddress;
            this.txtDAddress.Location = new System.Drawing.Point(30, 379);
            this.txtDAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDAddress.Name = "txtDAddress";
            this.txtDAddress.PasswordChar = '\0';
            this.txtDAddress.PlaceholderText = "Address";
            this.txtDAddress.SelectedText = "";
            this.txtDAddress.ShadowDecoration.Parent = this.txtDAddress;
            this.txtDAddress.Size = new System.Drawing.Size(440, 33);
            this.txtDAddress.TabIndex = 25;
            // 
            // txtDName
            // 
            this.txtDName.Animated = true;
            this.txtDName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDName.BorderRadius = 5;
            this.txtDName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDName.DefaultText = "";
            this.txtDName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDName.DisabledState.Parent = this.txtDName;
            this.txtDName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDName.FocusedState.Parent = this.txtDName;
            this.txtDName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDName.HoverState.Parent = this.txtDName;
            this.txtDName.Location = new System.Drawing.Point(270, 329);
            this.txtDName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDName.Name = "txtDName";
            this.txtDName.PasswordChar = '\0';
            this.txtDName.PlaceholderText = "Name";
            this.txtDName.SelectedText = "";
            this.txtDName.ShadowDecoration.Parent = this.txtDName;
            this.txtDName.Size = new System.Drawing.Size(200, 33);
            this.txtDName.TabIndex = 24;
            // 
            // txtDID
            // 
            this.txtDID.Animated = true;
            this.txtDID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDID.BorderRadius = 5;
            this.txtDID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDID.DefaultText = "";
            this.txtDID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDID.DisabledState.Parent = this.txtDID;
            this.txtDID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDID.Enabled = false;
            this.txtDID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDID.FocusedState.Parent = this.txtDID;
            this.txtDID.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtDID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDID.HoverState.Parent = this.txtDID;
            this.txtDID.Location = new System.Drawing.Point(30, 329);
            this.txtDID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDID.Name = "txtDID";
            this.txtDID.PasswordChar = '\0';
            this.txtDID.PlaceholderText = "Doctor ID";
            this.txtDID.ReadOnly = true;
            this.txtDID.SelectedText = "";
            this.txtDID.ShadowDecoration.Parent = this.txtDID;
            this.txtDID.Size = new System.Drawing.Size(200, 33);
            this.txtDID.TabIndex = 23;
            // 
            // gvDoctorInfo
            // 
            this.gvDoctorInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gvDoctorInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gvDoctorInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvDoctorInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.gvDoctorInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDoctorInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvDoctorInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDoctorInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gvDoctorInfo.ColumnHeadersHeight = 40;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDoctorInfo.DefaultCellStyle = dataGridViewCellStyle12;
            this.gvDoctorInfo.EnableHeadersVisualStyles = false;
            this.gvDoctorInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvDoctorInfo.Location = new System.Drawing.Point(12, 60);
            this.gvDoctorInfo.Name = "gvDoctorInfo";
            this.gvDoctorInfo.ReadOnly = true;
            this.gvDoctorInfo.RowHeadersVisible = false;
            this.gvDoctorInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDoctorInfo.Size = new System.Drawing.Size(720, 255);
            this.gvDoctorInfo.TabIndex = 22;
            this.gvDoctorInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gvDoctorInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvDoctorInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvDoctorInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvDoctorInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvDoctorInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvDoctorInfo.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.gvDoctorInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvDoctorInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvDoctorInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvDoctorInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvDoctorInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvDoctorInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvDoctorInfo.ThemeStyle.HeaderStyle.Height = 40;
            this.gvDoctorInfo.ThemeStyle.ReadOnly = true;
            this.gvDoctorInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvDoctorInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvDoctorInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvDoctorInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvDoctorInfo.ThemeStyle.RowsStyle.Height = 22;
            this.gvDoctorInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvDoctorInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvDoctorInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDoctorInfo_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(504, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search by Name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(205, 28);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblAddNewP
            // 
            this.lblAddNewP.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewP.Location = new System.Drawing.Point(12, 16);
            this.lblAddNewP.Name = "lblAddNewP";
            this.lblAddNewP.Size = new System.Drawing.Size(213, 34);
            this.lblAddNewP.TabIndex = 19;
            this.lblAddNewP.Text = "Doctor Information";
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.btnPrint.Font = new System.Drawing.Font("Constantia", 14.25F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(578, 485);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(132, 40);
            this.btnPrint.TabIndex = 57;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmDoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(744, 541);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtDQualification);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDPosition);
            this.Controls.Add(this.txtDPhone);
            this.Controls.Add(this.txtDAddress);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.txtDID);
            this.Controls.Add(this.gvDoctorInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblAddNewP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctorInfo";
            this.Text = "frmDoctorInfo";
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctorInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtDQualification;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtDPosition;
        private Guna.UI2.WinForms.Guna2TextBox txtDPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtDAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtDName;
        private Guna.UI2.WinForms.Guna2TextBox txtDID;
        private Guna.UI2.WinForms.Guna2DataGridView gvDoctorInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblAddNewP;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}