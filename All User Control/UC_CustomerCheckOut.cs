using System;
using System.Data;
using System.Windows.Forms;

namespace ChuuongTrinhQuanLyKhachSan.All_User_Control
{
    public partial class UC_CustomerCheckOut : UserControl
    {
        function fn = new function();
        String query;
        int id; // Lưu cid của khách hàng khi click chọn trên bảng
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
            ConfigureLayout();
            this.VisibleChanged += (s, e) => { if (this.Visible) UC_CustomerCheckOut_Load(this, null); };
        }

        public void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where (chekout = 'NO' or chekout is null or chekout = '') order by customer.cid desc";
                DataSet ds = fn.GetData(query);
                if (ds != null && ds.Tables.Count > 0)
                {
                    guna2DataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách khách hàng cần trả phòng:\n" + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where customer.cname ilike '%" + txtName.Text.Trim() + "%' and (chekout = 'NO' or chekout is null or chekout = '') order by customer.cid desc";
                DataSet ds = fn.GetData(query);
                if (ds != null && ds.Tables.Count > 0)
                {
                    guna2DataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm khách hàng:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                int.TryParse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out id); 
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? ""; 
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value?.ToString() ?? "";
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "" && id > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update customer set chekout = 'YES', checkout = '" + cdate + "' where cid = " + id + "; update rooms set booked = 'NO' where trim(roomNo::text) = '" + txtRoom.Text.Trim() + "'";
                    fn.setData(query, "Thanh toán thành công!");
                    UC_CustomerCheckOut_Load(this, null); 
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Không có khách hàng để lựa chọn!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
            id = 0;
        }

        private void UC_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
