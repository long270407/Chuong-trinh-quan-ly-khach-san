using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ChuuongTrinhQuanLyKhachSan
{
    partial class Dashbroad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRes = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Employee1 = new ChuuongTrinhQuanLyKhachSan.All_User_Control.UC_Employee();
            this.uC_CustomerDetails1 = new ChuuongTrinhQuanLyKhachSan.All_User_Control.UC_CustomerDetails();
            this.uC_CustomerCheckOut1 = new ChuuongTrinhQuanLyKhachSan.All_User_Control.UC_CustomerCheckOut();
            this.uC_CustomerRes1 = new ChuuongTrinhQuanLyKhachSan.All_User_Control.UC_CustomerRes();
            this.uC_AddRoom1 = new ChuuongTrinhQuanLyKhachSan.All_User_Control.UC_AddRoom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.lblBrandTitle);
            this.panel1.Controls.Add(this.lblBrandSub);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.btnCustomerRes);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCustomerDetail);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1824, 92);
            this.panel1.TabIndex = 2;
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(24, 18);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(202, 38);
            this.lblBrandTitle.TabIndex = 6;
            this.lblBrandTitle.Text = "ROYAL HOTEL";
            // 
            // lblBrandSub
            // 
            this.lblBrandSub.AutoSize = true;
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBrandSub.Location = new System.Drawing.Point(26, 56);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Size = new System.Drawing.Size(175, 21);
            this.lblBrandSub.TabIndex = 7;
            this.lblBrandSub.Text = "HOTEL MANAGEMENT";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 10;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnAddRoom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnAddRoom.Location = new System.Drawing.Point(260, 20);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(185, 52);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Thêm phòng";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnCustomerRes
            // 
            this.btnCustomerRes.BorderRadius = 10;
            this.btnCustomerRes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCustomerRes.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCustomerRes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCustomerRes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCustomerRes.Location = new System.Drawing.Point(455, 20);
            this.btnCustomerRes.Name = "btnCustomerRes";
            this.btnCustomerRes.Size = new System.Drawing.Size(215, 52);
            this.btnCustomerRes.TabIndex = 1;
            this.btnCustomerRes.Text = "Đăng ký phòng";
            this.btnCustomerRes.Click += new System.EventHandler(this.btnCustomerRes_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 10;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCheckOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCheckOut.Location = new System.Drawing.Point(680, 20);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(185, 52);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.BorderRadius = 10;
            this.btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCustomerDetail.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnCustomerDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCustomerDetail.Location = new System.Drawing.Point(875, 20);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(215, 52);
            this.btnCustomerDetail.TabIndex = 3;
            this.btnCustomerDetail.Text = "Chi tiết khách";
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 10;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnEmployee.Location = new System.Drawing.Point(1100, 20);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(185, 52);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Nhân viên";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1800, 985);
            this.panel2.TabIndex = 3;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.Location = new System.Drawing.Point(-2, -1);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1818, 843);
            this.uC_Employee1.TabIndex = 5;
            this.uC_Employee1.Visible = false;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(3, 3);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1796, 797);
            this.uC_CustomerDetails1.TabIndex = 6;
            this.uC_CustomerDetails1.Visible = false;
            // 
            // uC_CustomerCheckOut1
            // 
            this.uC_CustomerCheckOut1.Location = new System.Drawing.Point(-2, -2);
            this.uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            this.uC_CustomerCheckOut1.Size = new System.Drawing.Size(1882, 852);
            this.uC_CustomerCheckOut1.TabIndex = 6;
            this.uC_CustomerCheckOut1.Visible = false;
            // 
            // uC_CustomerRes1
            // 
            this.uC_CustomerRes1.Location = new System.Drawing.Point(-2, -3);
            this.uC_CustomerRes1.Name = "uC_CustomerRes1";
            this.uC_CustomerRes1.Size = new System.Drawing.Size(1882, 852);
            this.uC_CustomerRes1.TabIndex = 1;
            this.uC_CustomerRes1.Visible = false;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.Location = new System.Drawing.Point(-3, -3);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1860, 797);
            this.uC_AddRoom1.TabIndex = 0;
            this.uC_AddRoom1.Visible = false;
            // 
            // Dashbroad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1824, 1103);
            this.Controls.Add(this.panel2);
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_CustomerDetails1);
            this.panel2.Controls.Add(this.uC_CustomerCheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerRes1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(740, 520);
            this.Name = "Dashbroad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Hotel — Quản lý khách sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashbroad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna2Button[] navigation;

        private void ConfigureLayout()
        {
            navigation = new[] { btnAddRoom, btnCustomerRes, btnCheckOut, btnCustomerDetail, btnEmployee };

            panel1.Dock = DockStyle.Left;
            panel1.BackColor = HotelTheme.Navy;
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panel2.Dock = DockStyle.Fill;
            panel2.BackColor = HotelTheme.Canvas;
            panel2.TabIndex = 1;
            panel1.TabIndex = 0;
            lblBrandTitle.Text = "Royal Hotel";
            lblBrandTitle.Font = HotelTheme.Brand;
            lblBrandTitle.ForeColor = Color.White;
            lblBrandSub.Text = "Quản lý khách sạn";
            lblBrandSub.Font = HotelTheme.Body;
            lblBrandSub.ForeColor = HotelTheme.Gold;

            btnAddRoom.Text = "Quản lý phòng";
            btnCustomerRes.Text = "Nhận phòng";
            btnCheckOut.Text = "Thanh toán";
            btnCustomerDetail.Text = "Khách hàng";
            btnEmployee.Text = "Nhân viên";

            foreach (Guna2Button button in navigation)
            {
                button.Font = HotelTheme.Caption;
                button.BorderRadius = 8;
                button.FillColor = HotelTheme.Navy;
                button.ForeColor = Color.White;
                button.TextAlign = HorizontalAlignment.Left;
                button.TextOffset = new Point(8, 0);
                button.Cursor = Cursors.Hand;
                button.HoverState.FillColor = HotelTheme.NavyLight;
                button.CheckedState.FillColor = HotelTheme.NavyLight;
                button.CheckedState.ForeColor = HotelTheme.Gold;
            }

            foreach (Control view in panel2.Controls)
                view.Dock = DockStyle.Fill;

            void Arrange()
            {
                int P(int value) => HotelTheme.Px(this, value);
                bool compact = ClientSize.Width < P(980);
                panel1.Width = P(compact ? 174 : 216);
                lblBrandTitle.Font = compact ? HotelTheme.SmallBrand : HotelTheme.Brand;
                lblBrandTitle.Location = new Point(P(20), P(27));
                lblBrandSub.Location = new Point(P(21), P(65));
                for (int index = 0; index < navigation.Length; index++)
                    navigation[index].SetBounds(P(12), P(115 + index * 51), panel1.Width - P(24), P(43));
            }

            Resize += (sender, args) => Arrange();
            HandleCreated += (sender, args) => Arrange();
            Arrange();
        }

        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRes;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private All_User_Control.UC_AddRoom uC_AddRoom1;
        private All_User_Control.UC_CustomerRes uC_CustomerRes1;
        private All_User_Control.UC_CustomerCheckOut uC_CustomerCheckOut1;
        private All_User_Control.UC_CustomerDetails uC_CustomerDetails1;
        private All_User_Control.UC_Employee uC_Employee1;
    }
}
