using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //hoten, namsinbh, masv, lop, diemTB
    class Nguoi
    {
        public string hoTen { get; set; }
        public int namSinh { get; set; }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap hoTen: ");
            hoTen = Console.ReadLine();

            Console.WriteLine("Nhap nam sinh:");
            namSinh = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Hoten: {hoTen}");
            Console.WriteLine($"Nam Sinh: {namSinh}");
        }
    }
