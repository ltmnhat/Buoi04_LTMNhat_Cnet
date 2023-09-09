using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai3_MinhNhat
{
    class GiaoDichTienTe:QuanLiDS_GiaoDich
    {
        double tigia;
        string loaitiente;

        public double Tigia { get => tigia; set => tigia = value; }
        public string Loaitiente
        {
            get { return loaitiente; }
            set { loaitiente = value;
                {
                    if (loaitiente != "USD" && loaitiente != "EURO" && loaitiente != "VND")
                        throw new Exception("Chi co 3 loai tien te la USD, EURO va VND. Nhap lai!!!");
                }
            }
        }
        public GiaoDichTienTe():base()
        {
            tigia = 3;
            loaitiente = "USD";
        }
        public GiaoDichTienTe(string magd, string ngaygd, double dongia, int soluong,double tigia,string loaitiente)
            :base(magd, ngaygd, dongia, soluong)
        {
            this.tigia = tigia;
            this.loaitiente = loaitiente;
        }
        public override void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine("Ti gia: {0}", tigia);
            Console.WriteLine("Loai tien te: {0}", loaitiente);
        }
        public double TinhThanhTien()
        {
            if (loaitiente == "VND")
                return Soluong * Dongia;
            return Soluong * Dongia * tigia;
        }
    }
}
