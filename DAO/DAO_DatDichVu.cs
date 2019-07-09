using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public static class DAO_DatDichVu
    {
        public static DataTable getDsDichVuDaDat(String maTC)
        {
            String sql = String.Format(@"SELECT DAT_DICH_VU.MA_DICH_VU, TEN_DICH_VU, DON_GIA, SO_LUONG FROM DAT_DICH_VU , DICH_VU WHERE MA_TIEC_CUOI = '{0}' AND DAT_DICH_VU.MA_DICH_VU = DICH_VU.MA_DICH_VU", maTC);
            DataTable ds;
            ds = DatabaseHelper.GetData(sql);
            return ds;
        }
        public static bool themDatDichVu(DTO.DTO_DatDichVu s)
        {
            String sql = String.Format(@"INSERT INTO DAT_DICH_VU (MA_TIEC_CUOI, MA_DICH_VU, SO_LUONG) VALUES ('{0}','{1}',{2})",
                s.MA_TIEC_CUOI, s.MA_DICH_VU, s.SO_LUONG);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool xoaDatDichVu(DTO.DTO_DatDichVu s)
        {
            String sql = String.Format(@"DELETE FROM DAT_DICH_VU WHERE MA_TIEC_CUOI = '{0}' AND MA_DICH_VU = '{1}'",
                s.MA_TIEC_CUOI, s.MA_DICH_VU);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
