using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiSanh
    {
        public DTO_LoaiSanh() { }
        public DTO_LoaiSanh(string maLoaiSanh, string tenLoaiSanh, int donGiaToiThieu)
        {
            this.MA_LOAI_SANH = maLoaiSanh;
            this.TEN_LOAI_SANH = tenLoaiSanh;
            this.DON_GIA_TOI_THIEU = donGiaToiThieu;
        }
        public string MA_LOAI_SANH;
        public string TEN_LOAI_SANH { get; set; }
        public int DON_GIA_TOI_THIEU { get; set; }
    }
}