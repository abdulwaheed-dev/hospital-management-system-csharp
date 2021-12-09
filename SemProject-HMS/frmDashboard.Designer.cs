
namespace SemProject_HMS
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.btnAddNewDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.pbGreenDot = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnDoctorInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewPatientCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatientCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatientInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatientRegister = new Guna.UI2.WinForms.Guna2Button();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.timerForTime = new System.Windows.Forms.Timer(this.components);
            this.pDashboard = new System.Windows.Forms.Panel();
            this.btnAboutUs = new Guna.UI2.WinForms.Guna2Button();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenDot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(173)))), ((int)(((byte)(102)))));
            this.btnBack.Font = new System.Drawing.Font("Constantia", 17F);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(947, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(125, 60);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Logout";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(173)))), ((int)(((byte)(102)))));
            this.btnExit.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageOffset = new System.Drawing.Point(-1, -1);
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(0, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(125, 60);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(123, -2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(828, 60);
            this.lblWelcome.TabIndex = 17;
            this.lblWelcome.Text = "HMS Hospital Sukkur";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.btnAboutUs);
            this.panelDashboard.Controls.Add(this.btnAddNewDoctor);
            this.panelDashboard.Controls.Add(this.pbGreenDot);
            this.panelDashboard.Controls.Add(this.btnDashboard);
            this.panelDashboard.Controls.Add(this.lblTimer);
            this.panelDashboard.Controls.Add(this.btnDoctorInfo);
            this.panelDashboard.Controls.Add(this.btnViewPatientCheckout);
            this.panelDashboard.Controls.Add(this.btnPatientCheckout);
            this.panelDashboard.Controls.Add(this.btnPatientInfo);
            this.panelDashboard.Controls.Add(this.btnPatientRegister);
            this.panelDashboard.Controls.Add(this.lblActive);
            this.panelDashboard.Controls.Add(this.lblUsername);
            this.panelDashboard.Controls.Add(this.pbUserImage);
            this.panelDashboard.Location = new System.Drawing.Point(0, 58);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(315, 550);
            this.panelDashboard.TabIndex = 18;
            // 
            // btnAddNewDoctor
            // 
            this.btnAddNewDoctor.Animated = true;
            this.btnAddNewDoctor.CheckedState.Parent = this.btnAddNewDoctor;
            this.btnAddNewDoctor.CustomImages.Parent = this.btnAddNewDoctor;
            this.btnAddNewDoctor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnAddNewDoctor.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnAddNewDoctor.ForeColor = System.Drawing.Color.White;
            this.btnAddNewDoctor.HoverState.Parent = this.btnAddNewDoctor;
            this.btnAddNewDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewDoctor.Image")));
            this.btnAddNewDoctor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddNewDoctor.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnAddNewDoctor.ImageSize = new System.Drawing.Size(10, 15);
            this.btnAddNewDoctor.Location = new System.Drawing.Point(0, 368);
            this.btnAddNewDoctor.Name = "btnAddNewDoctor";
            this.btnAddNewDoctor.ShadowDecoration.Parent = this.btnAddNewDoctor;
            this.btnAddNewDoctor.Size = new System.Drawing.Size(315, 39);
            this.btnAddNewDoctor.TabIndex = 31;
            this.btnAddNewDoctor.Text = "Add New Doctor";
            this.btnAddNewDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewDoctor.TextOffset = new System.Drawing.Point(10, 3);
            this.btnAddNewDoctor.Click += new System.EventHandler(this.btnAddNewDoctor_Click);
            // 
            // pbGreenDot
            // 
            this.pbGreenDot.Image = ((System.Drawing.Image)(resources.GetObject("pbGreenDot.Image")));
            this.pbGreenDot.Location = new System.Drawing.Point(111, 64);
            this.pbGreenDot.Name = "pbGreenDot";
            this.pbGreenDot.Size = new System.Drawing.Size(15, 15);
            this.pbGreenDot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGreenDot.TabIndex = 22;
            this.pbGreenDot.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(0, 2);
            this.btnDashboard.ImageSize = new System.Drawing.Size(15, 20);
            this.btnDashboard.Location = new System.Drawing.Point(0, 115);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(315, 59);
            this.btnDashboard.TabIndex = 30;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffset = new System.Drawing.Point(-10, 3);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(3, 498);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(309, 45);
            this.lblTimer.TabIndex = 29;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDoctorInfo
            // 
            this.btnDoctorInfo.Animated = true;
            this.btnDoctorInfo.CheckedState.Parent = this.btnDoctorInfo;
            this.btnDoctorInfo.CustomImages.Parent = this.btnDoctorInfo;
            this.btnDoctorInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnDoctorInfo.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnDoctorInfo.ForeColor = System.Drawing.Color.White;
            this.btnDoctorInfo.HoverState.Parent = this.btnDoctorInfo;
            this.btnDoctorInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctorInfo.Image")));
            this.btnDoctorInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDoctorInfo.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDoctorInfo.ImageSize = new System.Drawing.Size(10, 15);
            this.btnDoctorInfo.Location = new System.Drawing.Point(0, 413);
            this.btnDoctorInfo.Name = "btnDoctorInfo";
            this.btnDoctorInfo.ShadowDecoration.Parent = this.btnDoctorInfo;
            this.btnDoctorInfo.Size = new System.Drawing.Size(315, 39);
            this.btnDoctorInfo.TabIndex = 28;
            this.btnDoctorInfo.Text = "Doctor Information";
            this.btnDoctorInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoctorInfo.TextOffset = new System.Drawing.Point(10, 3);
            this.btnDoctorInfo.Click += new System.EventHandler(this.btnDoctorInfo_Click);
            // 
            // btnViewPatientCheckout
            // 
            this.btnViewPatientCheckout.Animated = true;
            this.btnViewPatientCheckout.CheckedState.Parent = this.btnViewPatientCheckout;
            this.btnViewPatientCheckout.CustomImages.Parent = this.btnViewPatientCheckout;
            this.btnViewPatientCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnViewPatientCheckout.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnViewPatientCheckout.ForeColor = System.Drawing.Color.White;
            this.btnViewPatientCheckout.HoverState.Parent = this.btnViewPatientCheckout;
            this.btnViewPatientCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPatientCheckout.Image")));
            this.btnViewPatientCheckout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnViewPatientCheckout.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnViewPatientCheckout.ImageSize = new System.Drawing.Size(10, 15);
            this.btnViewPatientCheckout.Location = new System.Drawing.Point(0, 323);
            this.btnViewPatientCheckout.Name = "btnViewPatientCheckout";
            this.btnViewPatientCheckout.ShadowDecoration.Parent = this.btnViewPatientCheckout;
            this.btnViewPatientCheckout.Size = new System.Drawing.Size(315, 39);
            this.btnViewPatientCheckout.TabIndex = 27;
            this.btnViewPatientCheckout.Text = "View Patient Checkout";
            this.btnViewPatientCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewPatientCheckout.TextOffset = new System.Drawing.Point(10, 3);
            this.btnViewPatientCheckout.Click += new System.EventHandler(this.btnViewPatientCheckout_Click);
            // 
            // btnPatientCheckout
            // 
            this.btnPatientCheckout.Animated = true;
            this.btnPatientCheckout.CheckedState.Parent = this.btnPatientCheckout;
            this.btnPatientCheckout.CustomImages.Parent = this.btnPatientCheckout;
            this.btnPatientCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnPatientCheckout.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnPatientCheckout.ForeColor = System.Drawing.Color.White;
            this.btnPatientCheckout.HoverState.Parent = this.btnPatientCheckout;
            this.btnPatientCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnPatientCheckout.Image")));
            this.btnPatientCheckout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPatientCheckout.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPatientCheckout.ImageSize = new System.Drawing.Size(10, 15);
            this.btnPatientCheckout.Location = new System.Drawing.Point(0, 278);
            this.btnPatientCheckout.Name = "btnPatientCheckout";
            this.btnPatientCheckout.ShadowDecoration.Parent = this.btnPatientCheckout;
            this.btnPatientCheckout.Size = new System.Drawing.Size(315, 39);
            this.btnPatientCheckout.TabIndex = 26;
            this.btnPatientCheckout.Text = "Patient Checkout";
            this.btnPatientCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatientCheckout.TextOffset = new System.Drawing.Point(10, 3);
            this.btnPatientCheckout.Click += new System.EventHandler(this.btnPatientCheckout_Click);
            // 
            // btnPatientInfo
            // 
            this.btnPatientInfo.Animated = true;
            this.btnPatientInfo.CheckedState.Parent = this.btnPatientInfo;
            this.btnPatientInfo.CustomImages.Parent = this.btnPatientInfo;
            this.btnPatientInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnPatientInfo.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnPatientInfo.ForeColor = System.Drawing.Color.White;
            this.btnPatientInfo.HoverState.Parent = this.btnPatientInfo;
            this.btnPatientInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnPatientInfo.Image")));
            this.btnPatientInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPatientInfo.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPatientInfo.ImageSize = new System.Drawing.Size(10, 15);
            this.btnPatientInfo.Location = new System.Drawing.Point(0, 233);
            this.btnPatientInfo.Name = "btnPatientInfo";
            this.btnPatientInfo.ShadowDecoration.Parent = this.btnPatientInfo;
            this.btnPatientInfo.Size = new System.Drawing.Size(315, 39);
            this.btnPatientInfo.TabIndex = 25;
            this.btnPatientInfo.Text = "Patient Information";
            this.btnPatientInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatientInfo.TextOffset = new System.Drawing.Point(10, 3);
            this.btnPatientInfo.Click += new System.EventHandler(this.btnPatientInfo_Click);
            // 
            // btnPatientRegister
            // 
            this.btnPatientRegister.Animated = true;
            this.btnPatientRegister.CheckedState.Parent = this.btnPatientRegister;
            this.btnPatientRegister.CustomImages.Parent = this.btnPatientRegister;
            this.btnPatientRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnPatientRegister.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnPatientRegister.ForeColor = System.Drawing.Color.White;
            this.btnPatientRegister.HoverState.Parent = this.btnPatientRegister;
            this.btnPatientRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnPatientRegister.Image")));
            this.btnPatientRegister.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPatientRegister.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPatientRegister.ImageSize = new System.Drawing.Size(10, 15);
            this.btnPatientRegister.Location = new System.Drawing.Point(0, 188);
            this.btnPatientRegister.Name = "btnPatientRegister";
            this.btnPatientRegister.ShadowDecoration.Parent = this.btnPatientRegister;
            this.btnPatientRegister.Size = new System.Drawing.Size(315, 39);
            this.btnPatientRegister.TabIndex = 24;
            this.btnPatientRegister.Text = "Patient Registration";
            this.btnPatientRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatientRegister.TextOffset = new System.Drawing.Point(10, 3);
            this.btnPatientRegister.Click += new System.EventHandler(this.btnPatientRegister_Click);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.Color.White;
            this.lblActive.Location = new System.Drawing.Point(127, 59);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(63, 23);
            this.lblActive.TabIndex = 21;
            this.lblActive.Text = "Active";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 18.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(98, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(214, 45);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "User Name";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbUserImage
            // 
            this.pbUserImage.Image = ((System.Drawing.Image)(resources.GetObject("pbUserImage.Image")));
            this.pbUserImage.Location = new System.Drawing.Point(14, 17);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(78, 74);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 19;
            this.pbUserImage.TabStop = false;
            // 
            // timerForTime
            // 
            this.timerForTime.Interval = 1000;
            this.timerForTime.Tick += new System.EventHandler(this.timerForTime_Tick);
            // 
            // pDashboard
            // 
            this.pDashboard.Location = new System.Drawing.Point(321, 61);
            this.pDashboard.Name = "pDashboard";
            this.pDashboard.Size = new System.Drawing.Size(744, 541);
            this.pDashboard.TabIndex = 19;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Animated = true;
            this.btnAboutUs.CheckedState.Parent = this.btnAboutUs;
            this.btnAboutUs.CustomImages.Parent = this.btnAboutUs;
            this.btnAboutUs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btnAboutUs.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.HoverState.Parent = this.btnAboutUs;
            this.btnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Image")));
            this.btnAboutUs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAboutUs.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnAboutUs.ImageSize = new System.Drawing.Size(10, 15);
            this.btnAboutUs.Location = new System.Drawing.Point(0, 458);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.ShadowDecoration.Parent = this.btnAboutUs;
            this.btnAboutUs.Size = new System.Drawing.Size(315, 39);
            this.btnAboutUs.TabIndex = 32;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAboutUs.TextOffset = new System.Drawing.Point(10, 3);
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 606);
            this.Controls.Add(this.pDashboard);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenDot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.PictureBox pbGreenDot;
        private Guna.UI2.WinForms.Guna2Button btnPatientRegister;
        private Guna.UI2.WinForms.Guna2Button btnPatientInfo;
        private Guna.UI2.WinForms.Guna2Button btnDoctorInfo;
        private Guna.UI2.WinForms.Guna2Button btnViewPatientCheckout;
        private Guna.UI2.WinForms.Guna2Button btnPatientCheckout;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timerForTime;
        private System.Windows.Forms.Panel pDashboard;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnAddNewDoctor;
        private Guna.UI2.WinForms.Guna2Button btnAboutUs;
    }
}