using BTTH2_TranQuangDat_24520290;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BTTH2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n==== MENU ====");
                Console.WriteLine("1.In lich thang");
                Console.WriteLine("2.Xuat ten trong duong dan");
                Console.WriteLine("3.Chuong trinh ma tran");
                Console.WriteLine("4.Chuong trinh phan so");
                Console.WriteLine("5.Quan ly bat dong san");
                Console.WriteLine("0.Thoat chuong trinh");
                Console.Write("Nhap lua chon: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Bai1.InLich();
                        break;
                    case 2:
                        Bai2.DuongDan();
                        break;
                    case 3:
                        Bai3.MaTran();
                        break;
                    case 4:
                        Bai4.PS();
                        break;
                    case 5:
                        Bai5.QuanLy();
                        break;
                    case 0:
                        Console.WriteLine("Da thoat");
                        break;
                    default:
                        Console.WriteLine("Vui long nhap dung lua chon.");
                        break;
                }
            } while (choice != 0);
        }
    }
} 