using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2KeThuaDaHinh_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Chuyen Xe Ngoai Thanh
            ChuyenXeNgoaiThanh[] dsngth = new ChuyenXeNgoaiThanh[2];
            dsngth[0] = new ChuyenXeNgoaiThanh { Masochuyen = "001", Hotentx = "Minh Nhat", Soxe = 24, Doanhthu = 1500000, Noiden = "Ben Tre", Songaydi=1};
            dsngth[1] = new ChuyenXeNgoaiThanh { Masochuyen = "002", Hotentx = "Nhat Minh", Soxe = 25, Doanhthu = 500000, Noiden = "Dong Nai", Songaydi = 2 };
            
            double TongDTNGTH = 0;
            for(int i=0;i<dsngth.Length;i++)
            {
                dsngth[i].XuatTT();
                TongDTNGTH = TongDTNGTH + dsngth[i].Doanhthu;
            }
            Console.WriteLine("Tong doang thu cua chuyen xe ngoai thanh la: {0}",TongDTNGTH);
            //Chuyen Xe Noi Thanh
            ChuyenXeNoiThanh[] dsnt = new ChuyenXeNoiThanh[2];
            dsnt[0] = new ChuyenXeNoiThanh { Masochuyen = "001", Hotentx = "Minh Nhat", Soxe = 26, Doanhthu = 3000000, Sotuyen = 14, Sokmdi = 5.5 };
            dsnt[1] = new ChuyenXeNoiThanh { Masochuyen = "002", Hotentx = "Nhat Minh", Soxe = 27, Doanhthu = 1000000, Sotuyen = 26, Sokmdi = 10.5 };
            double TongDTNT = 0;
            for (int i = 0; i < dsngth.Length; i++)
            {
                dsnt[i].XuatTT();
                TongDTNT = TongDTNT + dsnt[i].Doanhthu;
            }
            Console.WriteLine("Tong doang thu cua chuyen xe noi thanh la: {0}", TongDTNT);
            Console.ReadKey();
        }
    }
}
