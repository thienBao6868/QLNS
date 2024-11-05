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
                Console.WriteLine(" 1. Nhập thông tin công ty.");
                Console.WriteLine(" 2. Thêm nhân sự. ");
                Console.WriteLine(" 3. Xoá nhân sự. ");
                Console.WriteLine(" 4.Xuất thông tin toàn bộ người trong công ty. ");
                Console.WriteLine(" 5. Phân bổ nhân viên vào trưởng phòng. ");
                Console.WriteLine(" 6. Tính và xuất tổng lương cho công ty. ");
                Console.WriteLine(" 7. Tìm nhân viên thường có lương cao nhất. ");
                Console.WriteLine(" 8. Tìm trường phòng có số lượng nhân viên dưới quyền nhiều nhất. ");
                Console.WriteLine(" 9. Sắp xếp nhân viên toàn công ty theo thứ tự abc. ");
                Console.WriteLine(" 10. Sắp xếp nhận viên toàn công ty theo thứ tự lương giảm dần. ");
                Console.WriteLine(" 11. Tìm giám đốc có số lượng cổ phiếu nhiều nhất. ");
                Console.WriteLine(" 12. Tính và xuất tổng thu nhập của từng giám đốc. ");

                chosen = Convert.ToInt32(Console.ReadLine());
                switch (chosen)
                {
                    case 1:     
                    NhapThongTinCongTy nhapThongTinCongTy = new NhapThongTinCongTy();
                    nhapThongTinCongTy.nhapThongTin();
                    break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Vui lòng chọn loại nhân viên cần thêm :");
                            Console.WriteLine("1. Nhân Viên Thường :");
                            Console.WriteLine("2. Trưởng phòng :");
                            Console.WriteLine("3. Giám đốc :");
                            Console.WriteLine("0. Nhập 0 để thoát thêm nhân viên :");
                            chonLoaiNhanVien = Convert.ToInt32(Console.ReadLine());
                            switch (chonLoaiNhanVien)
                            {
                                case 1:
                                NhanVien nhanVien = new NhanVien();
                                nhanVien.nhapThongTinNhanVien();
                                break;
                                case 2:
                                TruongPhong truongPhong = new TruongPhong();
                                truongPhong.nhapThongTinNhanVien();
                                break;
                                case 3:
                                GiamDoc giamDoc = new GiamDoc();
                                giamDoc.nhapThongTinNhanVien();
                                break;
                                case 0:
                                Console.WriteLine("Bạn đã thoát chương trình thêm nhân viên");
                                break;
                            }
                        } while (chonLoaiNhanVien != 0);
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