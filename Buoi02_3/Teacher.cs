using Buoi02_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Teacher : Person
    {
        public string MaGV { get; set; }
        public string Khoa { get; set; }
        public string ChucVu { get; set; }

        // Hàm nhập danh sách giáo viên
        public Teacher() { }

        public Teacher(string magv, string khoa, string chucvu, string cnmd, string hoten, string diachi)
        {
            MaGV = magv;
            CNMD = cnmd;
            HoTen = hoten;
            DiaChi = diachi;
            Khoa = khoa;
            ChucVu = chucvu;

        }

        public Teacher(Teacher gv)
        {
            MaGV = gv.MaGV;
            CNMD = gv.CNMD;
            HoTen = gv.HoTen;
            DiaChi = gv.DiaChi;
            Khoa = gv.Khoa;
            ChucVu = gv.ChucVu;
        }

        public void NhapGV()
        {
            Console.Write("\nNhap Magv: ");
            MaGV = Console.ReadLine();

            Console.Write("Nhap CNMD: ");
            CNMD = Console.ReadLine();

            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap Dia Chi: ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();

            Console.Write("Nhap Chuc Vu: ");
            ChucVu = Console.ReadLine();
        }

        public void XuatGV()
        {
            Console.WriteLine("MaGV={0}, CNMD={1}, HoTen={2}, DiaChi={3}, Khoa={4}, ChucVu={5}", MaGV, CNMD, HoTen, DiaChi, this.Khoa, ChucVu);
        }
    }
}
