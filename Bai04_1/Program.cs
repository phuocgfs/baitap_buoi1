using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap canh a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap canh b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Nhap canh c: ");
        int c = int.Parse(Console.ReadLine());

        if (tangiac(a, b, c))
        {
            double chuVi = ChuVi(a, b, c);
            double dienTich = DienTich(a, b, c);

            Console.WriteLine("Day la tam giac.");
            Console.WriteLine("Chu vi tam giac: " + chuVi);
            Console.WriteLine("Dien tich tam giac: " + dienTich);
        }
        else
        {
            Console.WriteLine("Khong phai 3 canh cua 1 tam giac.");
        }
        Console.ReadKey();

    }

    static bool tangiac(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static double ChuVi(int a, int b, int c)
    {
        return a + b + c;
    }

    static double DienTich(int a, int b, int c)
    {
        double p = ChuVi(a, b, c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

    }

}

