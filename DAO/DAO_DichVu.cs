using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DAO
{
    public static class DAO_DichVu
    {
        public static (String[], String[]) getDanhSachDichVu()
        {
            String sql = @"SELECT MA_DICH_VU, TEN_DICH_VU FROM DICH_VU";
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

                return (result1.ToArray(),result2.ToArray());
            }
            return (null,null);
        }
        public static DTO.DTO_DichVu getThongTinDichVu(String maDV)
        {
            DTO.DTO_DichVu result = null;
            String sql = String.Format(@"SELECT * FROM DICH_VU WHERE MA_DICH_VU = '{0}'", maDV);
            DataTable da = DatabaseHelper.GetData(sql);
            if (da.Rows.Count > 0)
            {
                result = new DTO.DTO_DichVu();
                DataRow row = da.Rows[0];
                result.MA_DICH_VU = maDV;
                result.TEN_DICH_VU = row["TEN_DICH_VU"].ToString();
                result.DON_GIA = decimal.Parse(row["DON_GIA"].ToString());
            }
            return result;
        }
    }
}
