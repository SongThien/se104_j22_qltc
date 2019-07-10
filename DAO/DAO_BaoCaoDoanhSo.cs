using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public static class DAO_BaoCaoDoanhSo
    {
        public static DataTable getHoaDonThang(string nam, string thang)
        {
            String sql = String.Format(@"SELECT NGAY_THANH_TOAN, COUNT(MA_TIEC_CUOI), SUM(TONG_TIEN_HOA_DON)
                                        FROM HOA_DON_THANH_TOAN
                                        WHERE NGAY_THANH_TOAN LIKE '{0}-%{1}-%'
                                        GROUP BY NGAY_THANH_TOAN",nam,  thang);
            Console.WriteLine(sql);
            return DatabaseHelper.GetData(sql);
        }
        public static String[] getDanhSachMaBaoCao()
        {
            String sql = @"SELECT MA_BAO_CAO FROM BAO_CAO_DOANH_SO";
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

        public static bool themBaoCao(DTO.DTO_BaoCaoDoanhSo bc)
        {
            String sql = String.Format(@"INSERT INTO BAO_CAO_DOANH_SO (MA_BAO_CAO, THANG, TONG_DOANH_THU) VALUES ('{0}','{1}',{2})",
                bc.MA_BAO_CAO, bc.THANG, bc.TONG_DOANH_THU);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool capNhatBaoCao(DTO.DTO_BaoCaoDoanhSo bc)
        {
            String sql = String.Format(@"UPDATE BAO_CAO_DOANH_SO SET THANG='{1}', TONG_DOANH_THU={2} WHERE MA_BAO_CAO='{0}'",
                bc.MA_BAO_CAO, bc.THANG, bc.TONG_DOANH_THU);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
