using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai2_MinhNhat
{
    class ThuVienX
    {
        string masach;
        string ngaynhap;
        double dongia;
        int soluong;
        string nhaxuatban;

        public string Masach { get => masach; set => masach = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Nhaxuatban { get => nhaxuatban; set => nhaxuatban = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }

        public ThuVienX()
        {
            masach = "000";
            ngaynhap = "DD/MM/YYYY";
            dongia = 0f;
            soluong = 0;
            nhaxuatban = "OOOOOOO";
        }
        public ThuVienX(string masach,string ngaynhap,double dongia,int soluong,string nhaxuatban)
        {
            this.masach = masach;
            this.ngaynhap = ngaynhap;
            this.dongia = dongia;
            this.soluong = soluong;
            this.nhaxuatban = nhaxuatban;
        }
        public virtual void XuatTT()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", masach, ngaynhap, dongia, soluong, nhaxuatban);
        }
    }
}
