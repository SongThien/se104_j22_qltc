using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public static class BUS_LapHoaDon
    {
        public static String[] getDsMaTiecCuoiChuaThanhToan()
        {
            return DAO.DAO_TiecCuoi.getDsMaTiecCuoiChuaThanhToan();
        }

        public static String[] getDsMaTiecCuoiDaThanhToan()
        {
            return DAO.DAO_TiecCuoi.getDsMaTiecCuoiDaThanhToan();
        }

        public static DTO.DTO_TiecCuoi getThongTinTiecCuoi(string matc)
        {
            return DAO.DAO_TiecCuoi.getThongTinTiecCuoi(matc);
        }

        public static DTO.DTO_KhachHang getThongTinKhachHang(string makh)
        {
            return DAO.DAO_KhachHang.getThongTinKhachHang(makh);
        }
        public static DTO.DTO_LoaiSanh getThongTinLoaiSanh(string ma)
        {
            return DAO.DAO_QuanLyLoaiSanh.getThongTinLoaiSanh(ma);
        }

        public static DTO.DTO_Sanh getThongTinSanh(string ma)
        {
            return DAO.DAO_Sanh.getThongTinSanh(ma);
        }

        public static DataTable getDsMonAnDaDat(String maTC)
        {
            return DAO.DAO_DatMonAn.getDsMonAnDaDat(maTC);
        }

        
        public static DataTable getDsDichVuDaDat(String maTC)
        {
            return DAO.DAO_DatDichVu.getDsDichVuDaDat(maTC);
        }

        public static bool themHoaDon(DTO.DTO_HoaDonThanhToan hd)
        {
            return DAO.DAO_HoaDonThanhToan.themHoaDon(hd);
        }
        public static String[] getDanhSachMaHoaDon()
        {
            return DAO.DAO_HoaDonThanhToan.getDanhSachMaHoaDon();
        }

        public static String[] getDanhSachMaBaoCao()
        {
            return DAO.DAO_BaoCaoDoanhSo.getDanhSachMaBaoCao();
        }
    }
}
