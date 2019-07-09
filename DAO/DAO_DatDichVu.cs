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
            String sql = String.Format(@"SELECT DAT_DICH_VU.MA_DICH_VU, TEN_DICH_VU, SO_LUONG FROM DAT_DICH_VU , DICH_VU WHERE MA_TIEC_CUOI = '{0}', DAT_MON_AN.MA_DICH_VU = DICH_VU.MA_DICH_VU", maTC);
            DataTable ds;
            ds = DatabaseHelper.GetData(sql);
            return ds;
        }
    }
}
