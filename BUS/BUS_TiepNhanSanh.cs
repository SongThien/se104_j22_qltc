using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public static class BUS_TiepNhanSanh
    {
        
        public static DataTable GetLoaiSanhTable()
        {
            return DAO_QuanLyLoaiSanh.GetLoaiSanhTable();
        }
        
        
        public static DataTable GetDataSanhTable()
        {
            return DAO_QuanLySanh.GetDataTableSanh();
        }
        public static String[] getDanhSachLoaiSanh()
        {
            return DAO.DAO_TiepNhanSanh.getDanhSachLoaiSanh();
        }
        public static String[] getDanhSachSanh()
        {
            return DAO.DAO_TiepNhanSanh.getDanhSachSanh();
        }
        public static bool themLoaiSanh(DTO.DTO_LoaiSanh ls)
        {
            return DAO.DAO_QuanLyLoaiSanh.themLoaiSanh(ls);
        }
        public static bool suaLoaiSanh(DTO.DTO_LoaiSanh ls)
        {
            return DAO.DAO_QuanLyLoaiSanh.suaLoaiSanh(ls);
        }
        public static bool xoaLoaiSanh(DTO.DTO_LoaiSanh ls)
        {
            return DAO.DAO_QuanLyLoaiSanh.xoaLoaiSanh(ls);
        }
        public static bool themSanh(DTO.DTO_Sanh s)
        {
            return DAO.DAO_QuanLySanh.themSanh(s);
        }
        public static bool suaSanh(DTO.DTO_Sanh s)
        {
            return DAO.DAO_QuanLySanh.suaSanh(s);
        }
        public static bool xoaSanh(DTO.DTO_Sanh s)
        {
            return DAO.DAO_QuanLySanh.xoaSanh(s);
        }
        public static DTO.DTO_LoaiSanh getThongTinLoaiSanh(String maLS)
        {
            return DAO.DAO_QuanLyLoaiSanh.getThongTinLoaiSanh(maLS);
        }

    }
}
