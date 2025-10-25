
namespace BTTH2_TranQuangDat_24520290
{
    public class KhuDat : TTDat
    {
        public KhuDat() : base() { }
        public KhuDat(string diadiem, decimal giaban, double dientich)
            : base(diadiem, giaban, dientich) { }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin Khu dat");
            base.Nhap();
        }
        public override void Xuat()
        {
            Console.WriteLine(" KHU DAT "); 
            base.Xuat();
        }
        public override string Loai()
        {
            return "Khu Dat";
        }
    }
}
