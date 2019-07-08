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
    }
}
