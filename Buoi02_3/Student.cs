using Buoi02_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Student : Person
    {
        public string MaSV { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }

        public Student() { }

        public Student(string masv, double diemtb, string khoa, string cnmd, string hoten, string diachi)
        {
            MaSV = masv;
            DiemTB = diemtb;
            Khoa = khoa;
            CNMD = cnmd;
            HoTen = hoten;
            DiaChi = diachi;
        }

        public Student(Student sv)
        {
            MaSV = sv.MaSV;
            DiemTB = sv.DiemTB;
            Khoa = sv.Khoa;
            CNMD = sv.CNMD;
            HoTen = sv.HoTen;
            DiaChi = sv.DiaChi;
        }

        public void NhapSV()
        {
            Console.Write("Nhap Masv= ");
            MaSV = Console.ReadLine();

            Console.Write("Nhap CNMD= ");
            CNMD = Console.ReadLine();

            Console.Write("Nhap hoten= ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap dia chi= ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhap Diem= ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Khoa= ");
            Khoa = Console.ReadLine();
        }

        public void XuatSV()
        {
            Console.WriteLine("MaSV={0}, CNMD={1}, HoTen={2}, DiaChi={3}, DiemTB={4}, Khoa={5}", MaSV, CNMD, HoTen, DiaChi, DiemTB, this.Khoa);
        }

    }
}
