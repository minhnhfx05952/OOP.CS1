using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo001
{
    internal class SinhVienhUDPM : SinhVien
    {
        private string maLop;
        private string maMon;
        private double diemThi;
        private double diemThucHanh;
        private double diemTongKet;
        public SinhVienhUDPM()
        {
        }
        public SinhVienhUDPM(string maLop, string maMon, double diemThi, double diemThucHanh, double diemTongKet)
        {
            this.maLop = maLop;
            this.maMon = maMon;
            this.diemThi = diemThi;
            this.diemThucHanh = diemThucHanh;
            this.diemTongKet = diemTongKet;
        }
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }
        public double DiemThi
        {
            get { return diemThi; }
            set { diemThi = value; }
        }
        public double DiemThucHanh
        {
            get { return diemThucHanh; }
            set { diemThucHanh = value; }
        }
        public double DiemTongKet
        {
            get { return diemTongKet; }
            set { diemTongKet = value; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ma lop: ");
            maLop = Console.ReadLine();
            Console.Write("Nhap ma mon: ");
            maMon = Console.ReadLine();
            Console.Write("Nhap diem thi: ");
            diemThi = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem thuc hanh: ");
            diemThucHanh = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem tong ket: ");
            diemTongKet = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ma lop: {0}", maLop);
            Console.WriteLine("Ma mon: {0}", maMon);
            Console.WriteLine("Diem thi: { 0}", diemThi);
            Console.WriteLine("Diem thuc hanh: {0}", diemThucHanh);


        }
    }
}
