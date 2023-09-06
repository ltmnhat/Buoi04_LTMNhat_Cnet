using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap7_MinhNhat
{
    class HinhTron:ToaDo
    {
        double bankinh;

        public double Bankinh { get => bankinh; set => bankinh = value; }
        public HinhTron():base()
        {
            Tentd = "O";
            X = 0;
            Y = 0;
            bankinh = 0;
        }
        public HinhTron(string tentd,float x,float y,double bankinh)
            :base(tentd,x,y)
        {
            this.bankinh = bankinh;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ban kinh: ");
            bankinh = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ban Kinh: {0} ", bankinh);
            Console.WriteLine("Chu vi hinh tron la: {0}", TinhChuVi());
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
