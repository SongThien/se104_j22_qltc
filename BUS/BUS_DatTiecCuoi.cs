using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;

namespace BUS
{
    public static class BUS_DatTiecCuoi
    {
        public static String[] getDanhSachMaKhachHang()
        {
            return DAO.DAO_KhachHang.getDanhSachMaKhachHang();
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
        public static DTO.DTO_LoaiSanh getThongTinLoaiSanh(string maLS)
        {
            return DAO.DAO_QuanLyLoaiSanh.getThongTinLoaiSanh(maLS);
        }
        public static String[] getDanhSachMaLoaiSanh()
        {
            return DAO.DAO_TiepNhanSanh.getDanhSachLoaiSanh();
        }

        public static String[] getDanhSachMaCa()
        {
            return DAO.DAO_Ca.getDanhSachMaCa();
        }

        public static String[] getDanhSachMaSanh()
        {
            return DAO.DAO_TiepNhanSanh.getDanhSachSanh();
        }

        public static DTO_DichVu getThongTinDichVu(String maDV)
        {
            return DAO.DAO_DichVu.getThongTinDichVu(maDV);
        }
        public static bool kiemTraSanhTrong(string matc, string sa, string ngay, string ca)
        {
            return DAO.DAO_TiecCuoi.kiemTraSanhTrong(matc, sa, ngay, ca);
        }
        public static String[] getDsMaTiecCuoiDaThanhToan()
        {
            return DAO.DAO_TiecCuoi.getDsMaTiecCuoiDaThanhToan();
        }

        public static bool xoaTiecCuoi(string ma)
        {
            DAO.DAO_DatMonAn.xoaDatMonAn(ma);
            DAO.DAO_DatDichVu.xoaDatDichVu(ma);
            return DAO.DAO_TiecCuoi.xoaTiecCuoi(ma);
        }
    }
}
