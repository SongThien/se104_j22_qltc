using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public static class DAO_ChiTietBaoCao
    {
        public static bool themBaoCaoNgay(DTO.DTO_ChiTietBaoCao bc)
        {
            String sql = String.Format(@"INSERT INTO CHI_TIET_BAO_CAO (MA_BAO_CAO, NGAY, SO_LUONG, DOANH_THU) VALUES ('{0}','{1}',{2}, {3})",
                bc.MA_BAO_CAO, bc.NGAY, bc.SO_LUONG, bc.DOANH_THU);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool capNhatBaoCaoNgay(DTO.DTO_ChiTietBaoCao bc)
        {
            String sql = String.Format(@"UPDATE CHI_TIET_BAO_CAO SET NGAY={2}, TONG_DOANH_THU={3} WHERE MA_BAO_CAO='{0}' AND NGAY={1}",
                bc.MA_BAO_CAO, bc.NGAY, bc.SO_LUONG, bc.DOANH_THU);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool checkBaoCaoNgay(DTO.DTO_ChiTietBaoCao bc)
        {
            String sql = String.Format(@"SELECT * FROM CHI_TIET_BAO_CAO WHERE MA_BAO_CAO = '{0}' AND NGAY= '{1}'", bc.MA_BAO_CAO, bc.NGAY);
            return DatabaseHelper.CheckIfExists(sql);

        }
    }
}
