using Buoi02_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_2
{

    internal class Program
    {
        private static List<SinhVien> NhapDSSinhVien()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.WriteLine("\nNhap Tong Sach Sinh Vien");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ====Nhap danh sach sinh vien======");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap Sinh Vien Thu {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;
        }

        private static void XuatDSSinhVien(List<SinhVien> listSinhVien)
        {
            Console.WriteLine("\n ====Xuat Danh Sach Sinh Vien===");
            foreach (SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }
        }

        //Xuất ra thông tin của các sinh viên thuộc khoa "CNTT" (nếu có).
        private static void DSSVCNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT1 = (from s in listSinhVien where s.Khoa == "CNTT" select s).ToList();
            //xuat tt
            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien trong khoa");
            }
            else
            {

                XuatDSSinhVien(listCNTT1);
            }


        }

        private static void DSSVLONHON5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("\n Khong co sinh vien co diem >= 5");
            }
            else
            {
                XuatDSSinhVien(listSV);
            }
        }

        private static void DSSVSAPSEP(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            XuatDSSinhVien(listSV);
        }
        private static void DSSVLONHON5VAKHOA(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5 && p.Khoa == "CNTT").ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("\n Khong co sinh vien co diem >= 5");
            }
            else
            {
                XuatDSSinhVien(listSV);
            }
        }

        private static void DSSVDIEMCAONHATVAKHOA(List<SinhVien> listSinhVien)
        {
            var sinhVienCNTT = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();

            if (sinhVienCNTT.Count() == 0)
            {
                Console.WriteLine("\n Khong co sinh vien thuoc khoa CNTT");
            }
            else
            {
                double diemMax = sinhVienCNTT.Max(sv => sv.DiemTB);
                var sinhVienDiemCaoNhat = sinhVienCNTT.Where(sv => sv.DiemTB == diemMax).ToList();

                if (sinhVienDiemCaoNhat.Count() == 0)
                {
                    Console.WriteLine("\n Khong co sinh vien co diem trung binh cao nhat trong khoa CNTT");
                }
                else
                {
                    XuatDSSinhVien(sinhVienDiemCaoNhat);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<SinhVien> listSinhVien = NhapDSSinhVien();
            XuatDSSinhVien(listSinhVien);

            DSSVCNTT(listSinhVien);

            DSSVLONHON5(listSinhVien);

            DSSVSAPSEP(listSinhVien);

            DSSVLONHON5VAKHOA(listSinhVien);

            DSSVDIEMCAONHATVAKHOA(listSinhVien);

            Console.ReadKey();
        }
    }
}
