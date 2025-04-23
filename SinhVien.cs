using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SinhVien : Nguoi
{
  
    public string maSV { get; set; }
    public string lop { get; set; }
    public float diemTB { get; set; }
    public override void Nhap()
    {
        base.Nhap();

        Console.WriteLine("Nhap vao maSV:");
        maSV = Console.ReadLine();
        Console.WriteLine("Nhap vao lop:");
        lop = Console.ReadLine();
        Console.WriteLine("Nhap vao diemTB:");
        diemTB = float.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"MaSV: {maSV}");
        Console.WriteLine($"lop: {lop}");
        Console.WriteLine($"diemTB: {diemTB}");
    }

    //so sanh 2 ma sinh vien
    public override bool Equals(object obj)
    {
        if (obj is SinhVien other)
        {
            return maSV == other.maSV;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return maSV.GetHashCode();
    }
}

