
namespace BTTH2_TranQuangDat_24520290
{
    public class ChungCu : TTDat
    {
        public int Tang {  get; set; }
        public ChungCu() : base() { }
        public ChungCu(string diadiem, decimal giaban, double dientich, int tang)
            : base(diadiem, giaban, dientich) { }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin Chung cu");
            base.Nhap();
            Console.WriteLine("Nhap so tang: ");
            Tang = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine(" CHUNG CU ");
            base.Xuat();
            Console.WriteLine($"So tang: {Tang}");
        }
        public override string Loai()
        {
            return "Chung Cu";
        }
    }
}
