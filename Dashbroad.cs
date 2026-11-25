using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ChuuongTrinhQuanLyKhachSan
{
    public partial class Dashbroad : Form
    {
        public Dashbroad()
        {
            InitializeComponent();
            ConfigureLayout();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void Dashbroad_Load(object sender, EventArgs e)
        {
            ShowPage(btnAddRoom, uC_AddRoom1);
        }

        private void ShowPage(Guna2Button selected, UserControl page)
        {
            foreach (Guna2Button button in navigation)
                button.Checked = button == selected;

            foreach (Control view in panel2.Controls)
            {
                if (view != page)
                    view.Hide();
            }

            page.Show();
            page.BringToFront();
            page.PerformLayout();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            ShowPage(btnAddRoom, uC_AddRoom1);
        }

        private void btnCustomerRes_Click(object sender, EventArgs e)
        {
            ShowPage(btnCustomerRes, uC_CustomerRes1);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            ShowPage(btnCheckOut, uC_CustomerCheckOut1);
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            ShowPage(btnCustomerDetail, uC_CustomerDetails1);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ShowPage(btnEmployee, uC_Employee1);
        }


    }
}
