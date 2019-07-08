using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    class BUS_QuanLyLoaiSanh
    {
        public static DataTable GetLoaiSanhTable()
        {
            return DAO_QuanLyLoaiSanh.GetLoaiSanhTable();
        }
    }
}
