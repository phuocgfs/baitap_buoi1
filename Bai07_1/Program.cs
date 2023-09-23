using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07_1
{
    using System;

    class Program
    {
        static bool DemNT(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("So n phai la so nguyen duong.");
                return;
            }

            Console.WriteLine("Cac so nguyen to tu 1 den " + n + " la:");
            for (int i = 1; i <= n; i++)
            {
                if (DemNT(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
             Console.ReadKey();
        }
    }
}
