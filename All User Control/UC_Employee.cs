using System;
using System.Data;
using System.Windows.Forms;

namespace ChuuongTrinhQuanLyKhachSan.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
            ConfigureLayout();
            tabControl1.SelectedIndexChanged += tabEmployee_SelectedIndexChanged;
            this.VisibleChanged += (s, e) => { if (this.Visible) { getMaxID(); tabEmployee_SelectedIndexChanged(this, null); } };
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        // *********************
        public void getMaxID()
        {
            try
            {
                query = "select max(eid) from employee";
                DataSet ds = fn.GetData(query);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value && !string.IsNullOrEmpty(ds.Tables[0].Rows[0][0].ToString()))
                {
                    Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    labelToSET.Text = (num + 1).ToString();
                }
                else
                {
                    labelToSET.Text = "1";
                }
            }
            catch
            {
                labelToSET.Text = "1";
            }
        }

        private void btnRegistation_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                if (!long.TryParse(txtMobile.Text.Trim(), out long mobile))
                {
                    MessageBox.Show("Số điện thoại nhân viên phải là số hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMobile.Focus();
                    return;
                }

                String name = txtName.Text.Trim();
                String gender = txtGender.Text;
                string email = txtEmail.Text.Trim();
                String username = txtUserName.Text.Trim();
                String pass = txtPassword.Text;
                query = "insert into employee (ename, mobile, gender, emailid, username, pass) values ('" + name + "', " + mobile + ", '" + gender + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Đăng Ký Nhân Viên Thành Công!");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin nhân viên!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
        }

        public void setEmployee(DataGridView dgv)
        {
            try
            {
                query = "select * from employee order by eid desc";
                DataSet ds = fn.GetData(query);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dgv.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách nhân viên:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (!int.TryParse(txtID.Text.Trim(), out int eid))
                {
                    MessageBox.Show("Mã nhân viên (ID) phải là số nguyên hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + eid;
                    fn.setData(query, "Đã Xóa Thành Công!");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ID nhân viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView3);
            }
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
