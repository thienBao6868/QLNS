using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_.AllClass
{
    public class Menu
    {   
        private int chosen;

        private int chonLoaiNhanVien;
        public void ChonDanhSach (){
            do
            {   
                Console.WriteLine(" Danh sách các chức năng của chương trình : ");
                Console.WriteLine(" 1. Nhập thông tin công ty : ");
                Console.WriteLine(" 2. Thêm nhân sự : ");
                Console.WriteLine(" 3. Xoá nhân sự : ");
                Console.WriteLine(" 4. Phân bổ nhân viên vào trưởng phòng : ");
                Console.WriteLine(" 5. Tính và xuất tổng lương cho công ty : ");
                Console.WriteLine(" 6. Tìm nhân viên thường có lương cao nhất : ");
                Console.WriteLine(" 7. Tìm trường phòng có số lượng nhân viên dưới quyền nhiều nhất : ");
                Console.WriteLine(" 8. Sắp xếp nhân viên toàn công ty theo thứ tự abc : ");
                Console.WriteLine(" 9. Sắp xếp nhận viên toàn công ty theo thứ tự lương giảm dần : ");
                Console.WriteLine(" 10. Tìm giám đốc có số lượng cổ phiếu nhiều nhất : ");
                Console.WriteLine(" 11.Xuất thông tin toàn bộ người trong công ty : ");
                Console.WriteLine(" 12. Tính và xuất tổng thu nhập của từng giám đốc : ");

                chosen = Convert.ToInt32(Console.ReadLine());
                switch (chosen)
                {
                    case 1:     
                    NhapThongTinCongTy nhapThongTinCongTy = new NhapThongTinCongTy();
                    nhapThongTinCongTy.nhapThongTin();
                    break;
                    case 0:
                    Console.WriteLine("Bạn đã thoát chương trình.");
                    break;
                    default:
                    break;
                }

            } while (chosen != 0);
        }
    }
}