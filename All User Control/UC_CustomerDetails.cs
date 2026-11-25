using System;
using System.Data;
using System.Windows.Forms;

namespace ChuuongTrinhQuanLyKhachSan.All_User_Control
{
    public partial class UC_CustomerDetails : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerDetails()
        {
            InitializeComponent();
            ConfigureLayout();
            this.VisibleChanged += (s, e) => { if (this.Visible) txtSearchBy_SelectedIndexChanged(this, null); };
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price, customer.checkout from customer inner join rooms on customer.roomid = rooms.roomid order by customer.cid desc";
                getRecord(query);
            } 
            else if(txtSearchBy.SelectedIndex == 1)
            {
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where (chekout = 'NO' or chekout is null or chekout = '') order by customer.cid desc";
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price, customer.checkout from customer inner join rooms on customer.roomid = rooms.roomid where chekout = 'YES' order by customer.cid desc";
                getRecord(query);
            }
        }
        private void getRecord(string query)
        {
            try
            {
                DataSet ds = fn.GetData(query);
                if (ds != null && ds.Tables.Count > 0)
                {
                    guna2DataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách chi tiết khách hàng:\n" + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UC_CustomerDetails_Load(object sender, EventArgs e)
        {
            txtSearchBy.SelectedIndex = 0;
        }
    }
}
