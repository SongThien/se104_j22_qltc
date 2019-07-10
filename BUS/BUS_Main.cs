using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace BUS
{
    public static class BUS_Main
    {
        public static bool thuKetNoi()
        {
            DataTable d = DAO.DatabaseHelper.GetData("SELECT CONVERT(int, 25.65);");
            if (d.Rows.Count > 0)
                return true;
            return false;
        }

        public static bool taoKetNoi()
        {
            try
            {
                string cnnstring = File.ReadAllText("CONNECTION_STRING.ini");
                DAO.DatabaseHelper.CONNECTION_STRING = cnnstring.Trim();
                Console.WriteLine(cnnstring.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
