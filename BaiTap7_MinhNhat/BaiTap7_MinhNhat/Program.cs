using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap7_MinhNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron HT = new HinhTron();
            HT.Nhap();
            HT.Xuat();
            Console.ReadKey();
        }
    }
}
