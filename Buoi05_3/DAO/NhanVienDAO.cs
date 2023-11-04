using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_3.DAO
{
    class NhanVienDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();


        string connectionString = "Data Source=DESKTOP-I8P24K4;Initial Catalog=QuanLyNhaSach;User ID=sa;Password=123";
        public DataTable getList()
        {
            conn = kn.getConnect();
            string sql = "SELECT * FROM NhanVien";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public void InsertTwo(NhanVien nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO NhanVien(MaNV, TenNhanVien, GioiTinh, DienThoai, Email) VALUES(@MANV, @TENNHANVIEN, @GIOITINH, @DIENTHOAI, @EMAIL)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MANV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@TENNHANVIEN", nv.TenNhanVien);
                    cmd.Parameters.AddWithValue("@GIOITINH", nv.GioiTinh);
                    cmd.Parameters.AddWithValue("@DIENTHOAI", nv.DienThoai);
                    cmd.Parameters.AddWithValue("@EMAIL", nv.Email);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Update(NhanVien nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE NhanVien SET TenNhanVien = @TENNHANVIEN, GioiTinh = @GIOITINH, DienThoai = @DIENTHOAI, Email = @EMAIL WHERE MaNV = @MANV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MANV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@TENNHANVIEN", nv.TenNhanVien);
                    cmd.Parameters.AddWithValue("@GIOITINH", nv.GioiTinh);
                    cmd.Parameters.AddWithValue("@DIENTHOAI", nv.DienThoai);
                    cmd.Parameters.AddWithValue("@EMAIL", nv.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteLoai(int manv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM NhanVien WHERE MaNV = @MANV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MANV", manv);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
