using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_2
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }

        public SinhVien() { }

        public SinhVien(string masv, string hoten, double diemtb, string khoa)
        {
            MaSV = masv;
            HoTen = hoten;
            DiemTB = diemtb;
            Khoa = khoa;
        }

        public SinhVien(SinhVien sv)
        {
            MaSV = sv.MaSV;
            HoTen = sv.HoTen;
            DiemTB = sv.DiemTB;
            Khoa = sv.Khoa;
        }

        public void NhapSV()
        {
            Console.Write("Nhap Masv: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap hoten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Diem: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }

        public void XuatSV()
        {
            Console.WriteLine("MaSV={0}, HoTen={1}, DiemTB={2}, Khoa={3}", MaSV, HoTen, DiemTB, this.Khoa);
        }

    }
}
