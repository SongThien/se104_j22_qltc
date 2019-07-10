using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public static class BUS_BaoCaoThang
    {
        public static DataTable getHoaDonTrongThang(string nam, string thang)
        {
            return DAO.DAO_BaoCaoDoanhSo.getHoaDonThang(nam,thang);
        }
    }
}
