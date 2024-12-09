namespace OOP_C_
{
    public class Phanso
    {
        int tuso, mauso;
        public void Nhap()
        {
            Console.WriteLine("Tu so =  ");
            tuso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mau so = ");
            mauso = Convert.ToInt32(Console.ReadLine());
        }

        public void XUat()
        {
            Console.WriteLine("Tu so = {0}", tuso);
            tuso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mau so = {0}", mauso);
            mauso = Convert.ToInt32(Console.ReadLine());
        }

        public static Phanso operator +(Phanso a, Phanso b)
        {
            Phanso kq = new Phanso();
            kq.tuso = a.tuso * b.mauso + b.tuso * a.mauso;
            kq.mauso = a.mauso * b.tuso + a.tuso * b.mauso;
            return kq;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Phanso A = new Phanso();
            A.Nhap();
            A.XUat();
            Phanso B = new Phanso();
            B.XUat();
            Console.ReadLine();
        }
    }
}

