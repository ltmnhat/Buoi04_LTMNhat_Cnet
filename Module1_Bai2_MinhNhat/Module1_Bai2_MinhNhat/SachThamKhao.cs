using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai2_MinhNhat
{
    class SachThamKhao:ThuVienX
    {
        double thue;

        public double Thue { get => thue; set => thue = value; }
        public SachThamKhao():base()
        {
            thue = 0f;
        }
        public SachThamKhao(string masach, string ngaynhap, double dongia, int soluong, string nhaxuatban,double thue)
            :base(masach, ngaynhap, dongia, soluong, nhaxuatban)
        {
            this.thue = thue;
        }
        public override void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine("Thue: {0}",thue);
        }
        public double TinhThanhTien()
        {
            return Soluong * Dongia + thue;
        }
    }
}
