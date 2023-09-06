using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_MinhNhat
{
    class HinhTron
    {
        double bankinh;
        ToaDo tam;

        public double Bankinh { get => bankinh; set => bankinh = value; }
        internal ToaDo Tam { get => tam; set => tam = value; }

        public HinhTron()
        {

        }
        public HinhTron(ToaDo tam, double bankinh)
        {
            this.tam = tam;
            this.bankinh = bankinh;
        }
        public void xuat()
        {
            Console.WriteLine("Ban kinh hinh tron: {0}", bankinh);
            Console.WriteLine("Chu vi hinh tron la: {0} ", TinhChuVi());
            Console.WriteLine("Dien tich hinh tron la: {0}", TinhDienTich());
        }
        public double TinhChuVi()
        {
            return 2 * bankinh * Math.PI;
        }
        public double TinhDienTich()
        {
            return bankinh * bankinh * Math.PI;
        }
    }
}
