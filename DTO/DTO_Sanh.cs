using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sanh
    {
        public DTO_Sanh(string maSanh, string tenSanh,string maLoaiSanh ,string soLuongBan)
        {
            this.MA_SANH = maSanh;
            this.TEN_SANH = tenSanh;
            this.MA_LOAI_SANH = maLoaiSanh;
            this.SO_LUONG_BAN = int.Parse(soLuongBan);
        }
        public string MA_SANH { get; set; }
        public string TEN_SANH { get; set; }
        public int SO_LUONG_BAN { get; set; }
        public string MA_LOAI_SANH { get; set; }
        public string GHI_CHU {get;set; }
    }
}
