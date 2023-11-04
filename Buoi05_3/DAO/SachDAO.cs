using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_3.DAO
{
    class SachDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        private object context;
        string connectionString = "Data Source=DESKTOP-I8P24K4;Initial Catalog=QuanLyNhaSach;User ID=sa;Password=123";

        public SachDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public List<Sach> getList()
        {
            List<Sach> sachList = new List<Sach>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT s.MaSach, s.TenSach, s.TacGia, s.GiaSach,s.NamXB, l.MaLoai, nx.MaNXB, n.MaNV " +
                               "FROM Sach s " +
                               "INNER JOIN LoaiSach l ON s.MaLoai = l.MaLoai " +
                               "INNER JOIN NhaXuatBan nx ON s.MaNXB = nx.MaNXB " +
                               "INNER JOIN NhanVien n ON s.MaNV = n.MaNV";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sach sach = new Sach
                            {
                                MaSach = (int)reader["MaSach"],
                                TenSach = reader["TenSach"].ToString(),
                                TacGia = reader["TacGia"].ToString(),
                                GiaSach = Convert.ToDouble(reader["GiaSach"]),
                                NamXB = (int)reader["NamXB"],
                                MaLoai = (int)reader["MaLoai"],
                                MaNXB = (int)reader["MaNXB"],
                                MaNV = (int)reader["MaNV"]
                            };


                            sachList.Add(sach);
                        }
                    }
                }
            }

            return sachList;
        }

        public void ThemSach(Sach sach)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Sach (MaSach, TenSach, TacGia, GiaSach, MaLoai, MaNXB, NamXB, MaNV) " +
                               "VALUES (@MaSach, @TenSach, @TacGia, @GiaSach, @MaLoai, @MaNXB, @NamXB, @MaNV)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaSach", sach.TenSach);
                    cmd.Parameters.AddWithValue("@TenSach", sach.TenSach);
                    cmd.Parameters.AddWithValue("@TacGia", sach.TacGia);
                    cmd.Parameters.AddWithValue("@GiaSach", sach.GiaSach);
                    cmd.Parameters.AddWithValue("@MaLoai", sach.MaLoai);
                    cmd.Parameters.AddWithValue("@MaNXB", sach.MaNXB);
                    cmd.Parameters.AddWithValue("@NamXB", sach.NamXB);
                    cmd.Parameters.AddWithValue("@MaNV", sach.MaNV);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CapNhatSach(Sach sach)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Sach " +
                               "SET TenSach = @TenSach, TacGia = @TacGia, GiaSach = @GiaSach, " +
                               "MaLoai = @MaLoai, MaNXB = @MaNXB, NamXB = @NamXB, MaNV = @MaNV " +
                               "WHERE MaSach = @MaSach";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaSach", sach.MaSach);
                    cmd.Parameters.AddWithValue("@TenSach", sach.TenSach);
                    cmd.Parameters.AddWithValue("@TacGia", sach.TacGia);
                    cmd.Parameters.AddWithValue("@GiaSach", sach.GiaSach);
                    cmd.Parameters.AddWithValue("@MaLoai", sach.MaLoai);
                    cmd.Parameters.AddWithValue("@MaNXB", sach.MaNXB);
                    cmd.Parameters.AddWithValue("@NamXB", sach.NamXB);
                    cmd.Parameters.AddWithValue("@MaNV", sach.MaNV);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTwo(string mas)
        {
            string sql = "DELETE FROM Sach WHERE MaSach=@MaSach";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSach", mas);
            cmd.ExecuteNonQuery();
        }

    }
}

