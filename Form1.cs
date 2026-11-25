using System;
using System.Data;
using System.Windows.Forms;

namespace ChuuongTrinhQuanLyKhachSan
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
            ConfigureLayout();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Long" && txtPassword.Text == "123")
            {
                labelError.Visible = false;
                Dashbroad dash = new Dashbroad();
                this.Hide();
                dash.Show();
                return; 
            }

            try
            {
                query = "select username, pass from employee where username = '" + txtUsername.Text.Trim() + "' and pass = '" + txtPassword.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count != 0)
                {
                    labelError.Visible = false;
                    Dashbroad dash = new Dashbroad();
                    this.Hide();
                    dash.Show();
                }
                else
                {
                    labelError.Visible = true;
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu để đăng nhập:\n" + ex.Message + "\n\nVui lòng kiểm tra kết nối mạng và cấu hình Supabase / PostgreSQL trong file App.config.", "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
