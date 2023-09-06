using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2KeThuaDaHinh_Bai1
{
    class CongTyDuLichX
    {
        string masochuyen;
        string hotentx;
        int soxe;
        double doanhthu;

        public string Masochuyen { get => masochuyen; set => masochuyen = value; }
        public string Hotentx { get => hotentx; set => hotentx = value; }
        public int Soxe { get => soxe; set => soxe = value; }
        public double Doanhthu { get => doanhthu; set => doanhthu = value; }
        public CongTyDuLichX()
        {
            masochuyen = "0";
            hotentx = "0";
            soxe = 0;
            doanhthu = 0;
        }
        public CongTyDuLichX(string masochuyen,string hotentx,int soxe,double doanhthu)
        {
            this.masochuyen = masochuyen;
            this.hotentx = hotentx;
            this.soxe = soxe;
            this.doanhthu = doanhthu;
        }
        public virtual void XuatTT()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3}", masochuyen, hotentx, soxe, doanhthu);
        }
    }
}
