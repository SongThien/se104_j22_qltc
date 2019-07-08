using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class DAO_TiepNhanSanh
    {
        public static string GetCurrentIndexTable()
        {
            return null;
        }
        public static String[] getDanhSachLoaiSanh()
        {
            String sql = @"SELECT MA_LOAI_SANH FROM LOAI_SANH";
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
        public static String[] getDanhSachSanh()
        {
            String sql = @"SELECT MA_SANH FROM SANH";
            DataTable ds = DatabaseHelper.GetData(sql);
            List<String> kq = new List<String>();
            if (ds != null)
            {
                foreach (DataRow row in ds.Rows)
                {
                    kq.Add(row[0].ToString().Trim());
                }
                return kq.ToArray();
            }
            return null;
        }

    }
}
