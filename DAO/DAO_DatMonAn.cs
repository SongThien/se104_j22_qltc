using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public static class DAO_DatMonAn
    {
        public static DataTable getDsMonAnDaDat(String maTC)
        {
            String sql = String.Format(@"SELECT DAT_MON_AN.MA_MON_AN, TEN_MON_AN, DON_GIA, GHI_CHU FROM DAT_MON_AN , MON_AN WHERE MA_TIEC_CUOI = '{0}' AND DAT_MON_AN.MA_MON_AN = MON_AN.MA_MON_AN", maTC);
            DataTable ds;
            ds = DatabaseHelper.GetData(sql);
            return ds;
        }
        public static bool themDatMonAn(DTO.DTO_DatMonAn s)
        {
            String sql = String.Format(@"INSERT INTO DAT_MON_AN (MA_TIEC_CUOI, MA_MON_AN, GHI_CHU) VALUES ('{0}','{1}','{2}')",
                s.MA_TIEC_CUOI,s.MA_MON_AN, s.GHI_CHU);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool xoaDatMonAn(DTO.DTO_DatMonAn s)
        {
            String sql = String.Format(@"DELETE FROM DAT_MON_AN WHERE MA_TIEC_CUOI = '{0}' AND MA_MON_AN = '{1}'",
                s.MA_TIEC_CUOI, s.MA_MON_AN);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool xoaDatMonAn(string s)
        {
            String sql = String.Format(@"DELETE FROM DAT_MON_AN WHERE MA_TIEC_CUOI = '{0}'",s);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
