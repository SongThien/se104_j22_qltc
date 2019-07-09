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
    public class BUS_QuanLyDichVu
    {
        public static DataTable GetDataTableDichVu()
        {
            return DAO_DichVu.GetDataTableDichVu();
        }
        public static String[] getDsMaDichVu()
        {
            return DAO_DichVu.getDsMaDichVu();
        }
        public static bool themDV(DTO.DTO_DichVu dv)
        {
            return DAO.DAO_DichVu.themDV(dv);
        }
        public static bool suaDV(DTO.DTO_DichVu dv)
        {
            return DAO.DAO_DichVu.suaDV(dv);
        }
        public static bool xoaDV(DTO.DTO_DichVu dv)
        {
            return DAO.DAO_DichVu.xoaDV(dv);
        }
    }
}
