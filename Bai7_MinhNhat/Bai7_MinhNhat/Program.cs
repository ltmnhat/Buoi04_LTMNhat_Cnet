using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_MinhNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo td = new ToaDo();
            HinhTron ht = new HinhTron();
            ht.Bankinh = 10.5;
            td.Tentd = "O";
            td.X = 5;
            td.Y = 5;
            Console.WriteLine("Tam hinh tron: {0}({1}:{2})", td.Tentd, td.X, td.Y);
            ht.Xuat();
            Console.ReadKey();
        }
    }
}
