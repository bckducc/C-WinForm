using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Bai2
{
    static void Main(string[] args)
    {
        int a, b;

        do
        {
            Console.Write("Nhap so thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > 10 && b > 10)
            {
                Console.WriteLine("Vui long nhap lai\n");
            }
            else
            {
                break;
            }
        } while (true);

        Console.WriteLine("Hai so a va b la: {0} và {1}", a, b);

    }
}
