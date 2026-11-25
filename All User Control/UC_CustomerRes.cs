using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace ChuuongTrinhQuanLyKhachSan.All_User_Control
{
    public partial class UC_CustomerRes : UserControl
    {
        function fn = new function();
        string query;
        int rid;
        public UC_CustomerRes()
        {
            InitializeComponent();
            ConfigureLayout();
            this.VisibleChanged += (s, e) => { if (this.Visible) LoadRoomNumbers(); };
        }

        public void setcombobox(string query, ComboBox combo)
        {
            try
            {
                using (DbDataReader sdr = fn.getForCombo(query))
                {
                    while (sdr.Read())
                    {
                        for (int i = 0; i < sdr.FieldCount; i++)
                        {
                            if (!sdr.IsDBNull(i))
                            {
                                combo.Items.Add(sdr.GetValue(i).ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng:\n" + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UC_CustomerRes_Load(object sender, EventArgs e)
        {

        }

        private void LoadRoomNumbers()
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            rid = 0;

            if (txtBed.SelectedIndex != -1 && txtRoom.SelectedIndex != -1)
            {
                string bed = txtBed.Text.Trim();
                string roomType = txtRoom.Text.Trim();
                query = "select roomNo from rooms where trim(bed) ilike '" + bed + "' and trim(roomType) ilike '" + roomType + "' and (booked = 'NO' or booked is null or booked = '') order by roomNo";
                setcombobox(query, txtRoomNo);
            }
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomNumbers();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoomNumbers();
        }

        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomNo.Text))
            {
                rid = 0;
                txtPrice.Clear();
                return;
            }

            query = "select price, roomid from rooms where trim(roomNo::text) = '" + txtRoomNo.Text.Trim() + "'";
            DataSet ds = fn.GetData(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString(); // Lấy giá tiền gán vào txtPrice
                int.TryParse(ds.Tables[0].Rows[0][1].ToString(), out rid); // Lấy roomid lưu vào biến rid
            }
            else
            {
                rid = 0;
                txtPrice.Clear();
            }
        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtCheckin.Text != "" && txtPrice.Text != "")
            {
                if (rid <= 0 || string.IsNullOrWhiteSpace(txtRoomNo.Text))
                {
                    MessageBox.Show("Vui lòng chọn số phòng hợp lệ trước khi đăng ký!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(txtContact.Text.Trim(), out long mobile))
                {
                    MessageBox.Show("Số điện thoại liên lạc phải là số hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContact.Focus();
                    return;
                }

                String cname = txtName.Text.Trim();
                String national = txtNationality.Text.Trim();
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                String idproof = txtIDProof.Text.Trim();
                String address = txtAddress.Text.Trim();
                String checkin = txtCheckin.Text;

                // Lưu thông tin khách hàng và cập nhật phòng sang trạng thái đã đặt (booked = 'YES')
                string selectedRoomNo = txtRoomNo.Text.Trim();
                query = "insert into customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, roomid, chekout) values ('" + cname + "', " + mobile + ", '" + national + "', '" + gender + "', '" + dob + "', '" + idproof + "', '" + address + "', '" + checkin + "', " + rid + ", 'NO'); update rooms set booked = 'YES' where trim(roomNo::text) = '" + selectedRoomNo + "'";

                fn.setData(query, "Số phòng " + selectedRoomNo + " đăng ký khách hàng thành công!");
                clearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckin.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            rid = 0;
        }

        private void UC_CustomerRes_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
