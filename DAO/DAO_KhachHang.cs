using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DAO
{
    public static class DAO_KhachHang
    {
        public static String[] getDanhSachKhachHang()
        {
            String sql = @"SELECT MA_KHACH_HANG FROM KHACH_HANG";
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

        public static DTO.DTO_KhachHang getThongTinKhachHang(String maKH)
        {
            String sql = String.Format(@"SELECT * FROM KHACH_HANG WHERE MA_KHACH_HANG = '{0}'", maKH);
            Console.WriteLine(sql);
            DataTable da = DatabaseHelper.GetData(sql);
            Console.WriteLine("sdfsf  {0}",da.ToString());
            DTO.DTO_KhachHang result = null;
            if (da.Rows.Count > 0)
            {
                result = new DTO.DTO_KhachHang();
                DataRow row = da.Rows[0];
                Console.WriteLine("sdfsf  {0}", row.ToString());
                result.MA_KHACH_HANG = maKH;
                result.TEN_CHU_RE = row["TEN_CHU_RE"].ToString();
                result.TEN_CO_DAU = row["TEN_CO_DAU"].ToString();
                result.SDT = row["SDT"].ToString();
            }
            return result;
        }

        public static bool themKhachHang(DTO.DTO_KhachHang kh)
        {
            String sql = String.Format(@"INSERT INTO KHACH_HANG (MA_KHACH_HANG, TEN_CHU_RE, TEN_CO_DAU,SDT) VALUES ('{0}','{1}','{2}',{3})", kh.MA_KHACH_HANG, kh.TEN_CHU_RE, kh.TEN_CO_DAU, kh.SDT);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;

        }
    }
}
