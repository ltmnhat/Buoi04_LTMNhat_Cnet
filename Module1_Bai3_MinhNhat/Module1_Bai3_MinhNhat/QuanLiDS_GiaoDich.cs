using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai3_MinhNhat
{
    class QuanLiDS_GiaoDich
    {
        string magd;
        string ngaygd;
        double dongia;
        int soluong;

        public string Magd { get => magd; set => magd = value; }
        public string Ngaygd { get => ngaygd; set => ngaygd = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public QuanLiDS_GiaoDich()
        {
            magd = "000";
            ngaygd = "DD/MM/YYYY";
            dongia = 0f;
            soluong = 0;
        }
        public QuanLiDS_GiaoDich(string magd, string ngaygd,double dongia,int soluong)
        {
            this.magd = magd;
            this.ngaygd = ngaygd;
            this.dongia = dongia;
            this.soluong = soluong;
        }
        public virtual void XuatTT()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t", magd, ngaygd, dongia, soluong);
        }
    }
}
