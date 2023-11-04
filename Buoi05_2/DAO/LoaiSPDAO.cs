using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_2.DAO
{
    class LoaiSPDAO
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        string connectionString = "Data Source=DESKTOP-I8P24K4;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123";

        public DataTable getList()
        {
            conn = kn.getConnect();
            string sql = "SELECT * FROM LoaiSP";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public void InsertTwo(LoaiSP sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO LoaiSP(MaLoai, TenLoai, ChiTiet) VALUES(@MALOAI, @TENLOAI, @CHITIET)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOAI", sp.MaLoai);
                    cmd.Parameters.AddWithValue("@TENLOAI", sp.TenLoai);
                    cmd.Parameters.AddWithValue("@CHITIET", sp.ChiTiet);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateLoaiSP(LoaiSP sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE LoaiSP SET TenLoai = @TENLOAI, ChiTiet = @CHITIET WHERE MaLoai = @MALOAI";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOAI", sp.MaLoai);
                    cmd.Parameters.AddWithValue("@TENLOAI", sp.TenLoai);
                    cmd.Parameters.AddWithValue("@CHITIET", sp.ChiTiet);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteLoaiSP(int maLoai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM LoaiSP WHERE MaLoai = @MALOAI";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOAI", maLoai);

                    cmd.ExecuteNonQuery();
                }
            }
        }




    }
}

