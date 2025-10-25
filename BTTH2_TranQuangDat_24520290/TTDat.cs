

namespace BTTH2_TranQuangDat_24520290
{
    public abstract class TTDat
    {
        public string DiaDiem { get; set; }
        public decimal GiaBan { get; set; }
        public double DienTich { get; set; }
        public TTDat() { }

        public TTDat(string diadiem , decimal giaban , double dientich)
        {
            DiaDiem = diadiem;
            GiaBan = giaban;
            DienTich = dientich;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap dia diem: ");
            DiaDiem = Console.ReadLine();
            Console.WriteLine("Nhap gia ban: ");
            GiaBan = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Nhap dien tich: ");
            DienTich = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Dia diem: {DiaDiem}");
            Console.WriteLine($"Gia ban (Don vi: VND): {GiaBan} VND");
            Console.WriteLine($"Dien tich: {DienTich} m2");
        }
        public abstract string Loai();
    }
}
