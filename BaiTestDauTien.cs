using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day la bai thuc hanh dau tien !!!");
            int x = 10;
            float y = 5.5f;
            String name = "Ho Ly Minh Lu 2004";
            double z = 14102004;
            Console.WriteLine($"{name} {z}");
            Console.WriteLine("Thong tin ne: {0} va {1}", name,z);
            Console.ReadKey();
        }
        
    }
}
