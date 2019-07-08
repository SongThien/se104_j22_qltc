using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAO
{
    public class DAO_Sanh
    {
        public static DTO.DTO_Sanh getThongTinSanh(String maS)
        {
            String sql = String.Format(@"SELECT * FROM SANH WHERE MA_SANH = '{0}'", maS);
            DataTable da = DatabaseHelper.GetData(sql);
            DTO.DTO_Sanh result = null;
            if (da.Rows.Count > 0)
            {
                result = new DTO.DTO_Sanh();
                DataRow row = da.Rows[0];
                result.MA_SANH = maS;
                result.TEN_SANH = row["TEN_SANH"].ToString();
                result.MA_LOAI_SANH = row["MA_LOAI_SANH"].ToString();
                result.SO_LUONG_TOI_DA = int.Parse(row["SO_LUONG_TOI_DA"].ToString());
                result.GHI_CHU = row["GHI_CHU"].ToString();
            }
            return result;
        }

    }
}
