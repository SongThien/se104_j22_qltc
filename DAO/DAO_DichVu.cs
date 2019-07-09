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
    public static class DAO_DichVu
    {
        public static DataTable GetDataTableDichVu()
        {
            string query = @"SELECT * FROM DICH_VU";
            return DatabaseHelper.GetData(query);
        }
        public static bool themDV(DTO.DTO_DichVu dv)
        {
            string sTruyVan = string.Format(@"INSERT INTO DICH_VU(MA_DICH_VU, TEN_DICH_VU,DON_GIA) values ('{0}','{1}',{2})", dv.MA_DICH_VU,dv.TEN_DICH_VU, dv.DON_GIA);
            Console.WriteLine(sTruyVan);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool suaDV(DTO.DTO_DichVu dv)
        {
            string sTruyVan = string.Format(@"UPDATE DICH_VU SET TEN_DICH_VU='{1}', DON_GIA='{2}' where MA_DICH_VU = '{0}'", dv.MA_DICH_VU, dv.TEN_DICH_VU, dv.DON_GIA);
            Console.WriteLine(sTruyVan);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool xoaDV(DTO.DTO_DichVu dv)
        {
            string sTruyVan = string.Format(@"delete from DICH_VU where MA_DICH_VU = '{0}'", dv.MA_DICH_VU);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
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
                result.DON_GIA = int.Parse(row["DON_GIA"].ToString());
            }
            return result;
        }
    }
}
