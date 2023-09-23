using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int soSinhVien = int.Parse(Console.ReadLine());

            string[] danhsachsinhvien = NhapSV(soSinhVien);

            Console.WriteLine("Danh sach sinh vien:");
            XuatSV(danhsachsinhvien, soSinhVien);

            Console.ReadKey();
        }

        static string[] NhapSV(int n)
        {
            string[] danhsachsinhvien = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap ho ten sinh vien {i + 1}: ");
                danhsachsinhvien[i] = Console.ReadLine();
            }

            return danhsachsinhvien;
        }

        static void XuatSV(string[] danhsachsinhvien, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. {danhsachsinhvien[i]}");
            }
        }
    }
}




