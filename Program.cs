using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamGiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Nhap canh a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh b: ");
            b = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Nhap canh c: ");
            c = double.Parse(Console.ReadLine());
            myTamGiac.ktraTamGiac(a, b, c);
            Console.ReadLine();
        }
    }

    class myTamGiac
    {
        public static void ktraTamGiac(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if (b == a && a == c)
                {
                    Console.WriteLine("Tam giac la tam giac deu !");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Tam giac la tam giac can !");
                }
                else if ( a>b && a>c )
                {
                    if ( Math.Pow(a,2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
                    {
                        Console.WriteLine("Tam giac la tam giac vuong, canh a la canh huyen");
                    }
                }
                else if (b > c && b > a)
                {
                    if (Math.Pow(b, 2) == (Math.Pow(a, 2) + Math.Pow(c, 2)))
                    {
                        Console.WriteLine("Tam giac la tam giac vuong, canh b la canh huyen");
                    }
                }
                else if (c > b && c > a)
                {
                    if (Math.Pow(c, 2) == (Math.Pow(b, 2) + Math.Pow(a, 2)))
                    {
                        Console.WriteLine("Tam giac la tam giac vuong, canh c la canh huyen");
                    }
                }
                else if (((b > c && b > a) && a == c) || ((a > c && a > b) && b == c) || ((c > b && c > a) && b == a))
                {                   
                        Console.WriteLine("Tam giac la tam giac vuong can ");
                }
                else
                {
                    Console.WriteLine("Tam giac la tam giac binh thuong ");
                }
            }
            else
            {
                Console.WriteLine("Khong the tao thanh tam giac !!!");
            }
        }
    }
}
