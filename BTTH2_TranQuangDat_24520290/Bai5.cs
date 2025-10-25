    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BTTH2_TranQuangDat_24520290
    {
        internal class Bai5
        {
            static List<TTDat> ds = new List<TTDat>();
            public static void QuanLy()
            {
                int choice;
                do
                {
                    Console.WriteLine("\n===== MENU =====");
                    Console.WriteLine("1.Nhap danh sach");
                    Console.WriteLine("2.Xuat danh sach");
                    Console.WriteLine("3.Tong gia ban cho 3 loai");
                    Console.WriteLine("4.Xuat danh sach voi dieu kien");
                    Console.WriteLine("5.Tim kiem thong tin");
                    Console.WriteLine("0.Thoat");
                    Console.Write("Nhap lua chon: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            NhapDS();
                            break;
                        case 2:
                            Xuat();
                            break;
                        case 3:
                            TinhTongGiaTheoLoai();
                            break;
                        case 4:
                            XuatTheoDK();
                            break;
                        case 5:
                            TimKiem();
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
            static void NhapDS()
            {
                Console.WriteLine("Nhap so luong bat dong san: ");
                int n  = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nhap thong tin thu {i + 1}");
                    int loai;
                    TTDat bds = null;
                    do
                    {
                        Console.WriteLine(" Chon loai bat dong san");
                        Console.WriteLine("1-Khu Dat   2-Nha Pho   3-Chung Cu");
                        loai = Convert.ToInt32(Console.ReadLine());
                        switch (loai)
                        {
                            case 1:
                                bds = new KhuDat();
                                break;
                            case 2:
                                bds = new NhaPho();
                                break;
                            case 3:
                                bds = new ChungCu();
                                break;
                            default:
                                Console.WriteLine("Vui long nhap dung loai");
                                break;
                        }
                    } while (loai < 1 || loai > 3);
                    bds.Nhap();
                    ds.Add(bds);
                    Console.WriteLine("Da them vao danh sach");
                }
            }
            static void Xuat()
            {
                if (!ds.Any())
                {
                    Console.WriteLine("Danh sach rong");
                    return;
                }
                Console.WriteLine("===== DANH SACH =====");
                for (int i = 0; i < ds.Count; i++)
                {
                    var b = ds[i];
                    Console.WriteLine($"Thong tin {i + 1}");
                    b.Xuat();
                }
            }
            static void TinhTongGiaTheoLoai()
            {
                decimal tongKhuDat = ds.OfType<KhuDat>().Sum(x => x.GiaBan);
                decimal tongNhaPho = ds.OfType<NhaPho>().Sum(x => x.GiaBan);
                decimal tongChungCu = ds.OfType<ChungCu>().Sum(x => x.GiaBan);

                Console.WriteLine($"Tong gia ban Khu Dat : {tongKhuDat} VND");
                Console.WriteLine($"Tong gia ban Nha Pho : {tongNhaPho} VND");
                Console.WriteLine($"Tong gia ban Chung Cu : {tongChungCu} VND");
            }
            static void XuatTheoDK()
            {
                var dsKhuDat = new List<KhuDat>();

                foreach (var b in ds)
                {
                    if (b is KhuDat k && k.DienTich > 100)
                    {
                        dsKhuDat.Add(k);
                    }
                }

                var dsNhaPho = new List<NhaPho>();

                foreach (var b in ds)
                {
                    if (b is NhaPho n && n.DienTich > 60 && n.NamXay >= 2019)
                    {
                        dsNhaPho.Add(n);
                    }
                }
                if (!dsNhaPho.Any() && !dsKhuDat.Any())
                {
                    Console.WriteLine("Khong co khu dat hoac nha pho thoa dk");
                    return;
                }
                if (dsKhuDat.Any())
                {
                    Console.WriteLine("Danh sach cac khu dat co dien tich > 100m2");
                    foreach (var i in dsKhuDat)
                    {
                        i.Xuat();
                    }
                }
                if (dsNhaPho.Any())
                {
                    Console.WriteLine("Danh sach cac nha pho co dien tich > 60m2 va nam xay dung >= 2019");
                    foreach (var j in dsNhaPho)
                    {
                        j.Xuat();
                    }
                }
            }
            static void TimKiem()
            {
                Console.Write("Nhap dia diem can tim: ");
                string diaDiemTK = Console.ReadLine() ?? "";
                Console.Write("Nhap gia toi da (VND): ");
                decimal.TryParse(Console.ReadLine(), out decimal giaToiDa);
                Console.Write("Nhap dien tich toi thieu (m2): ");
                double.TryParse(Console.ReadLine(), out double dienTichMin);
                List<TTDat> ketQua = new List<TTDat>();
                foreach (var b in ds)
                {
                    if ((b is NhaPho || b is ChungCu)
                        && b.DiaDiem.Contains(diaDiemTK, StringComparison.OrdinalIgnoreCase)
                        && b.GiaBan <= giaToiDa
                        && b.DienTich >= dienTichMin)
                    {
                        ketQua.Add(b);
                    }
                }
                if (!ketQua.Any())
                {
                    Console.WriteLine("=> Khong tim thay bat dong san phu hop.");
                    return;
                }

                Console.WriteLine($"=> Co {ketQua.Count} ket qua phu hop:\n");
                int i = 1;
                foreach (var b in ketQua)
                {
                    Console.WriteLine($"Ket qua thu {i++}");
                    b.Xuat();
                    Console.WriteLine();
                }
            }
        }
    }
