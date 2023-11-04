using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_2.DAO
{
    class DonHangDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        string connectionString = "Data Source=DESKTOP-I8P24K4;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123";

        public DataTable getList()
        {
            conn = kn.getConnect();
            string sql = "SELECT * FROM DonHang";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }

        public void InsertTwo(DonHang dh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO DonHang(MaDH, NgayDatHang, NgayGiaoHang, KieuDonHang, GhiChu) VALUES(@MADONHANG, @NGAYDATHANG, @NGAYGIAOHANG, @KIEUDONHANG, @GHICHU)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MADONHANG", dh.MaDH);
                    cmd.Parameters.AddWithValue("@NGAYDATHANG", dh.NgayDatHang);
                    cmd.Parameters.AddWithValue("@NGAYGIAOHANG", dh.NgayGiaoHang);
                    cmd.Parameters.AddWithValue("@KIEUDONHANG", dh.KieuDonHang);
                    cmd.Parameters.AddWithValue("@GHICHU", dh.GhiChu);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateDonHang(DonHang dh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE DonHang SET NgayDatHang = @NGAYDATHANG, NgayGiaoHang = @NGAYGIAOHANG, KieuDonHang = @KIEUDONHANG, GhiChu = @GHICHU WHERE MaDH = @MADONHANG";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MADONHANG", dh.MaDH);
                    cmd.Parameters.AddWithValue("@NGAYDATHANG", dh.NgayDatHang);
                    cmd.Parameters.AddWithValue("@NGAYGIAOHANG", dh.NgayGiaoHang);
                    cmd.Parameters.AddWithValue("@KIEUDONHANG", dh.KieuDonHang);
                    cmd.Parameters.AddWithValue("@GHICHU", dh.GhiChu);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteDonHang(int maDonHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM DonHang WHERE MaDH = @MADONHANG";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MADONHANG", maDonHang);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}

