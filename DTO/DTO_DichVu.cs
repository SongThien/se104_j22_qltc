using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DichVu
    {
        public string MA_DICH_VU { get; set; }
        public string TEN_DICH_VU { get; set; }
        public int DON_GIA { get; set; }

        public DTO_DichVu(string maDichVu, string tenDichVu, string donGia)
        {
            MA_DICH_VU = maDichVu;
            TEN_DICH_VU = tenDichVu;
            DON_GIA = int.Parse(donGia);

        }
        public DTO_DichVu()
        { }
    }
}