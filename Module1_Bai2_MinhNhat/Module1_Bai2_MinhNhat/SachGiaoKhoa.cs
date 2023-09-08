using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai2_MinhNhat
{
    class SachGiaoKhoa : ThuVienX
    {
        string tinhtrang;
        public string TinhTrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value;
                {
                    if (tinhtrang == "Moi" && tinhtrang == "Cu")
                        throw new Exception("Chi co hai loai tinh trang la 'Moi' va 'Cu'.");
                }
            }
        }
        public SachGiaoKhoa():base()
        {
            tinhtrang = "Moi";
        }
        public SachGiaoKhoa(string masach, string ngaynhap, double dongia, int soluong, string nhaxuatban,string tinhtrang)
            :base(masach,ngaynhap,dongia,soluong, nhaxuatban)
        {
            this.tinhtrang = tinhtrang;
        }
        public override void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine("Tinh trang sach: {0}", tinhtrang);
        }   
        public double TinhThanhTien()
        {
            if (tinhtrang == "Moi")
                return Soluong * Dongia;
            return Soluong * Dongia * 0.5;
        }
    }
}
