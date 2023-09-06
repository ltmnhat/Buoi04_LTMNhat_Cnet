using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2KeThuaDaHinh_Bai1
{
    class ChuyenXeNoiThanh:CongTyDuLichX
    {
        int sotuyen;
        double sokmdi;

        public int Sotuyen { get => sotuyen; set => sotuyen = value; }
        public double Sokmdi { get => sokmdi; set => sokmdi = value; }
        public ChuyenXeNoiThanh():base()
        {
            sotuyen = 0;
            sokmdi = 0;
        }
        public ChuyenXeNoiThanh(string masochuyen, string hotentx, int soxe, double doanhthu,int sotuyen,double sokmdi)
            :base(masochuyen, hotentx, soxe, doanhthu)
        {
            this.sotuyen = sotuyen;
            this.sokmdi = sokmdi;
        }
        public override void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine("{0} \t {1}", sotuyen, sokmdi);
        }

    }
}
