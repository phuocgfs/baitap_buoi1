using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int Tong = tongso(2 * n - 1);
        Console.WriteLine("Tong cac so le tu 1 den {0} là: {1}", 2 * n - 1, Tong);
        Console.ReadKey();


    }

    static int tongso(int max)
    {
        int sum = 0;

        for (int i = 1; i <= max; i += 2)
        {
            sum += i;
        }

        return sum;
    }
}

