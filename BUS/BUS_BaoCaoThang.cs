using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public static class BUS_BaoCaoThang
    {
        
        public static DataTable getHoaDonTrongThang(string nam, string thang)
        {
            return DAO.DAO_BaoCaoDoanhSo.getHoaDonThang(nam,thang);
        }
        public static bool themBaoCao(DTO.DTO_BaoCaoDoanhSo s)
        {
            return DAO.DAO_BaoCaoDoanhSo.themBaoCao(s);
        }
        public static bool capNhatBaoCao(DTO.DTO_BaoCaoDoanhSo s)
        {
            return DAO.DAO_BaoCaoDoanhSo.capNhatBaoCao(s);
        }

        public static bool themBaoCaoNgay(DTO.DTO_ChiTietBaoCao s)
        {
            return DAO.DAO_ChiTietBaoCao.themBaoCaoNgay(s);
        }

        public static bool capNhatBaoCaoNgay(DTO.DTO_ChiTietBaoCao s)
        {
            return DAO.DAO_ChiTietBaoCao.capNhatBaoCaoNgay(s);
        }
        public static bool checkBaoCaoNgay(DTO.DTO_ChiTietBaoCao s)
        {
            return DAO.DAO_ChiTietBaoCao.checkBaoCaoNgay(s);
        }
    }
}
