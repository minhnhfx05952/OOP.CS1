using System;

namespace demo001
{
    internal class SinhVien
    {
        //tạo thuộc tính 
        private string maSV;
        private string hoTen;
        private double diem;
        //constructor không tham số
        public SinhVien()
        {
            maSV = "";
            hoTen = "";
            diem = 0;
        }
        //constructor có tham số
        public SinhVien(string maSV, string hoTen, double diem)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diem = diem;
        }

        //phương thức get set
        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double Diem { get => diem; set => diem = value; }

        //phương thức nhập
        public virtual void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            maSV = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap diem sinh vien: ");
            diem = double.Parse(Console.ReadLine());

        }
        //phương thức xuất
        public virtual void Xuat()
        {
            Console.WriteLine("Ma sinh vien: {0}", maSV);
            Console.WriteLine("Ho ten sinh vien: {0}", hoTen);
            Console.WriteLine("Diem sinh vien: {0}", diem);
        }


    }
}
