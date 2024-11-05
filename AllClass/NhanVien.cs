using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.AllClass
{
    public class NhanVien
    {
        public int maSoNv { get; set; }
        public string? HoTenNv { get; set; }
        public int soDienThoai { get; set; }
        public int soNgayLamViec { get; set; }
        public double luongNgay { get; set; }
        public NhanVien() { }

        public virtual double tinhLuong(int soNgayLamViec, double luongNgay)
        {
            return  soNgayLamViec * luongNgay;
        }

        public virtual void nhapThongTinNhanVien()
        {
            Console.WriteLine("Vui Lòng Nhập Mã Số Nhân Viên : ");
            this.maSoNv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui Lòng Nhập Họ Tên Nhân Viên : ");
            this.HoTenNv = Console.ReadLine();
            Console.WriteLine("Vui Lòng Nhập Số Điện thoại : ");
            this.soDienThoai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui Lòng Nhập Số ngày làm việc :");
            this.soNgayLamViec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vui Lòng Nhập Lương/ ngày  :");
            this.luongNgay = Convert.ToDouble(Console.ReadLine());
        }

    }
}