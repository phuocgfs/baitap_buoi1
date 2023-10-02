using Buoi02_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_3
{
    internal class Program
    {
        private static List<Student> NhapDSSinhVien()
        {
            List<Student> listSinhVien = new List<Student>();
            Console.WriteLine("Nhap Tong Sach Sinh Vien: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ====Nhap danh sach sinh vien======");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap Sinh Vien Thu {0}: \n", i + 1);
                Student sv = new Student();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;
        }

        private static void XuatDSSinhVien(List<Student> listSinhVien)
        {
            Console.WriteLine("\n ====Xuat Danh Sach Sinh Vien===");
            foreach (Student sv in listSinhVien)
            {
                sv.XuatSV();
            }
        }

        //Xuất ra thông tin của các sinh viên thuộc khoa "CNTT" (nếu có).
        private static void DSSVCNTT(List<Student> listSinhVien)
        {
            List<Student> listCNTT1 = (from s in listSinhVien where s.Khoa == "CNTT" select s).ToList();
            //xuat tt
            Console.WriteLine("\n ====Xuat Danh Sach SV KHOA CNTT===");
            if (listCNTT1.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien trong khoa");
            }
            else
            {
                Console.WriteLine("danh sach sinh vien trong khoa cntt");
                XuatDSSinhVien(listCNTT1);
            }


        }

        private static void DSSVLONHON5(List<Student> listSinhVien)
        {
            List<Student> listSV = listSinhVien.Where(p => p.DiemTB > 5 && p.Khoa == "CNTT").ToList();
            if (listSV.Count() == 0)
            {
                Console.WriteLine("\n Khong co sinh vien co diem >= 5");
            }
            else
            {
                Console.WriteLine("\n danh sach sinh vien co diem >= 5");
                XuatDSSinhVien(listSV);
            }
        }
        private static void DSSVCNTTDTTBMAX(List<Student> listSinhVien)
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
        private static List<Teacher> NhapDSGiaoVien()
        {
            List<Teacher> listGiaoVien = new List<Teacher>();
            Console.WriteLine("Nhap Tong Sach Giao Vien: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ====Nhap danh sach Giao vien======");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap Giao Vien Thu {0}: \n", i + 1);
                Teacher gv = new Teacher();
                gv.NhapGV();
                listGiaoVien.Add(gv);
            }
            return listGiaoVien;
        }

        private static void XuatDSGiaoVien(List<Teacher> listGiaoVien)
        {
            Console.WriteLine("\n ====Xuat Danh Sach Giao Vien===");
            foreach (Teacher sv in listGiaoVien)
            {
                sv.XuatGV();
            }
        }

        private static void DSSVGVQUAN9(List<Teacher> listGiaoVien)
        {
            List<Teacher> listDIACHI1 = listGiaoVien.Where(p => p.DiaChi.Contains("Quận 9")).ToList();
            //xuat tt

            if (listDIACHI1.Count() == 0)
            {
                Console.WriteLine("Khong co giao vien quan 9");
            }
            else
            {
                Console.WriteLine("\n======Danh sach giao vien quan 9 la====");
                XuatDSGiaoVien(listDIACHI1);
            }


        }

        private static void DSSVGVCOMA(List<Teacher> listGiaoVien)
        {
            Console.WriteLine("Nhap ma giao vien can tim: ");
            string maGVtimthay = Console.ReadLine();

            List<Teacher> listCOMAGV = listGiaoVien.Where(p => p.MaGV == maGVtimthay).ToList();
            //xuat tt

            if (listCOMAGV.Count() == 0)
            {
                Console.WriteLine("Khong co giao vien co ma la CHN060286");
            }
            else
            {
                Console.WriteLine("\n======Danh sach giao vien co ma la CHN060286====");
                XuatDSGiaoVien(listCOMAGV);
            }


        }




        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Student> listSinhVien = NhapDSSinhVien();
            XuatDSSinhVien(listSinhVien);
            //2.	Tìm kiếm danh sách các sinh viên thuộc khoa “CNTT” nếu có.
            //DSSVCNTT(listSinhVien);
            //3.	Xuất ra danh sách tất cả sinh viên có điểm trung bình <5 và thuộc khoa “CNTT”
            //DSSVLONHON5(listSinhVien);
            //6.	Tìm danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa "CNTT"
            DSSVCNTTDTTBMAX(listSinhVien);


            List<Teacher> listGiaoVien = NhapDSGiaoVien();

            XuatDSGiaoVien(listGiaoVien);
            //4.	Xuất ra danh sách giáo viên có địa chỉ chứa thông tin "Quận 9" nếu có
            DSSVGVQUAN9(listGiaoVien);
            //5.	Tìm kiếm giáo viên có mã giảng viên là CHN060286. Xuất ra thông tin giáo viên tìm được nếu có.
            DSSVGVCOMA(listGiaoVien);

            //6.Tìm danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa "CNTT"



            Console.ReadKey();

        }
    }
}
