namespace GrandHotel_ManagementSystem
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
            this.pnlSideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.picDLogo = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDasboardShow = new Guna.UI2.WinForms.Guna2Panel();
            this.lblChngeTittle = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ceckOutController1 = new GrandHotel_ManagementSystem.controllers.CeckOutController();
            this.controllDashboard1 = new GrandHotel_ManagementSystem.controllers.ControllDashboard();
            this.staffController1 = new GrandHotel_ManagementSystem.controllers.StaffController();
            this.roomController1 = new GrandHotel_ManagementSystem.controllers.RoomController();
            this.bookingController1 = new GrandHotel_ManagementSystem.controllers.bookingController();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDLogo)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlDasboardShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Controls.Add(this.btnStaff);
            this.pnlSideBar.Controls.Add(this.btnRoom);
            this.pnlSideBar.Controls.Add(this.btnCheckOut);
            this.pnlSideBar.Controls.Add(this.btnBooking);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Controls.Add(this.picDLogo);
            this.pnlSideBar.Location = new System.Drawing.Point(2, 2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(258, 846);
            this.pnlSideBar.TabIndex = 2;
            // 
            // btnStaff
            // 
            this.btnStaff.BorderRadius = 20;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.FillColor = System.Drawing.Color.Black;
            this.btnStaff.FocusedColor = System.Drawing.Color.White;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStaff.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStaff.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.HoverState.Image = global::GrandHotel_ManagementSystem.Properties.Resources.icons8_staff_50;
            this.btnStaff.Image = global::GrandHotel_ManagementSystem.Properties.Resources.staff_white;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.Location = new System.Drawing.Point(30, 372);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(198, 68);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BorderRadius = 20;
            this.btnRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoom.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btnRoom.FillColor = System.Drawing.Color.Black;
            this.btnRoom.FocusedColor = System.Drawing.Color.White;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRoom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoom.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnRoom.HoverState.Image = global::GrandHotel_ManagementSystem.Properties.Resources.icons8_bed_50;
            this.btnRoom.Image = global::GrandHotel_ManagementSystem.Properties.Resources.bed_white;
            this.btnRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoom.Location = new System.Drawing.Point(30, 298);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(198, 68);
            this.btnRoom.TabIndex = 4;
            this.btnRoom.Text = "Room";
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 20;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.FillColor = System.Drawing.Color.Black;
            this.btnCheckOut.FocusedColor = System.Drawing.Color.White;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCheckOut.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.HoverState.Image = global::GrandHotel_ManagementSystem.Properties.Resources.icons8_check_dollar_50;
            this.btnCheckOut.Image = global::GrandHotel_ManagementSystem.Properties.Resources.check_whote;
            this.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckOut.Location = new System.Drawing.Point(30, 446);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(198, 68);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BorderRadius = 20;
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btnBooking.FillColor = System.Drawing.Color.Black;
            this.btnBooking.FocusedColor = System.Drawing.Color.White;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBooking.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBooking.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnBooking.HoverState.Image = global::GrandHotel_ManagementSystem.Properties.Resources.icons8_booking_48;
            this.btnBooking.Image = global::GrandHotel_ManagementSystem.Properties.Resources.booking_white;
            this.btnBooking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooking.Location = new System.Drawing.Point(30, 224);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(198, 68);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Booking";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 20;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.FillColor = System.Drawing.Color.Black;
            this.btnDashboard.FocusedColor = System.Drawing.Color.White;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.Image = global::GrandHotel_ManagementSystem.Properties.Resources.icons8_home_48;
            this.btnDashboard.Image = global::GrandHotel_ManagementSystem.Properties.Resources.whiteHomeicon;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Location = new System.Drawing.Point(30, 150);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(198, 68);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // picDLogo
            // 
            this.picDLogo.Image = global::GrandHotel_ManagementSystem.Properties.Resources.Grand_Hotel2323;
            this.picDLogo.Location = new System.Drawing.Point(-3, 16);
            this.picDLogo.Name = "picDLogo";
            this.picDLogo.Size = new System.Drawing.Size(251, 85);
            this.picDLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDLogo.TabIndex = 0;
            this.picDLogo.TabStop = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlDashboard.BorderColor = System.Drawing.Color.White;
            this.pnlDashboard.Controls.Add(this.pnlDasboardShow);
            this.pnlDashboard.Controls.Add(this.lblChngeTittle);
            this.pnlDashboard.Controls.Add(this.guna2CirclePictureBox2);
            this.pnlDashboard.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlDashboard.Controls.Add(this.txtSearchBox);
            this.pnlDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlDashboard.Location = new System.Drawing.Point(265, -3);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1245, 861);
            this.pnlDashboard.TabIndex = 3;
            // 
            // pnlDasboardShow
            // 
            this.pnlDasboardShow.Controls.Add(this.ceckOutController1);
            this.pnlDasboardShow.Controls.Add(this.controllDashboard1);
            this.pnlDasboardShow.Controls.Add(this.staffController1);
            this.pnlDasboardShow.Controls.Add(this.roomController1);
            this.pnlDasboardShow.Controls.Add(this.bookingController1);
            this.pnlDasboardShow.Location = new System.Drawing.Point(28, 155);
            this.pnlDasboardShow.Name = "pnlDasboardShow";
            this.pnlDasboardShow.Size = new System.Drawing.Size(1187, 672);
            this.pnlDasboardShow.TabIndex = 5;
            // 
            // lblChngeTittle
            // 
            this.lblChngeTittle.AutoSize = true;
            this.lblChngeTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChngeTittle.Location = new System.Drawing.Point(24, 40);
            this.lblChngeTittle.Name = "lblChngeTittle";
            this.lblChngeTittle.Size = new System.Drawing.Size(186, 38);
            this.lblChngeTittle.TabIndex = 4;
            this.lblChngeTittle.Text = "Dashboard";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::GrandHotel_ManagementSystem.Properties.Resources.am_a_19_year_old_multimedia_artist_student_from_manila__21;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(1178, 43);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(37, 39);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 3;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.ErrorImage = null;
            this.guna2CirclePictureBox1.Image = global::GrandHotel_ManagementSystem.Properties.Resources._625210;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1118, 44);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(37, 39);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BorderRadius = 20;
            this.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBox.DefaultText = "";
            this.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBox.IconLeft = global::GrandHotel_ManagementSystem.Properties.Resources.icons8_search_32;
            this.txtSearchBox.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearchBox.Location = new System.Drawing.Point(649, 38);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.PlaceholderText = "Search item";
            this.txtSearchBox.SelectedText = "";
            this.txtSearchBox.Size = new System.Drawing.Size(435, 48);
            this.txtSearchBox.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.pnlDasboardShow;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.pnlDasboardShow;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.pnlDasboardShow;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 20;
            this.guna2Elipse4.TargetControl = this.pnlDasboardShow;
            // 
            // ceckOutController1
            // 
            this.ceckOutController1.Location = new System.Drawing.Point(18, 16);
            this.ceckOutController1.Name = "ceckOutController1";
            this.ceckOutController1.Size = new System.Drawing.Size(1185, 670);
            this.ceckOutController1.TabIndex = 5;
            this.ceckOutController1.Visible = false;
            // 
            // controllDashboard1
            // 
            this.controllDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.controllDashboard1.Location = new System.Drawing.Point(18, 16);
            this.controllDashboard1.Name = "controllDashboard1";
            this.controllDashboard1.Size = new System.Drawing.Size(1185, 670);
            this.controllDashboard1.TabIndex = 4;
            this.controllDashboard1.Visible = false;
            // 
            // staffController1
            // 
            this.staffController1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.staffController1.Location = new System.Drawing.Point(18, 16);
            this.staffController1.Name = "staffController1";
            this.staffController1.Size = new System.Drawing.Size(1185, 670);
            this.staffController1.TabIndex = 3;
            this.staffController1.Visible = false;
            // 
            // roomController1
            // 
            this.roomController1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roomController1.Location = new System.Drawing.Point(18, 26);
            this.roomController1.Name = "roomController1";
            this.roomController1.Size = new System.Drawing.Size(1185, 670);
            this.roomController1.TabIndex = 2;
            this.roomController1.Visible = false;
            // 
            // bookingController1
            // 
            this.bookingController1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bookingController1.Location = new System.Drawing.Point(18, 16);
            this.bookingController1.Name = "bookingController1";
            this.bookingController1.Size = new System.Drawing.Size(1185, 670);
            this.bookingController1.TabIndex = 1;
            this.bookingController1.Visible = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1508, 850);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDLogo)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlDasboardShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSideBar;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnRoom;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnBooking;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.PictureBox picDLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlDashboard;
        private System.Windows.Forms.Label lblChngeTittle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBox;
        private Guna.UI2.WinForms.Guna2Panel pnlDasboardShow;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private controllers.bookingController bookingController1;
        private controllers.RoomController roomController1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private controllers.StaffController staffController1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private controllers.ControllDashboard controllDashboard1;
        private controllers.CeckOutController ceckOutController1;
    }
}