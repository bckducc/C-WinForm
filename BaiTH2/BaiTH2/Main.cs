using Bai1;
using System;

class KiemTra
{
    private int a, b, c;
    private int C;

    public void TamGiac()
    {
        Console.Write("Nhap canh a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap canh b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhap canh c: ");
        c = Convert.ToInt32(Console.ReadLine());

        if (a + b > c && b + c > a && a + c > b)
        {
            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Day la tam giac can");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("Day la tam giac deu");
            }
            else if (a * a + b * b == c * c || c * c + b * b == a * a || a * a + c * c == b * b)
            {
                Console.WriteLine("Day la tam giac vuong");
            }
            else if ((a * a + b * b == c * c || c * c + b * b == a * a || a * a + c * c == b * b) && a == b || b == c || a == c)
            {
                Console.WriteLine("Day la tam giac vuong can");
            }
            else
            {
                Console.WriteLine("Day la tam giac thuong");
            }
        }
        else
        {
            Console.WriteLine("3 canh khong tao thanh tam giac");
        }
    }

    public void ChuVi()
    {
        C = a + b + c;
        Console.WriteLine("Chu vi cua tam giac = {0}", C);
    }

    public void DienTich()
    {
        float p;
        p = C / 2;

        float S;
        S = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        Console.WriteLine("Dien tich cua tam giac = {0}", S);
    }
}
class Program
{
    static void Main(string[] args)
    {
        KiemTra a = new KiemTra();
        a.TamGiac();
        a.ChuVi();
        a.DienTich();
        Console.WriteLine();
    }
}