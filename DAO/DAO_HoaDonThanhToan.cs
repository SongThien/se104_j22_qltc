using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public class DAO_HoaDonThanhToan
    {
        public static bool themHoaDon(DTO.DTO_HoaDonThanhToan hd)
        {
            String sql = String.Format(@"INSERT INTO HOA_DON_THANH_TOAN (MA_HOA_DON, MA_TIEC_CUOI, NGAY_THANH_TOAN, TONG_TIEN_BAN, TONG_TIEN_DICH_VU, TONG_TIEN_HOA_DON) VALUES ('{0}','{1}','{2}',{3}, {4}, {5})",
                hd.MA_HOA_DON, hd.MA_TIEC_CUOI, hd.NGAY_THANH_TOAN, hd.TONG_TIEN_BAN, hd.TONG_TIEN_DICH_VU, hd.TONG_TIEN_HOA_DON);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public static String[] getDanhSachMaHoaDon()
        {
            String sql = @"SELECT MA_HOA_DON FROM HOA_DON_THANH_TOAN";
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
    }
}
