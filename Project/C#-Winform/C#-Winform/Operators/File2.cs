using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Winform.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //+
            float a = 100.25f;
            int b = 200;
            int sum = (int)a + b;

            //Console.WriteLine(sum);
            //int -> long -> float -> double

            string msg = "Hello";
            string str = msg + " " + (a + b);

            //Console.WriteLine(str);

            // /
            int x = 1, y = 2;
            int div = (int)a / b;
            //Console.WriteLine(div);

            //Console.WriteLine(x/y);

            //Console.WriteLine(a/b);

            // %
            x++;
            y--;
            Console.WriteLine("x = " + x + ", y = " + y);

            //c = 0
            int c = default;
            Console.WriteLine(c);
        }
    }
}
