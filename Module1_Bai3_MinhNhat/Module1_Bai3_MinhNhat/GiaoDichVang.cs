using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai3_MinhNhat
{
    class GiaoDichVang:QuanLiDS_GiaoDich
    {
        string loaivang;

        public string Loaivang { get => loaivang; set => loaivang = value; }
        public GiaoDichVang():base()
        {
            loaivang = "0";
        }
        public GiaoDichVang(string magd, string ngaygd, double dongia, int soluong, string loaivang)
            :base(magd,ngaygd, dongia,soluong)
        {
            this.loaivang = loaivang;
        }
        public override void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine("Loai Vang: {0} ", loaivang);
        }
        public double TinhThanhTien()
        {
            return Dongia * Soluong;
        }
    }
}
