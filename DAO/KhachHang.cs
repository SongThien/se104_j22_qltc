using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Forms;

namespace DAO
{
    public class KhachHang
    {
        public static DataTable getTatCa()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Demodb;User ID=sa;Password=demol23");
            cnn.Open();
            String sql = @"Select * from KHACH_HANG";
            DataTable result = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            cnn.Close();
            da.Fill(result);
            return result;
        }
    }
}
