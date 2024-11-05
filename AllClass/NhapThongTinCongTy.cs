using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.AllClass
{
    public class NhapThongTinCongTy
    {   
        private string? tenCongTy {get;set;}
        private int maSoThue {get;set;}
        private double doanhThu {get;set;}

        public void nhapThongTin(){

            Console.WriteLine("Vui lòng nhập tên công ty : ");
            this.tenCongTy = Console.ReadLine();

            Console.WriteLine("Vui lòng nhập mã số thuế : ");

            this.maSoThue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Vui lòng nhập doanh thu tháng");

            this.doanhThu = Convert.ToDouble(Console.ReadLine());

        }
    }
}