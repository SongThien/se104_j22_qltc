using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public static class BUS_DSTiecCuoi
    {
        public static DataTable getFullDsTiecCuoi()
        {
            return DAO.DAO_TiecCuoi.getFullDsTiecCuoi();
        }

        public static DataTable getDsTiecCuoiSapToi()
        {
            return DAO.DAO_TiecCuoi.getDsTiecCuoiSapToi();
        }
        public static DataTable getDsTiecCuoiTrongNgay(string s)
        {
            return DAO.DAO_TiecCuoi.getDsTiecCuoiTrongNgay(s);
        }
    }
}
