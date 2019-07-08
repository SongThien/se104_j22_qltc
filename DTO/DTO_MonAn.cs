using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonAn
    {
        public string MA_MON_AN { get; set; }
        public string TEN_MON_AN { get; set; }
        public decimal DON_GIA { get; set; }
  
        public DTO_MonAn(string maMonAn, string tenMonAn, string loaiMonAn, string donGia)
        {
            MA_MON_AN = maMonAn;
            TEN_MON_AN = tenMonAn;
            DON_GIA = long.Parse(donGia);
        }
    }
}