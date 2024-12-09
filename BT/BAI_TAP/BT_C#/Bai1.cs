using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH1
{
    class Bai1()
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.Write("Nhap A = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap B = ");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nhap C = ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap D = ");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A*B*C*D = " + a * b * c * d);
        }
    }
}