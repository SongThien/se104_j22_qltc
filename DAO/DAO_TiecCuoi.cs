using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

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
                result.MA_KHACH_HANG = row["MA_KHACH_HANG"].ToString();
                result.MA_SANH = row["MA_SANH"].ToString();                
                result.NGAY_TO_CHUC = row["NGAY_TO_CHUC"].ToString();
                result.MA_CA = row["MA_CA"].ToString();
                result.TIEN_DAT_COC = int.Parse(row["TIEN_DAT_COC"].ToString());
                result.SL_BAN = int.Parse(row["SL_BAN"].ToString());
                result.SL_BAN_DU_TRU = int.Parse(row["SL_BAN_DU_TRU"].ToString());
            }
            Console.WriteLine("ok");
            return result;
        }
        public static bool themTiecCuoi(DTO.DTO_TiecCuoi tc)
        {
            String sql = String.Format(@"INSERT INTO TIEC_CUOI (MA_TIEC_CUOI, MA_KHACH_HANG, MA_SANH, NGAY_TO_CHUC, MA_CA, TIEN_DAT_COC, SL_BAN, SL_BAN_DU_TRU) VALUES ('{0}','{1}','{2}','{3}','{4}',{5},{6},{7})",
                tc.MA_TIEC_CUOI, tc.MA_KHACH_HANG, tc.MA_SANH, tc.NGAY_TO_CHUC, tc.MA_CA, tc.TIEN_DAT_COC, tc.SL_BAN, tc.SL_BAN_DU_TRU);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool capNhatThongTinTiecCuoi(DTO.DTO_TiecCuoi tc)
        {
            String sql = String.Format(@"UPDATE TIEC_CUOI SET MA_KHACH_HANG = '{1}', MA_SANH = '{2}', NGAY_TO_CHUC = '{3}', MA_CA = '{4}', TIEN_DAT_COC = {5}, SL_BAN = {6}, SL_BAN_DU_TRU = {7} WHERE MA_TIEC_CUOI='{0}' ",
                tc.MA_TIEC_CUOI, tc.MA_KHACH_HANG, tc.MA_SANH, tc.NGAY_TO_CHUC, tc.MA_CA, tc.TIEN_DAT_COC, tc.SL_BAN, tc.SL_BAN_DU_TRU);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
        public static DataTable getFullDsTiecCuoi()
        {
            String sql = @"SELECT TEN_CHU_RE, TEN_CO_DAU, SDT, TEN_SANH, NGAY_TO_CHUC, MA_CA, SL_BAN FROM KHACH_HANG, TIEC_CUOI, SANH WHERE KHACH_HANG.MA_KHACH_HANG = TIEC_CUOI.MA_KHACH_HANG AND SANH.MA_SANH = TIEC_CUOI.MA_SANH";
            return DatabaseHelper.GetData(sql);
        }

        public static DataTable getDsTiecCuoiSapToi()
        {
            String now = DateTime.Today.ToString();
            String sql = String.Format(@"SELECT TEN_CHU_RE, TEN_CO_DAU, SDT, TEN_SANH, NGAY_TO_CHUC, MA_CA, SL_BAN FROM KHACH_HANG, TIEC_CUOI, SANH WHERE KHACH_HANG.MA_KHACH_HANG = TIEC_CUOI.MA_KHACH_HANG AND SANH.MA_SANH = TIEC_CUOI.MA_SANH AND NGAY_TO_CHUC >= '{0}'", now);
            return DatabaseHelper.GetData(sql);
        }
        public static DataTable getDsTiecCuoiTrongNgay(string s)
        {
            String sql = String.Format(@"SELECT TEN_CHU_RE, TEN_CO_DAU, SDT, TEN_SANH, NGAY_TO_CHUC, MA_CA, SL_BAN FROM KHACH_HANG, TIEC_CUOI, SANH WHERE KHACH_HANG.MA_KHACH_HANG = TIEC_CUOI.MA_KHACH_HANG AND SANH.MA_SANH = TIEC_CUOI.MA_SANH AND NGAY_TO_CHUC = '{0}'", s);
            return DatabaseHelper.GetData(sql);
        }
        public static bool kiemTraSanhTrong(string matc, string sa, string ngay, string ca)
        {
            String sql = String.Format(@"SELECT * FROM TIEC_CUOI WHERE MA_SANH = '{0}' AND NGAY_TO_CHUC = '{1}'AND MA_CA = '{2}' AND MA_TIEC_CUOI <> '{3}'",sa,ngay,ca, matc);
            Console.WriteLine(sql);
            if (DatabaseHelper.GetData(sql).Rows.Count < 1)
            {
                return true;
            }
            return false;
        }

        public static String[] getDsMaTiecCuoiChuaThanhToan()
        {
            String sql = @"SELECT MA_TIEC_CUOI FROM TIEC_CUOI WHERE MA_TIEC_CUOI NOT IN (SELECT MA_TIEC_CUOI FROM HOA_DON_THANH_TOAN)";
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

        public static String[] getDsMaTiecCuoiDaThanhToan()
        {
            String sql = @"SELECT MA_TIEC_CUOI FROM TIEC_CUOI WHERE MA_TIEC_CUOI IN (SELECT MA_TIEC_CUOI FROM HOA_DON_THANH_TOAN)";
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
        public static bool xoaTiecCuoi(string maTC)
        {
            String sql = String.Format(@"DELETE FROM TIEC_CUOI WHERE MA_TIEC_CUOI = '{0}'", maTC);
            Console.WriteLine(sql);
            if (DatabaseHelper.ExcuteSql(sql) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
