using Buoi02_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    Console.Write("Nhap n=");
            //    int n= Convert.ToInt32(Console.ReadLine());
            //    SinhVien[] arrSinhVien = new SinhVien[n];
            //    for(int i = 0; i < n; i++)
            //    {
            //        arrSinhVien[i] = new SinhVien();
            //        arrSinhVien[i].NhapSV();

            //    }
            //    foreach(SinhVien sv in arrSinhVien) {
            //        sv.XuatSV();
            //    }


            //    List<SinhVien> ListSinhVien = new List<SinhVien>();

            //    SinhVien sv1 = new SinhVien("211111", "An", 9, "cntt");
            //    ListSinhVien.Add(sv1);
            //    SinhVien sv2 = new SinhVien("211111", "An", 9, "cntt");
            //    ListSinhVien.Add(sv2);
            //    SinhVien sv3 = new SinhVien("211111", "An", 9, "cntt");
            //    ListSinhVien.Add(sv3);
            //    SinhVien sv4 = new SinhVien("211111", "An", 9, "cntt");
            //    ListSinhVien.Add(sv4);
            //    SinhVien sv5 = new SinhVien("211111", "An", 9, "cntt");
            //    ListSinhVien.Add(sv5);

            //    for (int i = 0; i < n; i++)
            //    {
            //        SinhVien sv = new SinhVien();
            //        sv.NhapSV();
            //        ListSinhVien.Add(sv);
            //    }

            //    List<SinhVien> svCNTT = ListSinhVien.Where(m=>)
            //    foreach(SinhVien sv in  ListSinhVien)
            //    {
            //        sv.XuatSV();

            //    }
            //    Console.ReadLine();




            //De su dung tieng viet
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhap tong so sinh vien N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.WriteLine("\nNhap Danh Sach Sinh Vien");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap Sinh Vien Thu {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            Console.WriteLine("\n ====Xuat Danh Sach Sinh Vien======");
            foreach (SinhVien sv in listSinhVien)
            {
                sv.XuatSV();

            }
            Console.ReadLine();
        }
    }
}
