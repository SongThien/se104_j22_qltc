using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public static class DAO_TiecCuoi
    {
        public static String[] getDsMaTiecCuoi()
        {
            String sql = @"SELECT MA_TIEC_CUOI FROM TIEC_CUOI";
            DataTable ds = DatabaseHelper.GetData(sql);
            List<String> result = new List<String>();
            if (ds != null)
            {
                foreach (DataRow row in ds.Rows)
                {
                    result.Add(row[0].ToString().Trim());
                }

                return result.ToArray();
            }
            return null;
        }
        public static DTO.DTO_TiecCuoi getThongTinTiecCuoi(String maTC)
        {
            String sql = String.Format(@"SELECT * FROM TIEC_CUOI WHERE MA_TIEC_CUOI = '{0}'", maTC);
            Console.WriteLine(sql);
            DataTable da = DatabaseHelper.GetData(sql);
            DTO.DTO_TiecCuoi result = null;
            if (da.Rows.Count > 0)
            {
                Console.WriteLine("ok");
                result = new DTO.DTO_TiecCuoi();
                DataRow row = da.Rows[0];
                result.MA_TIEC_CUOI = maTC;
                result.MA_SANH = row["MA_SANH"].ToString();
                result.MA_KHACH_HANG = row["MA_KHACH_HANG"].ToString();
                result.MA_CA = row["MA_CA"].ToString();
                result.NGAY_TO_CHUC = row["NGAY_TO_CHUC"].ToString();
                result.TIEN_DAT_COC = int.Parse(row["TIEN_DAT_COC"].ToString());
                result.SL_BAN = int.Parse(row["SL_BAN"].ToString());
                result.SL_BAN_DU_TRU = int.Parse(row["SL_BAN_DU_TRU"].ToString());
            }
            Console.WriteLine("ok");
            return result;
        }
    }
}
