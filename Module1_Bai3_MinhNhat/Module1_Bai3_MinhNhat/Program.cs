using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai3_MinhNhat
{
    class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("------------------------MENU-----------------------");
            Console.WriteLine("0. Thoat Chuong Trinh");
            Console.WriteLine("1. Tinh tong so luong tung loai giao dich");
            Console.WriteLine("2. Tinh trung binh thanh tien cua giao dich tien te");
            Console.WriteLine("3. Xuat ra cac giao dich co don gia > 1 ty");
        }
        static void Main(string[] args)
        {           
            GiaoDichVang[] dsgdv = new GiaoDichVang[3];
            GiaoDichTienTe[] dsgdtt = new GiaoDichTienTe[3];
            dsgdv[0] = new GiaoDichVang { Magd = "001", Ngaygd = "24/05/2018", Dongia = 1500000000, Soluong = 1, Loaivang = "24K" };
            dsgdv[1] = new GiaoDichVang { Magd = "002", Ngaygd = "25/06/2018", Dongia = 500000000, Soluong = 11, Loaivang = "18K" };
            dsgdv[2] = new GiaoDichVang { Magd = "003", Ngaygd = "26/07/2018", Dongia = 100000000, Soluong = 12, Loaivang = "9999" };
            dsgdtt[0] = new GiaoDichTienTe { Magd = "001", Ngaygd = "24/05/2018", Dongia = 500000, Soluong = 6, Tigia = 2, Loaitiente = "VND" };
            dsgdtt[1] = new GiaoDichTienTe { Magd = "002", Ngaygd = "25/06/2018", Dongia = 200000, Soluong = 5, Tigia = 5, Loaitiente = "USD" };
            dsgdtt[2] = new GiaoDichTienTe { Magd = "003", Ngaygd = "26/07/2018", Dongia = 300000, Soluong = 2, Tigia = 3, Loaitiente = "EURO" };
            int key;
            do
            {
                ShowMenu();
                Console.Write("Nhap chuong trinh muon thuc thi: ");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        {
                            Console.WriteLine("Thoat chuong trinh !!!");
                            break;
                        }
                    case 1:
                        {
                            // Giao dich vang
                            int TongSL_Vang = 0;                      
                            for(int i=0;i<dsgdv.Length;i++)
                            {
                                dsgdv[i].XuatTT();
                                TongSL_Vang = TongSL_Vang + dsgdv[i].Soluong;
                            }
                            Console.WriteLine("Tong so luong giao dich vang la: {0}", TongSL_Vang);
                            // Giao dich tien te
                            int TongSL_Tien = 0;                            
                            for (int i = 0; i < dsgdv.Length; i++)
                            {
                                dsgdtt[i].XuatTT();
                                TongSL_Tien = TongSL_Tien + dsgdtt[i].Soluong;
                            }
                            Console.WriteLine("Tong so luong giao dich tien te la: {0}", TongSL_Tien);
                            break;
                        }
                    case 2:
                        {
                            double TongTTien = 0;
                            int dem=0;                          
                            for (int i = 0; i < dsgdv.Length; i++)
                            {
                                dsgdtt[i].XuatTT();
                                TongTTien = TongTTien + dsgdtt[i].TinhThanhTien();
                                dem++;
                            }
                            Console.WriteLine("Tong thanh tien giao dich tien te la: {0}", TongTTien);
                            Console.WriteLine("Trung binh thanh tien giao dich tien te la: {0}", TongTTien/dem);
                            break;
                        }
                    case 3:
                        {
                            // Xuat cac giao dich lon hon 1 ty
                            int dem=0;
                            for(int i=0;i<dsgdv.Length;i++)
                            {
                                if (dsgdv[i].Dongia > 1000000000)
                                {
                                    dsgdv[i].XuatTT();
                                    dem++;
                                }
                            }
                            for (int i = 0; i < dsgdtt.Length; i++)
                            {
                                if (dsgdtt[i].Dongia > 1000000000)
                                {
                                    dsgdtt[i].XuatTT();
                                    dem++;
                                }
                            }
                            if (dem == 0)
                                Console.WriteLine("Khong co giao dich nao co don gia lon hon 1 ty !!");
                            Console.WriteLine("Co {0} giao dich co don gia lon hon 1 ty", dem);
                            break;
                        }
                }

            } while (key != 0);
            Console.ReadKey();
        }
    }
}
