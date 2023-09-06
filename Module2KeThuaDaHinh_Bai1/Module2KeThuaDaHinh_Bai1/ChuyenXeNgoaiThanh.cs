using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2KeThuaDaHinh_Bai1
{
    class ChuyenXeNgoaiThanh:CongTyDuLichX
    {
        string noiden;
        int songaydi;

        public string Noiden { get => noiden; set => noiden = value; }
        public int Songaydi { get => songaydi; set => songaydi = value; }

        public ChuyenXeNgoaiThanh():base()
        {
            noiden = "0";
            Songaydi = 0;
        }
        public ChuyenXeNgoaiThanh(string masochuyen, string hotentx, int soxe, double doanhthu, string noiden, int songaydi)
           : base(masochuyen, hotentx, soxe, doanhthu)
        {
            this.noiden = noiden;
            this.songaydi = songaydi;
        }
        public override void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine("{0} \t {1}", noiden, songaydi);
        }
    }
}
