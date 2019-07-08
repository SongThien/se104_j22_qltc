using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BUS
{
    public static class BUS_DatTiecCuoi
    {
        public static String[] getDanhSachKhachHang()
        {
            return DAO.DAO_KhachHang.getDanhSachKhachHang();
        }
        public static DTO_KhachHang getThongTinKhachHang(String maKH)
        {
            return DAO.DAO_KhachHang.getThongTinKhachHang(maKH);
        }
        public static bool themKhachHang(DTO.DTO_KhachHang kh)
        {
            return DAO.DAO_KhachHang.themKhachHang(kh);
        }
        public static bool capNhatThongTinKH(DTO.DTO_KhachHang kh)
        {
            return DAO.DAO_KhachHang.capNhatThongTinKH(kh);
        }
        public static (String[], String[]) getDanhSachTenMonAn()
        {
            return DAO.DAO_MonAn.getDanhSachTenMonAn();
        }
        public static (String[], String[]) getDanhSachDichVu()
        {
            return DAO.DAO_DichVu.getDanhSachDichVu();
        }
        public static DTO.DTO_MonAn getThongTinMonAn(String maMA)
        {
            return DAO.DAO_MonAn.getThongTinMonAn(maMA);
        }
        public static String[] getDsMaTiecCuoi(String maTC)
        {
            return DAO.DAO_TiecCuoi.getDsMaTiecCuoi(maTC);
        }
    }
}
