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
    }
}
