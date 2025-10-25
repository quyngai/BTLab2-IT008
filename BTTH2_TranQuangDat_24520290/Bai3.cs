using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2_TranQuangDat_24520290
{
    internal class Bai3
    {
        static void Nhap(int[,] matrix , int m , int n)
        {
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void Xuat(int[,] matrix, int m, int n)
        {
            Console.WriteLine("Ma tran: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void TimKiem(int[,] matrix, int m, int n , int k)
        {
            bool found = false;
            for (int i = 0;i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] == k)
                    {
                        Console.WriteLine($"Da tim thay {k} o dong [{i},{j}]");
                        found = true;
                    }
                }
            }
            if (!found)
            { 
                Console.WriteLine($"Khong tim thay {k}");
            }
        }
        static bool SoNgTo(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }   
            }
            return true;
        }
        static void XuatSoNgTo(int[,] matrix, int m, int n)
        {
            bool found = false;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {       
                    
                    if (SoNgTo(matrix[i,j]))
                    {
                        Console.Write($"{matrix[i, j]} ");
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Khong co so nguyen to nao trong ma tran");
            }
            Console.WriteLine();
        }
        static void DongNhieuSoNgTo(int[,] matrix, int m, int n)
        {
            int Row = 0;
            int MaxCount = 0;
            for (int i = 0; i < m; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (SoNgTo(matrix[i, j]))
                    {
                        count++;
                    }
                }
                if (count > MaxCount)
                {
                    MaxCount = count;
                    Row = i;
                }
            }
            Console.WriteLine($"Dong co nhieu so nguyen to nhat {Row}");
        }
        public static void MaTran()
        {
            int m = 0;
            int n = 0;
            int[,] matrix = new int[0, 0];
            int choice;
            do
            {
                Console.WriteLine("\n=====CHUONG TRINH=====");
                Console.WriteLine("1. Nhap/Xuat ma tran");
                Console.WriteLine("2. Tim kiem phan tu trong ma tran");
                Console.WriteLine("3. Xuat cac so nguyen to");
                Console.WriteLine("4. Dong co nhieu so nguyen to nhat");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Nhap lua chon: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Write("Nhap so hang cua ma tran: ");
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap so cot cua ma tran: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        matrix = new int[m, n];
                        Nhap(matrix, m, n);
                        Xuat(matrix, m, n);
                        break;
                    case 2:
                        Console.Write("Nhap so can tim: ");
                        int k = Convert.ToInt32(Console.ReadLine());
                        TimKiem(matrix, m, n, k);
                        break;
                    case 3:
                        Console.Write("Cac so nguyen to trong ma tran: ");
                        XuatSoNgTo(matrix, m, n);
                        break;
                    case 4:
                        DongNhieuSoNgTo(matrix, m, n);
                        break;
                    case 0:
                        Console.WriteLine("Da thoat");
                        break;
                    default:
                        Console.WriteLine("Vui long nhap dung lua chon");
                        break;
                }
            } while (choice != 0);
            
        }
    }
}
