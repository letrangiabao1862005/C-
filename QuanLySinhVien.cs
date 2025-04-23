using System;

public class QuanLySinhVien
{
    static List<SinhVien> danhSachSv = new List<SinhVien>();
    void ThemSinhVien()
    {
        Console.WriteLine("Nhap so luong sinh vien ban muon them: ");
        int soLuong = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine($"Sinh vien thu: {i + 1} la: ");
            SinhVien sv = new SinhVien();
            sv.Nhap();

            if (!danhSachSv.Contains(sv))
            {
                danhSachSv.Add(sv);
                Console.WriteLine("Da them sinh vien");
            }

            else
            {
                Console.WriteLine("Sinh vien da ton tai");
            }
        }
    }

    void HienThiDanhSach()
    {
        Console.WriteLine("Danh sach sinh vien: ");
        foreach (var sv in danhSachSv)
        {
            sv.Xuat();
        }
    }

    void HienThiMeNu()
    {
        Console.WriteLine("\n--- MENU ---");
        Console.WriteLine("1. Thêm sinh viên");
        Console.WriteLine("2. Hiển thị danh sách");
        Console.WriteLine("3. Tim ");
        Console.WriteLine("4. Sua");
        Console.WriteLine("5. Xoa");
        Console.WriteLine("6. Sap xep theo ten");
        Console.WriteLine("7. Sap xep theo diemTB");
        Console.WriteLine("0. Thoát");
    }

    //timkiem 
    void TimKiem()
    {
        Console.WriteLine("Nhap ma sinh vien ban muon tim: ");
        string maSvMuonTim = Console.ReadLine();

        var svCanTim = danhSachSv.FirstOrDefault(s => s.maSV == maSvMuonTim);

        if (svCanTim != null)
        {
            svCanTim.Xuat();
            Console.WriteLine("Da tim thay sinh vien");
        }
        else
        {
            Console.WriteLine("Khong tim thay");
        }
    }

    //sua
    void Sua()
    {
        Console.WriteLine("Nhap vao ma sinh vien can sua chua");
        string maSvCanSua = Console.ReadLine();

        var sv = danhSachSv.FirstOrDefault(s => s.maSV == maSvCanSua);

        if(sv != null)
        {
            Console.WriteLine("Nhap lai thong tin cua sinh vien");
            sv.Nhap();
            Console.WriteLine("Thong tin sinh vien da duoc cap nhat");
        }

        else
        {
            Console.WriteLine("Khong itm thay");
        }

    }

    //xoa
    void Xoa()
    {
        Console.WriteLine("nhap ma sinh vien can xoa");
        string maSvCanXoa = Console.ReadLine();

        var sv = danhSachSv.FirstOrDefault(s => s.maSV == maSvCanXoa);

        if (sv != null)
        {
            danhSachSv.Remove(sv);
            Console.WriteLine("Sinh vien da duoc xoa");
        }

        else
            Console.WriteLine("Khong tim duoc");    
    }

    void SapXepTheoTen()
    {
        danhSachSv = danhSachSv.OrderBy(s => s.hoTen).ToList();
        Console.WriteLine("Da sap xep tang dan theo ten");
    }

    void SapXepTheoDiem()
    {
        danhSachSv = danhSachSv.OrderByDescending(s => s.diemTB).ToList();
        Console.WriteLine("Da sap xep giam dan theo diem");
    }
    public void ChayChuongTrinh()
    {
        string chon;
        do
        {
            HienThiMeNu();
            chon = Console.ReadLine().Trim();
            switch (chon)
            {
                case "1":
                    ThemSinhVien();
                    break;
                case "2":
                    HienThiDanhSach();
                    break;
                case "3":
                    TimKiem();
                    break;
                case "4":
                    Sua();
                    break;
                case "5":
                    Xoa();
                    break;
                case "6":
                    SapXepTheoTen();
                    break;
                case "7":
                    SapXepTheoDiem();
                    break;
                case "0":
                    Console.WriteLine("Da thoat");
                    break;
                default:
                    Console.WriteLine("lua chon khong hop le");
                    break;
            }
        }
        while (chon != "0");
    }


}

