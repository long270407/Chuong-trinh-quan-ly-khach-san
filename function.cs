using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace ChuuongTrinhQuanLyKhachSan
{
    public class function
    {
        private static string GetConnectionString()
        {
            string connString = ConfigurationManager.ConnectionStrings["HotelConnection"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(connString))
            {
                connString = "Host=aws-1-ap-northeast-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.anvutdehyxkhfrhifhlf;Password=NT106.R11-Nhom4;SSL Mode=Require;Trust Server Certificate=true";
            }
            return connString;
        }

        protected NpgsqlConnection getConnection()
        {
            return new NpgsqlConnection(GetConnectionString());
        }

        public DataSet GetData(string query)
        {
            using (NpgsqlConnection con = getConnection())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public bool setData(string query, string message)
        {
            try
            {
                using (NpgsqlConnection con = getConnection())
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thao tác CSDL:\n" + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DbDataReader getForCombo(string query)
        {
            NpgsqlConnection con = getConnection();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                con.Dispose();
                throw;
            }
        }
    }
}
