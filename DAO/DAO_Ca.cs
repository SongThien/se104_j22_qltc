﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public static class DAO_Ca
    {
        public static DTO.DTO_Ca getThongTinCa(String maCa)
        {
            String sql = String.Format(@"SELECT * FROM CA WHERE MA_CA = '{0}'", maCa);
            DataTable da = DatabaseHelper.GetData(sql);
            DTO.DTO_Ca result = null;
            if (da.Rows.Count > 0)
            {
                result = new DTO.DTO_Ca();
                DataRow row = da.Rows[0];
                result.MA_CA = maCa;
                result.TG_BAT_DAU = row["TG_BAT_DAU"].ToString();
                result.TG_KET_THUC = row["TG_KET_THUC"].ToString();
            }
            return result;
        }
    }
}
