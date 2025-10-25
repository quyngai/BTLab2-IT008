using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2_TranQuangDat_24520290
{
    public class Bai1
    {
        static bool Namnhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            {
                return true;
            }
            return false;
        }
        static int Ngaytrongthang(int thang, int nam)
        {
            switch (thang)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return (Namnhuan(nam)) ? 29 : 28;
                default:
                    return 31;
            }
        }
        static bool KtNgay(int thang, int nam)
        {
            if (nam < 1) return false;
            if (thang < 1 || thang > 12) return false;
            return true;
        }
        public static void InLich()
        {
            Console.Write("Nhap thang: ");
            int thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            if (!KtNgay(thang, nam))
            {
                Console.WriteLine("Ngay khong hop le!");
            }
            else
            {
                DateTime NgayDauTien = new DateTime(nam, thang, 1);
                int NgayBatDauThang = (int)NgayDauTien.DayOfWeek;
                Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");

                for (int i = 0; i < NgayBatDauThang; i++)
                {
                    Console.Write("\t");
                }
                for (int i = 1; i <= Ngaytrongthang(thang,nam); i++)
                {
                    Console.Write(i + "\t");
                    if ((i + NgayBatDauThang) % 7 == 0)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}
