using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bai4()
{
    static void Main(string[] args)
    {
        Console.Write("Nhap 1 xau ky tu: ");
        string Xau = Console.ReadLine();

        string reverse = Reverse(Xau);

        Console.WriteLine("Xau sau khi dao nguoc: " + reverse);
    }

    static string Reverse(string c)
    {
        char[] charArray = c.ToCharArray();
        Array.Reverse(charArray);
        return new string (charArray);
    }
}