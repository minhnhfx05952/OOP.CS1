using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo001
{
    internal class Program
    {
        static void Main(string[] args)
        {   QLSV qlsv = new QLSV();
            chose:
            Console.WriteLine("=====================");
            Console.WriteLine("1 .nhap 1 doi tuong vao danh sach");
            Console.WriteLine("2. Xuat doi tuong");
            Console.WriteLine("3. Xuat danh sach sinh vien diem TB tren 8");
            Console.WriteLine("4. Sap xep sv theo diem trung binh");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("=====================");
            //Menu Switch Case
            int chon;
            Console.Write("Nhap lua chon: ");
            chon = int.Parse(Console.ReadLine());
            
            switch (chon)
            {
                case 1:
                    nhap:
                    Console.WriteLine("=====================");
                    Console.WriteLine("Nhap doi tuong vao danh sach");
                    Console.WriteLine("=====================");
                    //nhập đối tượng
                    qlsv.Nhap();
                    Console.WriteLine("=====================");
                    Console.WriteLine("Ban co muon tiep tuc nhap?1 la co 2 la khong");
                    int nhap = int.Parse(Console.ReadLine());
                    if (nhap == 1)
                    {
                        goto nhap;
                    }
                    goto end;
                    break;
                case 2:
                    Console.WriteLine("=====================");
                    Console.WriteLine("Xuat doi tuong");
                    Console.WriteLine("=====================");
                    //xuất đối tượng
                    qlsv.Xuat();
                    Console.WriteLine("=====================");
                    goto end;
                    break;
                case 3:
                    Console.WriteLine("=====================");
                    Console.WriteLine("Xuat danh sach sinh vien diem TB tren 8");
                    Console.WriteLine("=====================");
                    //xuất danh sách sinh viên điểm trên 8
                    qlsv.XuatDSSVDTB8();
                    Console.WriteLine("=====================");
                    goto end;
                    break;
                case 4:
                    Console.WriteLine("=====================");
                    Console.WriteLine("Sap xep sv theo diem trung binh");
                    Console.WriteLine("=====================");
                    //sắp xếp
                    qlsv.SapXep();
                    Console.WriteLine("=====================");
                    goto end;
                    break;
                case 5:
                    Console.WriteLine("Thoat");
                    break;
                default:
                    Console.WriteLine("Nhap sai");
                    break;
            }
        end:
            Console.WriteLine("=====================");
            Console.WriteLine("Ban co muo quay ve chon menu?(1 la co, 2 la khong)");
            Console.WriteLine("=====================");
            int chon1 = int.Parse(Console.ReadLine());
            if (chon1 == 1)
            {
                goto chose;
            }
            else
            {
                return;
            }
        }
    }
}
