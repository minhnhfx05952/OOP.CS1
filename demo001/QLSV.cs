using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo001
{
    internal class QLSV
    {
        //list QLSV
        private List<SinhVien> dsSV;
        public QLSV()
        {
            dsSV = new List<SinhVien>();
        }
        public void Nhap()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                SinhVien sv = new SinhVien();
                sv.Nhap();
                dsSV.Add(sv);
            }
        }
        public void Xuat()
        {
            foreach (SinhVien sv in dsSV)
            {
                sv.Xuat();
            }
        }
        public void Xoa(string maSV)
        {
            foreach (SinhVien sv in dsSV)
            {
                if (sv.MaSV == maSV)
                {
                    dsSV.Remove(sv);
                    break;
                }
            }
        }
        public SinhVien TimKiem(string maSV)
        {
            foreach (SinhVien sv in dsSV)
            {
                if (sv.MaSV == maSV)
                {
                    return sv;
                }
            }
            return null;
        }
        //xuất danh sách sinh viên điểm trên 8
        public void XuatDSSVDTB8()
        {
            foreach (SinhVien sv in dsSV)
            {
                if (sv.Diem > 8)
                {
                    sv.Xuat();
                }
            }
        }
        //sắp xếp theo điểm
        public void SapXep()
        {//buble sort
            for (int i = 0; i < dsSV.Count - 1; i++)
            {
                for (int j = i + 1; j < dsSV.Count; j++)
                {
                    if (dsSV[i].Diem > dsSV[j].Diem)
                    {
                        SinhVien temp = dsSV[i];
                        dsSV[i] = dsSV[j];
                        dsSV[j] = temp;
                    }
                }
            }
        }
        //tìm kiếm theo tên 
        public SinhVien TimKiemTheoTen(string ten)
        {
            foreach (SinhVien sv in dsSV)
            {
                if (sv.HoTen == ten)
                {
                    return sv;
                }
            }
            return null;
        }
        
    }
}
