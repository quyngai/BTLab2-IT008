class PhanSo : IComparable<PhanSo>
{
    public int Tu { get; set; }
    public int Mau { get; set; }
    public PhanSo()
    {
        Tu = 0;
        Mau = 1;
    }
    public PhanSo(int t, int m)
    {
        Tu = t;
        Mau = m;
        RutGon();
    }
    private int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }
    private void RutGon()
    {
        int gcd = UCLN(Math.Abs(Tu), Math.Abs(Mau));
        Tu /= gcd;
        Mau /= gcd;
        if (Mau < 0)
        {
            Tu = -Tu;
            Mau = -Mau;
        }
    }

    public static PhanSo NhapPhanSo()
    {
        Console.WriteLine("Nhap tu so: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap mau so: ");
        int b = Convert.ToInt32(Console.ReadLine());
        while (b == 0)
        {
            Console.WriteLine("Vui long nhap mau khac 0");
            b = Convert.ToInt32(Console.ReadLine());
        }
        if (b < 0)
        {
            a = -a;
            b = -b;
        }
        return new PhanSo(a, b);
    }
    public override string ToString()
    {
        if (Tu == 0) return "0";
        if (Mau == 1) return $"{Tu}";
        return $"{Tu}/{Mau}";
    }

    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
    }
    public static PhanSo operator -(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
    }
    public static PhanSo operator *(PhanSo a, PhanSo b)
    {
        return new PhanSo(a.Tu * b.Tu , a.Mau * b.Mau);
    }
    public static PhanSo operator /(PhanSo a, PhanSo b)
    {
        if (b.Tu == 0)
            throw new DivideByZeroException("Khong chia cho 0");
        return new PhanSo(a.Tu * b.Mau, a.Mau * b.Tu);
    }

    public int CompareTo(PhanSo ps)
    {
        return (Tu * ps.Mau).CompareTo(ps.Tu * Mau);
    }

}