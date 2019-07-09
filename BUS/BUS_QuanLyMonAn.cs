using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public static class BUS_QuanLyMonAn
    {
        public static DataTable getDsMonAn()
        {
            return DAO.DAO_MonAn.getDsMonAn();
        }
        public static bool themMonAn(DTO.DTO_MonAn a)
        {
            return DAO.DAO_MonAn.themMonAn(a);
        }
        public static bool suaMonAn(DTO.DTO_MonAn a)
        {
            return DAO.DAO_MonAn.suaMonAn(a);
        }
        public static bool xoaMonAn(DTO.DTO_MonAn a)
        {
            return DAO.DAO_MonAn.xoaMonAn(a);
        }
        public static String[] getDsMaMonAn()
        {
            return DAO.DAO_MonAn.getDsMaMonAn();
        }
    }
}
