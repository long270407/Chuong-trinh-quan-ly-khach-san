using System;
using System.Data;
using System.Windows.Forms;

namespace ChuuongTrinhQuanLyKhachSan.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
            ConfigureLayout();
            this.VisibleChanged += (s, e) => { if (this.Visible) UC_AddRoom_Load(this, null); };
        }

        public void UC_AddRoom_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select * from rooms order by roomid desc";
                DataSet ds = fn.GetData(query);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách phòng:\n" + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                if (!long.TryParse(txtPrice.Text.Trim(), out long price) || price < 0)
                {
                    MessageBox.Show("Giá phòng phải là một số nguyên dương hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                    return;
                }

                string roomno = txtRoomNo.Text.Trim();
                string type = txtRoomType.Text;
                string bed = txtBed.Text;

                query = "insert into rooms (roomNo, roomType, bed, price, booked) values ('" + roomno + "','" + type + "','" + bed + "'," + price + ",'NO')";
                fn.setData(query, "Đã thêm phòng thành công!");

                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }
        public void clearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
