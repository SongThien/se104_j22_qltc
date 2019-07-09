using System;
using System.Collections.Generic;
using System.Data;
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
        public static String[] getDsMaTiecCuoi()
        {
            return DAO.DAO_TiecCuoi.getDsMaTiecCuoi();
        }

        public static DTO.DTO_TiecCuoi getThongTinTiecCuoi(String maTC)
        {
            return DAO.DAO_TiecCuoi.getThongTinTiecCuoi(maTC);
        }

        public static DTO.DTO_Sanh getThongTinSanh(String maS)
        {
            return DAO.DAO_Sanh.getThongTinSanh(maS);
        }

        public static DTO.DTO_Ca getThongTinCa(String maC)
        {
            return DAO.DAO_Ca.getThongTinCa(maC);
        }

        public static DataTable getDsMonAnDaDat(String maTC)
        {
            return DAO.DAO_DatMonAn.getDsMonAnDaDat(maTC);
        }

        public static DataTable getDsDichVuDaDat(String maTC)
        {
            return DAO.DAO_DatDichVu.getDsDichVuDaDat(maTC);
        }
        public static bool capNhatThongTinTiecCuoi(DTO.DTO_TiecCuoi s)
        {
            return DAO.DAO_TiecCuoi.capNhatThongTinTiecCuoi(s);
        }
        public static bool themTiecCuoi(DTO.DTO_TiecCuoi s)
        {
            return DAO.DAO_TiecCuoi.themTiecCuoi(s);
        }
        public static bool themDatMonAn(DTO.DTO_DatMonAn dma)
        {
            return DAO.DAO_DatMonAn.themDatMonAn(dma);
        }
        public static bool xoaDatMonAn(DTO.DTO_DatMonAn dma)
        {
            return DAO.DAO_DatMonAn.xoaDatMonAn(dma);
        }
        public static bool themDatDichVu(DTO_DatDichVu ddv)
        {
            return DAO.DAO_DatDichVu.themDatDichVu(ddv);
        }
        public static bool xoaDatDichVu(DTO_DatDichVu ddv)
        {
            return DAO.DAO_DatDichVu.xoaDatDichVu(ddv);
        }
    }
}
