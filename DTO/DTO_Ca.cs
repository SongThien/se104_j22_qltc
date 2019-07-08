using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Ca
    {


        public DTO_Ca(string maCa, string thoiGianBD, string thoiGianKT)
        {
            MA_CA = maCa;
            TG_BAT_DAU = thoiGianBD;
            TG_KET_THUC = thoiGianKT;
        }

        public string MA_CA { get; set; }
        public string TG_BAT_DAU { get; set; }
        public string TG_KET_THUC { get; set; }
    }

}
