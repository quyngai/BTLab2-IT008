using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2_TranQuangDat_24520290
{
    internal class Bai4
    {
        static void Tinh2PS(PhanSo p1 , PhanSo p2)
        {
            Console.WriteLine($"Tong 2 phan so: {p1 + p2}");
            Console.WriteLine($"Hieu 2 phan so: {p1 - p2}");
            Console.WriteLine($"Tich 2 phan so: {p1 * p2}");
            Console.WriteLine($"Thuong 2 phan so: {p1 / p2}");
        }
        static void TimPSMax(PhanSo[] dps , int n)
        {
            PhanSo MaxFrag = dps[0];
            for (int i = 0; i < n; i++)
            {
                if (dps[i].CompareTo(MaxFrag) > 0)
                {
                    MaxFrag = dps[i];
                }
            }
            Console.WriteLine($"Phan so lon nhat la: {MaxFrag}");
        }
        public static void PS()
        {
            int choice;
            do
            {
                Console.WriteLine("\n=====CHUONG TRINH=====");
                Console.WriteLine("1.Tinh toan tu voi 2 phan so");
                Console.WriteLine("2.Day cac phan so");
                Console.WriteLine("0.Thoat");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Nhap phan so thu 1:");
                        PhanSo p1 = PhanSo.NhapPhanSo();
                        Console.WriteLine("Nhap phan so thu 2:");
                        PhanSo p2 = PhanSo.NhapPhanSo();
                        Tinh2PS(p1, p2);
                        break;
                    case 2:
                        int arrchoice;
                        Console.WriteLine("Nhap so phan so co trong mang");
                        int n = Convert.ToInt32(Console.ReadLine());
                        PhanSo[] DayPhanSo = new PhanSo[n];
                        for (int i = 0; i < n; i++)
                        {
                            DayPhanSo[i] = PhanSo.NhapPhanSo();
                        }
                        do
                        {
                            Console.WriteLine("\n===DAY PHAN SO===");
                            Console.WriteLine("1.Xuat day phan so");
                            Console.WriteLine("2.Tim phan so lon nhat");
                            Console.WriteLine("3.Sap xep tang dan");
                            Console.WriteLine("0.Thoat");
                            arrchoice = Convert.ToInt32(Console.ReadLine());
                            switch (arrchoice)
                            {
                                case 1:
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.Write(DayPhanSo[i] + " ");
                                    }
                                    Console.WriteLine();
                                    break;
                                case 2:
                                    TimPSMax(DayPhanSo, n);
                                    break;
                                case 3:
                                    Array.Sort(DayPhanSo);
                                    Console.WriteLine("Day phan so vua sap xep tang dan la");
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.Write(DayPhanSo[i] + " ");
                                    }
                                    Console.WriteLine();
                                    break;
                                case 0:
                                    Console.WriteLine("Da thoat");
                                    break;
                                default:
                                    Console.WriteLine("Vui long nhap dung lua chon");
                                    break;
                            }
                        } while (arrchoice != 0);
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
