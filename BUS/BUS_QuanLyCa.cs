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
    public class BUS_QuanLyCa
    {
        public static DataTable GetDataTableCa()
        {
            return DAO_Ca.GetDataTableCa();
        }
        public static bool themCa(DTO.DTO_Ca ca)
        {
            return DAO.DAO_Ca.themCa(ca);
        }
        public static bool suaCa(DTO.DTO_Ca ca)
        {
            return DAO.DAO_Ca.suaCa(ca);
        }
        public static bool xoaCa(DTO.DTO_Ca ca)
        {
            return DAO.DAO_Ca.xoaCa(ca);
        }
    }
}
