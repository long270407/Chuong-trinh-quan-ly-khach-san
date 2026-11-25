using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChuuongTrinhQuanLyKhachSan.All_User_Control
{
    partial class UC_CustomerRes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDProof = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAlloteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Nhận Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Và Tên";
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtName.BorderRadius = 8;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtName.Location = new System.Drawing.Point(40, 110);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtName.PlaceholderText = "Nhập họ và tên...";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(380, 44);
            this.txtName.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtContact.BorderRadius = 8;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtContact.Location = new System.Drawing.Point(40, 205);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtContact.PlaceholderText = "Nhập số điện thoại...";
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(380, 44);
            this.txtContact.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(40, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtNationality
            // 
            this.txtNationality.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtNationality.BorderRadius = 8;
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.DefaultText = "";
            this.txtNationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtNationality.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtNationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtNationality.Location = new System.Drawing.Point(40, 300);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtNationality.PlaceholderText = "Nhập quốc tịch (Việt Nam...)...";
            this.txtNationality.SelectedText = "";
            this.txtNationality.Size = new System.Drawing.Size(380, 44);
            this.txtNationality.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(40, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quốc Tịch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(40, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới Tính";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtGender.BorderRadius = 8;
            this.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtGender.ItemHeight = 36;
            this.txtGender.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.txtGender.Location = new System.Drawing.Point(40, 395);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(380, 42);
            this.txtGender.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(40, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày Sinh";
            // 
            // txtDob
            // 
            this.txtDob.BorderRadius = 8;
            this.txtDob.Checked = true;
            this.txtDob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtDob.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDob.ForeColor = System.Drawing.Color.White;
            this.txtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDob.Location = new System.Drawing.Point(40, 490);
            this.txtDob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(380, 44);
            this.txtDob.TabIndex = 10;
            this.txtDob.Value = new System.DateTime(2026, 11, 11, 1, 26, 58, 670);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtAddress.BorderRadius = 8;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtAddress.Location = new System.Drawing.Point(460, 205);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtAddress.PlaceholderText = "Nhập địa chỉ cư trú...";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(380, 44);
            this.txtAddress.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(460, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Địa Chỉ";
            // 
            // txtIDProof
            // 
            this.txtIDProof.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtIDProof.BorderRadius = 8;
            this.txtIDProof.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProof.DefaultText = "";
            this.txtIDProof.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProof.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProof.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtIDProof.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtIDProof.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtIDProof.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtIDProof.Location = new System.Drawing.Point(460, 110);
            this.txtIDProof.Name = "txtIDProof";
            this.txtIDProof.PasswordChar = '\0';
            this.txtIDProof.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtIDProof.PlaceholderText = "Nhập CCCD / Hộ chiếu...";
            this.txtIDProof.SelectedText = "";
            this.txtIDProof.Size = new System.Drawing.Size(380, 44);
            this.txtIDProof.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(460, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "CCCD / Hộ Chiếu";
            // 
            // txtCheckin
            // 
            this.txtCheckin.BorderRadius = 8;
            this.txtCheckin.Checked = true;
            this.txtCheckin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtCheckin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckin.ForeColor = System.Drawing.Color.White;
            this.txtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCheckin.Location = new System.Drawing.Point(460, 300);
            this.txtCheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckin.Name = "txtCheckin";
            this.txtCheckin.Size = new System.Drawing.Size(380, 44);
            this.txtCheckin.TabIndex = 16;
            this.txtCheckin.Value = new System.DateTime(2026, 11, 11, 1, 26, 58, 670);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(460, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ngày Nhận Phòng";
            // 
            // txtBed
            // 
            this.txtBed.BackColor = System.Drawing.Color.Transparent;
            this.txtBed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtBed.BorderRadius = 8;
            this.txtBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtBed.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtBed.ItemHeight = 36;
            this.txtBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txtBed.Location = new System.Drawing.Point(880, 110);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(380, 42);
            this.txtBed.TabIndex = 18;
            this.txtBed.SelectedIndexChanged += new System.EventHandler(this.txtBed_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(880, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Loại Giường";
            // 
            // txtRoom
            // 
            this.txtRoom.BackColor = System.Drawing.Color.Transparent;
            this.txtRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtRoom.BorderRadius = 8;
            this.txtRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtRoom.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtRoom.ItemHeight = 36;
            this.txtRoom.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac"});
            this.txtRoom.Location = new System.Drawing.Point(880, 205);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(380, 42);
            this.txtRoom.TabIndex = 20;
            this.txtRoom.SelectedIndexChanged += new System.EventHandler(this.txtRoom_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label11.Location = new System.Drawing.Point(880, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 28);
            this.label11.TabIndex = 19;
            this.label11.Text = "Loại Phòng";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtRoomNo.BorderRadius = 8;
            this.txtRoomNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtRoomNo.ItemHeight = 36;
            this.txtRoomNo.Location = new System.Drawing.Point(880, 300);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(380, 42);
            this.txtRoomNo.TabIndex = 22;
            this.txtRoomNo.SelectedIndexChanged += new System.EventHandler(this.txtRoomNo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(880, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 28);
            this.label12.TabIndex = 21;
            this.label12.Text = "Số Phòng";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtPrice.BorderRadius = 8;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtPrice.Location = new System.Drawing.Point(880, 395);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtPrice.PlaceholderText = "Tự động hiển thị theo phòng...";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(380, 44);
            this.txtPrice.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(880, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 28);
            this.label13.TabIndex = 23;
            this.label13.Text = "Giá Phòng (VNĐ)";
            // 
            // btnAlloteRoom
            // 
            this.btnAlloteRoom.BorderRadius = 10;
            this.btnAlloteRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlloteRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlloteRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlloteRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlloteRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnAlloteRoom.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlloteRoom.ForeColor = System.Drawing.Color.White;
            this.btnAlloteRoom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnAlloteRoom.Location = new System.Drawing.Point(880, 480);
            this.btnAlloteRoom.Name = "btnAlloteRoom";
            this.btnAlloteRoom.Size = new System.Drawing.Size(380, 54);
            this.btnAlloteRoom.TabIndex = 25;
            this.btnAlloteRoom.Text = "✓ Đăng Ký Nhận Phòng";
            this.btnAlloteRoom.Click += new System.EventHandler(this.btnAlloteRoom_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_CustomerRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAlloteRoom);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCheckin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIDProof);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_CustomerRes";
            this.Size = new System.Drawing.Size(1882, 852);
            this.Load += new System.EventHandler(this.UC_CustomerRes_Load);
            this.Leave += new System.EventHandler(this.UC_CustomerRes_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ConfigureLayout()
        {
            var content = HotelTheme.Page(this);
            HotelTheme.Title(label1, "Đăng ký nhận phòng");
            HotelTheme.Action(btnAlloteRoom, "Đăng ký nhận phòng");

            var guestTitle = HotelTheme.Label("Thông tin khách", HotelTheme.Section, HotelTheme.Ink);
            var roomTitle = HotelTheme.Label("Thông tin lưu trú", HotelTheme.Section, HotelTheme.Ink);
            var guest = HotelTheme.Card(content, guestTitle, label2, txtName, label3, txtContact, label4,
                txtNationality, label5, txtGender, label6, txtDob, label7, txtAddress, label8, txtIDProof);
            var stay = HotelTheme.Card(content, roomTitle, label9, txtCheckin, label10, txtBed, label11, txtRoom,
                label12, txtRoomNo, label13, txtPrice, btnAlloteRoom);

            void Arrange()
            {
                int P(int value) => HotelTheme.Px(this, value);
                bool Wide(int width) => width >= P(1000);
                HotelTheme.FitPage(this, content, 420, width => Wide(width) ? 585 : 836);
                int gutter = Math.Max(P(28), (content.Width - P(1260)) / 2);
                int available = content.Width - gutter * 2;
                bool wide = Wide(content.Width);
                int stayWidth = wide ? Math.Min(P(400), available / 3) : available;
                int guestWidth = wide ? available - stayWidth - P(20) : available;
                int guestField = (guestWidth - P(56)) / 2;
                int stayField = wide ? stayWidth - P(40) : (stayWidth - P(56)) / 2;
                int secondGuest = P(36) + guestField;
                int secondStay = P(36) + stayField;

                label1.Location = new Point(gutter, P(24));
                guest.SetBounds(gutter, P(76), guestWidth, P(370));
                stay.SetBounds(wide ? guest.Right + P(20) : gutter,
                    wide ? P(76) : guest.Bottom + P(16), stayWidth, P(wide ? 483 : 348));
                guestTitle.Location = new Point(P(20), P(16));
                roomTitle.Location = new Point(P(20), P(16));

                HotelTheme.PlaceField(txtName, label2, P(20), P(55), guestField);
                HotelTheme.PlaceField(txtContact, label3, P(20), P(129), guestField);
                HotelTheme.PlaceField(txtNationality, label4, P(20), P(203), guestField);
                HotelTheme.PlaceField(txtIDProof, label8, secondGuest, P(55), guestField);
                HotelTheme.PlaceField(txtAddress, label7, secondGuest, P(129), guestField);
                HotelTheme.PlaceField(txtGender, label5, secondGuest, P(203), guestField);
                HotelTheme.PlaceField(txtDob, label6, P(20), P(277), guestField);

                HotelTheme.PlaceField(txtCheckin, label9, P(20), P(55), stayField);
                HotelTheme.PlaceField(txtBed, label10, wide ? P(20) : secondStay, P(wide ? 129 : 55), stayField);
                HotelTheme.PlaceField(txtRoom, label11, P(20), P(wide ? 203 : 129), stayField);
                HotelTheme.PlaceField(txtRoomNo, label12, wide ? P(20) : secondStay, P(wide ? 277 : 129), stayField);
                HotelTheme.PlaceField(txtPrice, label13, P(20), P(wide ? 351 : 203), stayField);
                btnAlloteRoom.SetBounds(wide ? P(20) : stayWidth - P(20) - stayField,
                    P(wide ? 425 : 283), stayField, P(44));
            }

            Resize += (sender, args) => Arrange();
            HandleCreated += (sender, args) => Arrange();
            Arrange();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNationality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox txtGender;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDob;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProof;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckin;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox txtBed;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoom;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomNo;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btnAlloteRoom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
