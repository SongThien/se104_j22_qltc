using System;
using System.Data;

namespace BUS
{
    public class Class2
    {
        public static DataTable getData()
        {
            return DAO.KhachHang.getTatCa();
        }

    }
}
