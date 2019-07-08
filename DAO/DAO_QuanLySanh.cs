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
    public static class DAO_QuanLySanh
    {
        public static DataTable GetDataTableSanh()
        {
            string query = @"SELECT * FROM SANH";
            return DatabaseHelper.GetData(query);
        }
        public static bool themSanh(DTO.DTO_Sanh s)
        {
            string sTruyVan = string.Format(@"INSERT INTO SANH(MA_SANH, TEN_SANH,MA_LOAI_SANH, SO_LUONG_BAN) values ('{0}','{1}','{2}',{3})", s.MA_SANH, s.TEN_SANH,s.MA_LOAI_SANH ,s.SO_LUONG_BAN);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool suaSanh(DTO.DTO_Sanh s)
        {
            string sTruyVan = string.Format(@"UPDATE SANH SET TEN_SANH='{1}', MA_LOAI_SANH='{2}', SO_LUONG_BAN='{3}' where MA_SANH = '{0}'", s.MA_SANH, s.TEN_SANH, s.MA_LOAI_SANH, s.SO_LUONG_BAN);
            if (DatabaseHelper.ExcuteSql(sTruyVan) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
