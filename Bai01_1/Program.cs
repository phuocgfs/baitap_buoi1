﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, tong, hieu, tich;
            double thuong = 0;
            Console.WriteLine("Nhap so a: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            b= Int32.Parse(Console.ReadLine());
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            if(b!=0)
            {
                thuong = (double)a / b;
            }
            //Xuat
            Console.WriteLine("Tong= " + tong);
            Console.WriteLine("Hieu ={0}", hieu);
            Console.WriteLine("Tich = {0}, Thuong={1}", tich, thuong);
            //Dung ma hinh
            Console.ReadKey();
            }
        }
    }

