using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static bool checkNamNhuan(int nam)
        {
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
        }
        static int songaytrongthang(int thang, int nam)
        {
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return checkNamNhuan(nam) ? 29 : 28;
                default:
                    return -1;
            }
        }

        static void Main(string[] args)
        {
            int thang, nam, songay;
            Console.Write("Nhap thang: ");
            thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            nam = Convert.ToInt32(Console.ReadLine());
            songay = songaytrongthang(thang, nam);

            if (songay == -1)
            {
                Console.WriteLine("Thang k hop le!");
            }
            else
            {
                Console.WriteLine("So ngay trong thang {0}/{1} là: {2}", thang, nam, songay);
            }

            Console.ReadKey();
        }
    }
}
