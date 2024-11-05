using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.AllClass
{
    public class TruongPhong: NhanVien
    {
        public List<NhanVien> listNhanVien {get;set;}

        public TruongPhong(){
            listNhanVien = new List<NhanVien>();
        }
        public override double tinhLuong(int soNgayLamViec, double luongNgay){
            return soNgayLamViec * luongNgay + 100 * listNhanVien.Count;
        }

        public override void nhapThongTinNhanVien()
        {
            base.nhapThongTinNhanVien();
        }
    }
}