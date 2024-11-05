using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.AllClass
{
    public class GiamDoc:NhanVien
    {
        public double coPhan {get;set;}

        public override double tinhLuong(int soNgayLamViec, double luongNgay){
            return soNgayLamViec * luongNgay;
        }
        public override void nhapThongTinNhanVien()
        {
            base.nhapThongTinNhanVien();
            Console.WriteLine("Vui lòng nhập số cổ phần : ");
            this.coPhan = Convert.ToDouble(Console.ReadLine());
        }

    }
}