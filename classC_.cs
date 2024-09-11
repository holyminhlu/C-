using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            
            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine());
           
            MyClass.phepToan(a, b);
            Console.ReadKey();
        }
    }
    class MyClass
    {
        public static void phepToan (double a, double b)
        {
            Console.WriteLine("Phep cong: {0}", a + b);
            Console.WriteLine("Phep nhan: {0}", a * b);
        }
    }
    
}
