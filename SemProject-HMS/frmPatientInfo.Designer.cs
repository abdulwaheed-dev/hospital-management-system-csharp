
namespace SemProject_HMS
{
    partial class frmPatientInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtPRoomFloor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPDisease = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPAdress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPID = new Guna.UI2.WinForms.Guna2TextBox();
            this.gvPatientsInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtPSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddNewP = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientsInfo)).BeginInit();
            this.SuspendLayout();
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
            this.btnDelete.Location = new System.Drawing.Point(290, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(110, 40);
            this.btnDelete.TabIndex = 59;
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
            this.btnUpdate.Location = new System.Drawing.Point(107, 485);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(110, 40);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPRoomFloor
            // 
            this.txtPRoomFloor.Animated = true;
            this.txtPRoomFloor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomFloor.BorderRadius = 5;
            this.txtPRoomFloor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPRoomFloor.DefaultText = "";
            this.txtPRoomFloor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPRoomFloor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPRoomFloor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRoomFloor.DisabledState.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRoomFloor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomFloor.FocusedState.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPRoomFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomFloor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomFloor.HoverState.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.Location = new System.Drawing.Point(270, 429);
            this.txtPRoomFloor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPRoomFloor.Name = "txtPRoomFloor";
            this.txtPRoomFloor.PasswordChar = '\0';
            this.txtPRoomFloor.PlaceholderText = "Room Floor";
            this.txtPRoomFloor.SelectedText = "";
            this.txtPRoomFloor.ShadowDecoration.Parent = this.txtPRoomFloor;
            this.txtPRoomFloor.Size = new System.Drawing.Size(200, 33);
            this.txtPRoomFloor.TabIndex = 56;
            // 
            // txtPRoomNo
            // 
            this.txtPRoomNo.Animated = true;
            this.txtPRoomNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomNo.BorderRadius = 5;
            this.txtPRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPRoomNo.DefaultText = "";
            this.txtPRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRoomNo.DisabledState.Parent = this.txtPRoomNo;
            this.txtPRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomNo.FocusedState.Parent = this.txtPRoomNo;
            this.txtPRoomNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPRoomNo.HoverState.Parent = this.txtPRoomNo;
            this.txtPRoomNo.Location = new System.Drawing.Point(30, 429);
            this.txtPRoomNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPRoomNo.Name = "txtPRoomNo";
            this.txtPRoomNo.PasswordChar = '\0';
            this.txtPRoomNo.PlaceholderText = "Room No";
            this.txtPRoomNo.SelectedText = "";
            this.txtPRoomNo.ShadowDecoration.Parent = this.txtPRoomNo;
            this.txtPRoomNo.Size = new System.Drawing.Size(200, 33);
            this.txtPRoomNo.TabIndex = 55;
            // 
            // txtPDisease
            // 
            this.txtPDisease.Animated = true;
            this.txtPDisease.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPDisease.BorderRadius = 5;
            this.txtPDisease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPDisease.DefaultText = "";
            this.txtPDisease.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPDisease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPDisease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDisease.DisabledState.Parent = this.txtPDisease;
            this.txtPDisease.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPDisease.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDisease.FocusedState.Parent = this.txtPDisease;
            this.txtPDisease.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPDisease.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPDisease.HoverState.Parent = this.txtPDisease;
            this.txtPDisease.Location = new System.Drawing.Point(510, 379);
            this.txtPDisease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPDisease.Name = "txtPDisease";
            this.txtPDisease.PasswordChar = '\0';
            this.txtPDisease.PlaceholderText = "Disease";
            this.txtPDisease.SelectedText = "";
            this.txtPDisease.ShadowDecoration.Parent = this.txtPDisease;
            this.txtPDisease.Size = new System.Drawing.Size(200, 33);
            this.txtPDisease.TabIndex = 54;
            // 
            // txtPPhone
            // 
            this.txtPPhone.Animated = true;
            this.txtPPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPPhone.BorderRadius = 5;
            this.txtPPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPPhone.DefaultText = "";
            this.txtPPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPhone.DisabledState.Parent = this.txtPPhone;
            this.txtPPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPhone.FocusedState.Parent = this.txtPPhone;
            this.txtPPhone.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPPhone.HoverState.Parent = this.txtPPhone;
            this.txtPPhone.Location = new System.Drawing.Point(510, 329);
            this.txtPPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPPhone.Name = "txtPPhone";
            this.txtPPhone.PasswordChar = '\0';
            this.txtPPhone.PlaceholderText = "Phone";
            this.txtPPhone.SelectedText = "";
            this.txtPPhone.ShadowDecoration.Parent = this.txtPPhone;
            this.txtPPhone.Size = new System.Drawing.Size(200, 33);
            this.txtPPhone.TabIndex = 53;
            // 
            // txtPAdress
            // 
            this.txtPAdress.Animated = true;
            this.txtPAdress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPAdress.BorderRadius = 5;
            this.txtPAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPAdress.DefaultText = "";
            this.txtPAdress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPAdress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPAdress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPAdress.DisabledState.Parent = this.txtPAdress;
            this.txtPAdress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPAdress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPAdress.FocusedState.Parent = this.txtPAdress;
            this.txtPAdress.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPAdress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPAdress.HoverState.Parent = this.txtPAdress;
            this.txtPAdress.Location = new System.Drawing.Point(30, 379);
            this.txtPAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPAdress.Name = "txtPAdress";
            this.txtPAdress.PasswordChar = '\0';
            this.txtPAdress.PlaceholderText = "Address";
            this.txtPAdress.SelectedText = "";
            this.txtPAdress.ShadowDecoration.Parent = this.txtPAdress;
            this.txtPAdress.Size = new System.Drawing.Size(440, 33);
            this.txtPAdress.TabIndex = 52;
            // 
            // txtPName
            // 
            this.txtPName.Animated = true;
            this.txtPName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPName.BorderRadius = 5;
            this.txtPName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPName.DefaultText = "";
            this.txtPName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPName.DisabledState.Parent = this.txtPName;
            this.txtPName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPName.FocusedState.Parent = this.txtPName;
            this.txtPName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPName.HoverState.Parent = this.txtPName;
            this.txtPName.Location = new System.Drawing.Point(270, 329);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPName.Name = "txtPName";
            this.txtPName.PasswordChar = '\0';
            this.txtPName.PlaceholderText = "Name";
            this.txtPName.SelectedText = "";
            this.txtPName.ShadowDecoration.Parent = this.txtPName;
            this.txtPName.Size = new System.Drawing.Size(200, 33);
            this.txtPName.TabIndex = 51;
            // 
            // txtPID
            // 
            this.txtPID.Animated = true;
            this.txtPID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPID.BorderRadius = 5;
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
            this.txtPID.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPID.HoverState.Parent = this.txtPID;
            this.txtPID.Location = new System.Drawing.Point(30, 329);
            this.txtPID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPID.Name = "txtPID";
            this.txtPID.PasswordChar = '\0';
            this.txtPID.PlaceholderText = "Patient ID";
            this.txtPID.SelectedText = "";
            this.txtPID.ShadowDecoration.Parent = this.txtPID;
            this.txtPID.Size = new System.Drawing.Size(200, 33);
            this.txtPID.TabIndex = 50;
            // 
            // gvPatientsInfo
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gvPatientsInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvPatientsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvPatientsInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.gvPatientsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvPatientsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvPatientsInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPatientsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvPatientsInfo.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPatientsInfo.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvPatientsInfo.EnableHeadersVisualStyles = false;
            this.gvPatientsInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPatientsInfo.Location = new System.Drawing.Point(53, 62);
            this.gvPatientsInfo.Name = "gvPatientsInfo";
            this.gvPatientsInfo.ReadOnly = true;
            this.gvPatientsInfo.RowHeadersVisible = false;
            this.gvPatientsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPatientsInfo.Size = new System.Drawing.Size(657, 255);
            this.gvPatientsInfo.TabIndex = 49;
            this.gvPatientsInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gvPatientsInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPatientsInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvPatientsInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvPatientsInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvPatientsInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvPatientsInfo.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.gvPatientsInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPatientsInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvPatientsInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvPatientsInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvPatientsInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvPatientsInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvPatientsInfo.ThemeStyle.HeaderStyle.Height = 40;
            this.gvPatientsInfo.ThemeStyle.ReadOnly = true;
            this.gvPatientsInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPatientsInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvPatientsInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvPatientsInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPatientsInfo.ThemeStyle.RowsStyle.Height = 22;
            this.gvPatientsInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPatientsInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPatientsInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPatientsInfo_CellClick);
            // 
            // txtPSearch
            // 
            this.txtPSearch.Animated = true;
            this.txtPSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPSearch.BorderRadius = 5;
            this.txtPSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPSearch.DefaultText = "";
            this.txtPSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPSearch.DisabledState.Parent = this.txtPSearch;
            this.txtPSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPSearch.FocusedState.Parent = this.txtPSearch;
            this.txtPSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.txtPSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPSearch.HoverState.Parent = this.txtPSearch;
            this.txtPSearch.Location = new System.Drawing.Point(510, 19);
            this.txtPSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPSearch.Name = "txtPSearch";
            this.txtPSearch.PasswordChar = '\0';
            this.txtPSearch.PlaceholderText = "Search by Name";
            this.txtPSearch.SelectedText = "";
            this.txtPSearch.ShadowDecoration.Parent = this.txtPSearch;
            this.txtPSearch.Size = new System.Drawing.Size(205, 28);
            this.txtPSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPSearch.TabIndex = 47;
            this.txtPSearch.TextChanged += new System.EventHandler(this.txtPSearch_TextChanged);
            // 
            // lblAddNewP
            // 
            this.lblAddNewP.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewP.Location = new System.Drawing.Point(12, 16);
            this.lblAddNewP.Name = "lblAddNewP";
            this.lblAddNewP.Size = new System.Drawing.Size(213, 34);
            this.lblAddNewP.TabIndex = 46;
            this.lblAddNewP.Text = "Patient Information";
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.btnPrint.Font = new System.Drawing.Font("Constantia", 14F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(582, 485);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(133, 40);
            this.btnPrint.TabIndex = 60;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(210)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(744, 541);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPRoomFloor);
            this.Controls.Add(this.txtPRoomNo);
            this.Controls.Add(this.txtPDisease);
            this.Controls.Add(this.txtPPhone);
            this.Controls.Add(this.txtPAdress);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.gvPatientsInfo);
            this.Controls.Add(this.txtPSearch);
            this.Controls.Add(this.lblAddNewP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatientInfo";
            this.Text = "frmPatientInfo";
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtPRoomFloor;
        private Guna.UI2.WinForms.Guna2TextBox txtPRoomNo;
        private Guna.UI2.WinForms.Guna2TextBox txtPDisease;
        private Guna.UI2.WinForms.Guna2TextBox txtPPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPAdress;
        private Guna.UI2.WinForms.Guna2TextBox txtPName;
        private Guna.UI2.WinForms.Guna2TextBox txtPID;
        private Guna.UI2.WinForms.Guna2DataGridView gvPatientsInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtPSearch;
        private System.Windows.Forms.Label lblAddNewP;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}