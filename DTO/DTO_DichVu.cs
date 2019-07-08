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
        public decimal DON_GIA { get; set; }
        public string GhiChu { get; set; }
        public string HinhAnh { get; set; }

        public DTO_DichVu(string maDichVu, string tenDichVu, string donGia, string ghiChu, string hinhAnh)
        {
            MA_DICH_VU = maDichVu;
            TEN_DICH_VU = tenDichVu;
            DON_GIA = long.Parse(donGia);

        }
    }
}