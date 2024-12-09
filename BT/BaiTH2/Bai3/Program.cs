using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class HinhTron
    {
        protected double r;

        public HinhTron()
        {
            this.r = 0;
        }

        public HinhTron(double x)
        {
            this.r = x;
        }
        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public void NhapBanKinh()
        {
            double x;
            Console.Write("Nhap ban kinh: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Sai du lieu. Vui long nhap lai: ");
            }
            this.r = x;
        }
        public double DienTich
        {
            get { return Math.PI * r * r; }
        }

        public double DuongKinh
        {
            get { return 2 * r; }
        }
    }

    class HinhCau : HinhTron
    {
        public HinhCau() { }
        public HinhCau(double x) : base(x) { }

        public new double DienTich
        {
            get { return 4 * Math.PI * r * r; }
        }
        public double TheTich
        {
            get { return 4 / 3 * Math.PI * r * r * r; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhCau h = new HinhCau();
            h.NhapBanKinh();
            Console.WriteLine(h.DienTich);
        }
    }
}
