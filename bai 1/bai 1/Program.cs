﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BAI_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so nguyen");
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("congrat");
            }
            else
            {
                Console.WriteLine("rip");
            }



            Console.ReadKey();
        }
    }
}