
namespace BTTH2_TranQuangDat_24520290
{
    public class NhaPho : TTDat
    {
        public int NamXay { get; set; }
        public int SoTang { get; set; }
        public NhaPho() : base() { }
        public NhaPho(string diadiem, decimal giaban, double dientich, int namxay, int sotang)
            : base(diadiem, giaban, dientich)
        {
            NamXay = namxay;
            SoTang = sotang;
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin Nha pho");
            base.Nhap();
            Console.WriteLine("Nhap nam xay dung: ");
            NamXay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so tang: ");
            SoTang = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine(" NHA PHO ");
            base.Xuat();
            Console.WriteLine($"Nam xay dung: {NamXay}");
            Console.WriteLine($"So tang: {SoTang}");
        }
        public override string Loai()
        {
            return "Nha Pho";
        }
    }
}
