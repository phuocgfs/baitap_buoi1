using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_3.DAO
{
    class LoaiSachDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        string connectionString = "Data Source=DESKTOP-I8P24K4;Initial Catalog=QuanLyNhaSach;User ID=sa;Password=123";

        public DataTable getList()
        {
            conn = kn.getConnect();
            string sql = "SELECT * FROM LoaiSach";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public void InsertTwo(LoaiSach ls)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO LoaiSach(MaLoai, TenLoai) VALUES(@MALOAI, @TENLOAI)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOAI", ls.MaLoai);
                    cmd.Parameters.AddWithValue("@TENLOAI", ls.TenLoai);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateLoai(LoaiSach ls)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE LoaiSach SET TenLoai = @TENLOAI WHERE MaLoai = @MALOAI";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOAI", ls.MaLoai);
                    cmd.Parameters.AddWithValue("@TENLOAI", ls.TenLoai);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteLoai(int maLoai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM LoaiSach WHERE MaLoai = @MALOAI";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOAI", maLoai);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

