﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daySoInt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so luong phan tu: ");
            int x = int.Parse(Console.ReadLine());
            int[] mangNguyen = new int[x];

            // Khởi tạo đối tượng myInt
            myInt myIntObj = new myInt();

            myIntObj.nhapMang(mangNguyen);
            Console.WriteLine("Mang vua nhap la: ");
            myIntObj.xuatMang(mangNguyen);

            Console.WriteLine("\nTong mang vua nhap la: ");
            myIntObj.tongMang(mangNguyen);

            Console.WriteLine("\nKiem tra so nguyen to: ");
            bool ketQua = myIntObj.SoNguyenTo(mangNguyen);
            Console.WriteLine(ketQua ? "Tat ca cac so la nguyen to" : "Co so khong phai la nguyen to");

            Console.WriteLine("\nSap xep mang tang dan: ");
            myIntObj.sapXepMang(mangNguyen);

            Console.WriteLine("\nSap xep mang giam dan: ");
            myIntObj.sapXepMang2(mangNguyen);

            Console.WriteLine("\nNhap vao phan tu x can chen: ");
            int phanTu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao vi tri K can chen: ");
            int viTriChen = int.Parse(Console.ReadLine());
            mangNguyen = myIntObj.chenPhanTu(mangNguyen, phanTu, viTriChen);
            Console.WriteLine("Mang sau khi chen:");
            myIntObj.xuatMang(mangNguyen);

            Console.WriteLine("\nNhap vao vi tri K can xoa: ");
            int viTriXoa = int.Parse(Console.ReadLine());
            while (viTriXoa > mangNguyen.Length)
            {
                Console.WriteLine("Nhap lai: ");
                viTriXoa = int.Parse(Console.ReadLine());
            }
            mangNguyen = myIntObj.xoaPhanTu(mangNguyen, viTriXoa);
            Console.WriteLine("Mang sau khi xoa:");
            myIntObj.xuatMang(mangNguyen);

            Console.ReadKey();
        }
    }

    class myInt
    {
        public void nhapMang(int[] mangNguyen)
        {
            for (int i = 0; i < mangNguyen.Length; i++)
            {
                Console.Write("Nhap vao phan tu thu {0}: ", i);
                mangNguyen[i] = int.Parse(Console.ReadLine());
            }
        }

        public void xuatMang(int[] mangNguyen)
        {
            for (int i = 0; i < mangNguyen.Length; i++)
            {
                Console.Write("  {0}  ", mangNguyen[i]);
            }
        }

        public void tongMang(int[] mangNguyen)
        {
            int tong = 0;
            for (int i = 0; i < mangNguyen.Length; i++)
            {
                tong += mangNguyen[i];
            }
            Console.Write("  {0}  ", tong);
        }

        public bool SoNguyenTo(int[] mangNguyen)
        {
            for (int i = 0; i < mangNguyen.Length; i++)
            {
                int so = mangNguyen[i];
                if (so < 2)
                {
                    return false;
                }
                for (int j = 2; j <= Math.Sqrt(so); j++)
                {
                    if (so % j == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void sapXepMang(int[] mangNguyen)
        {
            for (int i = 0; i < mangNguyen.Length; i++)
            {
                for (int j = i + 1; j < mangNguyen.Length; j++)
                {
                    if (mangNguyen[i] > mangNguyen[j])
                    {
                        int tam = mangNguyen[i];
                        mangNguyen[i] = mangNguyen[j];
                        mangNguyen[j] = tam;
                    }
                }
            }
            xuatMang(mangNguyen);
        }

        public void sapXepMang2(int[] mangNguyen)
        {
            for (int i = 0; i < mangNguyen.Length; i++)
            {
                for (int j = i + 1; j < mangNguyen.Length; j++)
                {
                    if (mangNguyen[i] < mangNguyen[j])
                    {
                        int tam = mangNguyen[i];
                        mangNguyen[i] = mangNguyen[j];
                        mangNguyen[j] = tam;
                    }
                }
            }
            xuatMang(mangNguyen);
        }

        public int[] chenPhanTu(int[] mangNguyen, int x, int K)
        {
            if (K < 0 || K > mangNguyen.Length)
            {
                Console.WriteLine("Vi tri K khong hop le!");
                return mangNguyen;
            }

            int[] mangMoi = new int[mangNguyen.Length + 1];

            for (int i = 0; i < K; i++)
            {
                mangMoi[i] = mangNguyen[i];
            }

            mangMoi[K] = x; // Chèn phần tử x vào vị trí K

            for (int i = K; i < mangNguyen.Length; i++)
            {
                mangMoi[i + 1] = mangNguyen[i];
            }

            return mangMoi;
        }

        public int[] xoaPhanTu(int[] mangNguyen, int K)
        {
            if (K < 0 || K >= mangNguyen.Length)
            {
                Console.WriteLine("Vi tri K khong hop le!");
                return mangNguyen;
            }

            int[] mangMoi = new int[mangNguyen.Length - 1];

            for (int i = 0; i < K; i++)
            {
                mangMoi[i] = mangNguyen[i];
            }

            for (int i = K + 1; i < mangNguyen.Length; i++)
            {
                mangMoi[i - 1] = mangNguyen[i];
            }

            return mangMoi;
        }
    }
}