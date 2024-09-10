using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaiPTB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("CHUONG TRINH GIAI PHUONG TRINH BAC 2");
                Console.Write("Nhap vao he so a: ");
                double a = double.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.Write("Nhap lai he so a ( a ≠ 0 ): ");
                    a = double.Parse(Console.ReadLine());
                }
                Console.Write("Nhap vao he so b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Nhap vao he so c: ");
                double c = double.Parse(Console.ReadLine());
                double delta = b * b - 4 * a * c;
                if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep !!! ");
                    Console.WriteLine("X1 = X2 = {0}", (-b) / (2 * a));
                }
                else if (delta > 0)
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet !!! ");
                    Console.WriteLine("X1 = {0}", (-b + Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("X2 = {0}", (-b - Math.Sqrt(delta)) / (2 * a));
                }
                else { Console.WriteLine("Phuong trinh vo nghiem !!!"); }
            }
        }
    }
}
