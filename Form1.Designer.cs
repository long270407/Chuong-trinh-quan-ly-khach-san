using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ChuuongTrinhQuanLyKhachSan
{
    partial class Form1
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 24;
            this.guna2Panel1.Controls.Add(this.labelError);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Controls.Add(this.txtPassword);
            this.guna2Panel1.Controls.Add(this.txtUsername);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(406, 150);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 24;
            this.guna2Panel1.ShadowDecoration.Depth = 15;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 520);
            this.guna2Panel1.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelError.Location = new System.Drawing.Point(470, 375);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(299, 25);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "Tên đăng nhập hoặc mật khẩu sai!";
            this.labelError.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnLogin.Location = new System.Drawing.Point(470, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(460, 52);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtPassword.IconLeftSize = new System.Drawing.Size(24, 24);
            this.txtPassword.Location = new System.Drawing.Point(470, 225);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(460, 52);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.txtUsername.IconLeftSize = new System.Drawing.Size(24, 24);
            this.txtUsername.Location = new System.Drawing.Point(470, 150);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtUsername.PlaceholderText = "Tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(460, 52);
            this.txtUsername.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(462, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 12;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(50, 95);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(360, 340);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1613, 600);
            this.Controls.Add(this.guna2Panel1);
            this.MinimumSize = new System.Drawing.Size(458, 515);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Hotel — Đăng nhập";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void ConfigureLayout()
        {
            BackColor = HotelTheme.Canvas;
            guna2Panel1.FillColor = HotelTheme.Surface;
            guna2Panel1.BorderColor = HotelTheme.Line;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.ShadowDecoration.Enabled = false;

            HotelTheme.Title(label1, "Đăng nhập");
            labelError.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
            labelError.Font = HotelTheme.Body;
            labelError.ForeColor = HotelTheme.Danger;
            HotelTheme.Field(txtUsername);
            HotelTheme.Field(txtPassword);
            txtUsername.PlaceholderText = "";
            txtPassword.PlaceholderText = "";
            txtUsername.AccessibleName = "Tên đăng nhập";
            txtPassword.AccessibleName = "Mật khẩu";
            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnLogin.TabIndex = 2;
            HotelTheme.Action(btnLogin, "Đăng nhập");
            AcceptButton = btnLogin;

            var userLabel = HotelTheme.Label("Tên đăng nhập", HotelTheme.Caption, HotelTheme.Muted);
            var passwordLabel = HotelTheme.Label("Mật khẩu", HotelTheme.Caption, HotelTheme.Muted);
            var brand = HotelTheme.Label("Royal Hotel", HotelTheme.Brand, Color.White);
            var compactBrand = HotelTheme.Label("Royal Hotel", HotelTheme.Brand, HotelTheme.AccentDark);
            var brandSub = HotelTheme.Label("Quản lý khách sạn", HotelTheme.Body, HotelTheme.Gold);
            var cover = new Guna2Panel { BorderRadius = 16, FillColor = HotelTheme.Navy, BackColor = Color.Transparent };
            guna2Panel1.Controls.AddRange(new Control[] { cover, compactBrand, userLabel, passwordLabel });
            cover.Controls.AddRange(new Control[] { guna2PictureBox1, brand, brandSub });
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.BorderRadius = 0;
            guna2PictureBox1.BackColor = HotelTheme.Navy;
            using (var stream = typeof(Form1).Assembly.GetManifestResourceStream(
                "ChuuongTrinhQuanLyKhachSan.Assets.hotel-lobby.jpg"))
            using (var image = Image.FromStream(stream))
            {
                var photo = new Bitmap(image);
                guna2PictureBox1.Image = photo;
                Disposed += (sender, args) => photo.Dispose();
            }

            void Arrange()
            {
                int P(int value) => HotelTheme.Px(this, value);
                bool wide = ClientSize.Width >= P(850);
                int width = P(wide ? 812 : 404);
                int height = P(442);
                guna2Panel1.SetBounds(Math.Max(P(10), (ClientSize.Width - width) / 2),
                    Math.Max(P(10), (ClientSize.Height - height) / 2), width, height);
                cover.Visible = wide;
                compactBrand.Visible = !wide;
                cover.SetBounds(P(10), P(10), P(346), P(422));
                guna2PictureBox1.SetBounds(P(10), P(10), P(326), P(320));
                brand.Location = new Point(P(22), P(345));
                brandSub.Location = new Point(P(24), P(382));

                int left = P(wide ? 400 : 34);
                int fieldWidth = P(wide ? 362 : 336);
                compactBrand.Location = new Point(left, P(25));
                label1.Location = new Point(left, P(75));
                HotelTheme.PlaceField(txtUsername, userLabel, left, P(135), fieldWidth);
                HotelTheme.PlaceField(txtPassword, passwordLabel, left, P(215), fieldWidth);
                labelError.Location = new Point(left, P(289));
                btnLogin.SetBounds(left, P(325), fieldWidth, P(45));
            }

            Resize += (sender, args) => Arrange();
            HandleCreated += (sender, args) => Arrange();
            Arrange();
        }

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label labelError;
    }
}

