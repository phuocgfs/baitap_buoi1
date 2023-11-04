using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_2.DAO

    class SanPhamDAO
{
    SqlConnection conn = null;
    SqlCommand cmd = null;
    SqlDataAdapter apt = null;
    KetNoi kn = new KetNoi();
    private object context;

    public SanPhamDAO()
    {
        conn = kn.getConnect();
        if (conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
    }

    public DataTable getList(int? maloai = null)
    {
        String sql = null;
        if (maloai == null)
        {
            sql = "select SanPham.MaSP, SanPham.TenSP, SanPham.DonViTinh, SanPham.GiaMua, SanPham.GiaBan, LoaiSP.TenLoai ";
            sql += "from SanPham inner join LoaiSP on LoaiSP.MaLoai=SanPham.MaLoai ";
        }
        else
        {
            sql = "SanPham.MaSP, SanPham.TenSP, SanPham.DonViTinh, SanPham.GiaMua, SanPham.GiaBan, LoaiSP.TenLoai ";
            sql += "from SanPham inner join LoaiSP on LoaiSP.MaLoai=SanPham.MaLoai where SanPham.MaLoai='" + maloai + "'";
        }
        cmd = new SqlCommand(sql, conn);
        apt = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        apt.Fill(dt);
        return dt;
    }
    public int getCount()
    {
        String sql = "select count(SanPham.MaSP) from SanPham inner join LoaiSP on LoaiSP.MaLoai=SanPham.MaLoai";
        cmd = new SqlCommand(sql, conn);
        int count = (int)cmd.ExecuteScalar();
        return count;
    }
    public DataRow getRow(string masp)
    {
        string sql = "select SanPham.MaSP, SanPham.TenSP, SanPham.DonViTinh, SanPham.GiaMua, SanPham.GiaBan, LoaiSP.TenLoai ";
        sql += "from SanPham inner join LoaiSP on LoaiSP.MaLoai=SanPham.MaLoai where SanPham.MaSP='" + masp + "'";
        cmd = new SqlCommand(sql, conn);
        apt = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        apt.Fill(dt);
        DataRow row = dt.Rows[0];
        return row;
    }
    public void InsertTwo(SanPham sp)
    {
        string sql = "INSERT INTO SanPham(MaSP, MaLoai, TenSP, DonViTinh, GiaMua, GiaBan) VALUES(@MASP,@MALOAI,@TENSP,@DONVITINH, @GIAMUA,@GIABAN)";
        cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MASP", sp.MaSP);
        cmd.Parameters.AddWithValue("@MALOAI", sp.MaLoai);
        cmd.Parameters.AddWithValue("@TENSP", sp.TenSP);
        cmd.Parameters.AddWithValue("@DONVITINH", sp.DonViTinh);
        cmd.Parameters.AddWithValue("@GIAMUA", sp.GiaMua);
        cmd.Parameters.AddWithValue("@GIABAN", sp.GiaBan);
        cmd.ExecuteNonQuery();

    }
    public void UpdateTwo(SanPham sp)
    {
        string sql = "UPDATE SanPham SET TenSP = @TENSP, DonViTinh=@DONVITINH, GiaMua=@GIAMUA, GiaBan=@GIABAN ";
        sql += "WHERE MaSP =@MASP AND MaLoai=@MALOAI";
        cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MASP", sp.MaSP);
        cmd.Parameters.AddWithValue("@MALOAI", sp.MaLoai);
        cmd.Parameters.AddWithValue("@TENSP", sp.TenSP);
        cmd.Parameters.AddWithValue("@DONVITINH", sp.DonViTinh);
        cmd.Parameters.AddWithValue("@GIAMUA", sp.GiaMua);
        cmd.Parameters.AddWithValue("@GIABAN", sp.GiaBan);
        cmd.ExecuteNonQuery();
    }
    public void DeleteTwo(string masp)
    {
        string sql = "DELETE FROM SanPham WHERE MaSP=@MASP";
        cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@MASP", masp);
        cmd.ExecuteNonQuery();
    }





}

}
