using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_3.DAO
{
    class NhaXuatBanDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();

        string connectionString = "Data Source=DESKTOP-I8P24K4;Initial Catalog=QuanLyNhaSach;User ID=sa;Password=123";
        public DataTable getList()
        {
            conn = kn.getConnect();
            string sql = "SELECT * FROM NhaXuatBan";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public void InsertTwo(NhaXuatBan nxb)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO NhaXuatBan(MaNXB, TenNXB, DiaChi, DienThoai, Email) VALUES(@MANXB, @TENNXB, @DIACHI, @DIENTHOAI, @EMAIL)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MANXB", nxb.MaNXB);
                    cmd.Parameters.AddWithValue("@TENNXB", nxb.TenNXB);
                    cmd.Parameters.AddWithValue("@DIACHI", nxb.DiaChi);
                    cmd.Parameters.AddWithValue("@DIENTHOAI", nxb.DienThoai);
                    cmd.Parameters.AddWithValue("@EMAIL", nxb.Email);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Update(NhaXuatBan nxb)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE NhaXuatBan SET TenNXB = @TENNXB, DiaChi = @DIACHI, DienThoai = @DIENTHOAI, Email = @EMAIL WHERE MaNXB = @MANXB";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MANXB", nxb.MaNXB);
                    cmd.Parameters.AddWithValue("@TENNXB", nxb.TenNXB);
                    cmd.Parameters.AddWithValue("@DIACHI", nxb.DiaChi);
                    cmd.Parameters.AddWithValue("@DIENTHOAI", nxb.DienThoai);
                    cmd.Parameters.AddWithValue("@EMAIL", nxb.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteLoai(int manxb)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM NhaXuatBan WHERE MaNXB = @MANXB";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MANXB", manxb);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

