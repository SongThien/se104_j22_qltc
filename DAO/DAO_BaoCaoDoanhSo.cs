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
    }
}
