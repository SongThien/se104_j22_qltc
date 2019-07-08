using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_QuanLyLoaiSanh
    {
        public static DataTable GetLoaiSanhTable()
        {
            string sqlCommand = @"SELECT * FROM LOAI_SANH";
            return DatabaseHelper.GetData(sqlCommand);
        }
        public static bool themLoaiSanh(DTO.DTO_LoaiSanh ls)
        {
            string sTruyVan = string.Format(@"INSERT INTO LOAI_SANH(MA_LOAI_SANH, TEN_LOAI_SANH, DON_GIA_TOI_THIEU) values ('{0}','{1}',{2})", ls.MA_LOAI_SANH, ls.TEN_LOAI_SANH, ls.DON_GIA_TOI_THIEU);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool suaLoaiSanh(DTO.DTO_LoaiSanh ls)
        {
            string sTruyVan = string.Format(@"UPDATE LOAI_SANH SET TEN_LOAI_SANH='{1}', DON_GIA_TOI_THIEU='{2}' where MA_LOAI_SANH = '{0}'",ls.MA_LOAI_SANH,ls.TEN_LOAI_SANH, ls.DON_GIA_TOI_THIEU);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool xoaLoaiSanh(DTO.DTO_LoaiSanh ls)
        {
            string sTruyVan = string.Format(@"delete from LOAI_SANH where MA_LOAI_SANH = '{0}'", ls.MA_LOAI_SANH);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
        public static DTO.DTO_LoaiSanh getThongTinLoaiSanh(String maLS)
        {
            String sql = String.Format(@"SELECT * FROM LOAI_SANH WHERE MA_LOAI_SANH = '{0}'", maLS);
            DataTable da = DatabaseHelper.GetData(sql);
            DTO.DTO_LoaiSanh result = null;
            if (da.Rows.Count > 0)
            {
                result = new DTO.DTO_LoaiSanh();
                DataRow row = da.Rows[0];
                result.MA_LOAI_SANH = maLS;
                result.TEN_LOAI_SANH = row["TEN_LOAI_SANH"].ToString();
                result.DON_GIA_TOI_THIEU = int.Parse(row["DON_GIA_TOI_THIEU"].ToString());
            }
            return result;
        }
    }
}
