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
    }
}
