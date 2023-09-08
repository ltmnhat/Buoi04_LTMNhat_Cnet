using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai2_MinhNhat
{
    class Program
    {
        static void ShowMENU()
        {
            Console.WriteLine("0. Thoát Chương Trình");
            Console.WriteLine("1. Tinh Tong Gia Tien Tung Loai Sach Giao Khoa Va Sach Tham Khao");
            Console.WriteLine("2. Tinh Trung Binh Cong");
            Console.WriteLine("3. Xuat Theo Nha San Xuat");
        }
        static void Main(string[] args)
        {
            SachGiaoKhoa[] dssgk = new SachGiaoKhoa[3];
            SachThamKhao[] dsstk = new SachThamKhao[3];
            ShowMENU();
            int key;
            do
            {
                Console.Write("Chon chuong trinh de may thuc hien: ");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        {
                            Console.WriteLine("Thoat chuong trinh!!!");
                            break;
                        }
                    case 1:
                        {
                            double TongThanhTienGK = 0;
                            double TongThanhTienTK = 0;
                            // Khoi Tao Danh Sach 3 Sach GK
                            Console.WriteLine("SACH GIAO KHOA");
                            dssgk[0] = new SachGiaoKhoa { Masach = "001", Ngaynhap = "08/09/2018", Dongia = 150000, Soluong = 3, Nhaxuatban = "Kim Dong", TinhTrang = "Moi" };
                            dssgk[1] = new SachGiaoKhoa { Masach = "002", Ngaynhap = "10/09/2018", Dongia = 500000, Soluong = 5, Nhaxuatban = "Nha Nam", TinhTrang = "Cu" };
                            dssgk[2] = new SachGiaoKhoa { Masach = "003", Ngaynhap = "11/09/2018", Dongia = 250000, Soluong = 2, Nhaxuatban = "Nhat Book", TinhTrang = "Moi" };
                            // Tinh Tong Thanh Tien SGK
                            for (int i = 0; i < dssgk.Length; i++)
                            {
                                dssgk[i].XuatTT();
                                TongThanhTienGK = TongThanhTienGK + dssgk[i].TinhThanhTien();
                            }
                            Console.WriteLine("Tong thanh tien cua sach giao khoa la: {0:C}", TongThanhTienGK);
                            // Khoi Tao Danh Sach 3 Sach TK
                            Console.WriteLine("SACH THAM KHAO");
                            dsstk[0] = new SachThamKhao { Masach = "001", Ngaynhap = "08/09/2018", Dongia = 150000, Soluong = 3, Nhaxuatban = "Kim Dong", Thue=15000 };
                            dsstk[1] = new SachThamKhao { Masach = "002", Ngaynhap = "10/09/2018", Dongia = 500000, Soluong = 5, Nhaxuatban = "Nha Nam", Thue=50000 };
                            dsstk[2] = new SachThamKhao { Masach = "003", Ngaynhap = "11/09/2018", Dongia = 250000, Soluong = 2, Nhaxuatban = "Nhat Book", Thue=25000};
                            // Tinh Tong Thanh Tien STK
                            for (int i = 0; i < dssgk.Length; i++)
                            {
                                dsstk[i].XuatTT();
                                TongThanhTienTK = TongThanhTienTK + dsstk[i].TinhThanhTien();
                            }
                            Console.WriteLine("Tong thanh tien cua sach tham khao la: {0:C}", TongThanhTienTK);
                            break;
                        }
                    case 2:
                        {
                            double TongThanhTienTK = 0;
                            double TongTBC_STK = 0;
                            Console.WriteLine("SACH THAM KHAO");
                            dsstk[0] = new SachThamKhao { Masach = "001", Ngaynhap = "08/09/2018", Dongia = 150000, Soluong = 3, Nhaxuatban = "Kim Dong", Thue = 15000 };
                            dsstk[1] = new SachThamKhao { Masach = "002", Ngaynhap = "10/09/2018", Dongia = 500000, Soluong = 5, Nhaxuatban = "Nha Nam", Thue = 50000 };
                            dsstk[2] = new SachThamKhao { Masach = "003", Ngaynhap = "11/09/2018", Dongia = 250000, Soluong = 2, Nhaxuatban = "Nhat Book", Thue = 25000 };
                            for (int i = 0; i < dssgk.Length; i++)
                            {
                                dsstk[i].XuatTT();
                                TongThanhTienTK = TongThanhTienTK + dsstk[i].TinhThanhTien();
                            }
                            TongTBC_STK = TongThanhTienTK / dsstk.Length;
                            Console.WriteLine("Trung Binh Cong: {0:C}", TongTBC_STK);
                            break;
                        }
                    case 3:
                        {
                            int dem=0;
                            string tennsxtim;
                            Console.Write("Nhap ten nha san xuat: ");
                            tennsxtim = Console.ReadLine();
                            // Khoi Tao Danh Sach 3 Sach GK
                            Console.WriteLine("SACH GIAO KHOA");
                            dssgk[0] = new SachGiaoKhoa { Masach = "001", Ngaynhap = "08/09/2018", Dongia = 150000, Soluong = 3, Nhaxuatban = "Kim Dong", TinhTrang = "Moi" };
                            dssgk[1] = new SachGiaoKhoa { Masach = "002", Ngaynhap = "10/09/2018", Dongia = 500000, Soluong = 5, Nhaxuatban = "Nha Nam", TinhTrang = "Cu" };
                            dssgk[2] = new SachGiaoKhoa { Masach = "003", Ngaynhap = "11/09/2018", Dongia = 250000, Soluong = 2, Nhaxuatban = "Kim Dong", TinhTrang = "Moi" };
                            for(int i=0;i<dssgk.Length;i++)
                            {
                                if (dssgk[i].Nhaxuatban == tennsxtim)
                                {
                                    dssgk[i].XuatTT();
                                    dem++;
                                }
                            }
                            if(dem==0)
                            {
                                Console.WriteLine("Khong co nha xuat ban tren trong danh sach!");
                            }
                            break;
                        }
                }
            } while (key != 0);
            Console.ReadKey();
        }
    }
}
