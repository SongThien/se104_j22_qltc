using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public static class DAO_Ca
    {
        public static DataTable GetDataTableCa()
        {
            string query = @"SELECT * FROM CA";
            return DatabaseHelper.GetData(query);
        }
        public static bool themCa(DTO.DTO_Ca ca)
        {
            string sTruyVan = string.Format(@"INSERT INTO CA(MA_CA, TG_BAT_DAU,TG_KET_THUC) values ('{0}','{1}','{2}')", ca.MA_CA, ca.TG_BAT_DAU,ca.TG_KET_THUC);
            Console.WriteLine(sTruyVan);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool suaCa(DTO.DTO_Ca ca)
        {
            string sTruyVan = string.Format(@"UPDATE CA SET TG_BAT_DAU='{1}', TG_KET_THUC='{2}' where MA_CA = '{0}'", ca.MA_CA, ca.TG_BAT_DAU, ca.TG_KET_THUC);
            Console.WriteLine(sTruyVan); 
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool xoaCa(DTO.DTO_Ca ca)
        {
            string sTruyVan = string.Format(@"delete from CA where MA_CA = '{0}'", ca.MA_CA);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
        public static DTO.DTO_Ca getThongTinCa(String maCa)
        {
            String sql = String.Format(@"SELECT * FROM CA WHERE MA_CA = '{0}'", maCa);
            DataTable da = DatabaseHelper.GetData(sql);
            DTO.DTO_Ca result = null;
            if (da.Rows.Count > 0)
            {
                result = new DTO.DTO_Ca();
                DataRow row = da.Rows[0];
                result.MA_CA = maCa;
                result.TG_BAT_DAU = row["TG_BAT_DAU"].ToString();
                result.TG_KET_THUC = row["TG_KET_THUC"].ToString();
            }
            return result;
        }
        public static String[] getDanhSachMaCa()
        {
            String sql = @"SELECT MA_CA FROM CA";
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
