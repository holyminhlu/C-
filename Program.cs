using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xepLoaiHS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten sinh vien: ");
            String name = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            double toan = double.Parse( Console.ReadLine() );
            Console.Write("Nhap diem ly: ");
            double ly = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            double hoa = double.Parse(Console.ReadLine());

            double dienTb = 0;
            dienTb = (toan + ly + hoa) / 3;
            if (dienTb > 9) { Console.WriteLine("Sinh vien xep loai Xuat sac"); }
                else if (dienTb > 7.5) { Console.WriteLine("Sinh vien xep loai Gioi"); }
                    else if (dienTb > 6) { Console.WriteLine("Sinh vien xep loai Kha"); }
                        else if (dienTb > 4) { Console.WriteLine("Sinh vien xep loai Trung binh"); }
                            else { Console.WriteLine("Sinh vien xep loai Yeu"); }
            Console.ReadKey();
        }
    }
}
