using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BAI_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so nguyen");
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            string chuoi = "";
            while (i <= 10)
            {
                chuoi += $@"{a} x {i} = {a * i} ; ";
                i += 1;
            }
            
            

            Console.WriteLine("result: {0}",chuoi);
            Console.ReadKey();
        }
    }
}