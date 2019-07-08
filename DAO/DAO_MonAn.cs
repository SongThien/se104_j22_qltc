using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public static class DAO_MonAn
    {
        public static (String[], String[]) getDanhSachTenMonAn()
        {
            String sql = @"SELECT MA_MON_AN, TEN_MON_AN FROM MON_AN";
            DataTable ds = DatabaseHelper.GetData(sql);
            List<String> result1 = new List<String>();
            List<String> result2 = new List<String>();
            if (ds != null)
            {
                foreach (DataRow row in ds.Rows)
                {
                    result1.Add(row[0].ToString().Trim());
                    result2.Add(row[1].ToString().Trim());
                }

                return (result1.ToArray(), result2.ToArray());
            }
            return (null, null);
        }
        public static DTO.DTO_MonAn getThongTinMonAn(String maMa)
        {
            DTO.DTO_MonAn result = null;
            String sql = String.Format(@"SELECT * FROM MON_AN WHERE MA_MON_AN = '{0}'", maMa);
            DataTable da = DatabaseHelper.GetData(sql);
            if (da.Rows.Count > 0)
            {
                result = new DTO.DTO_MonAn();
                DataRow row = da.Rows[0];
                Console.WriteLine("sdfsf  {0}", row.ToString());
                result.MA_MON_AN = maMa;
                result.TEN_MON_AN = row["TEN_MON_AN"].ToString();
                result.DON_GIA = decimal.Parse(row["DON_GIA"].ToString());
            }
            return result;
        }
    }
}
