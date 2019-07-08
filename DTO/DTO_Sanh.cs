using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sanh
    {
        public DTO_Sanh() { }
        public DTO_Sanh(string maSanh, string tenSanh,  string loaiSanh, string soLuongBan, string ghiChu)
        {
            this.MA_SANH = maSanh;
            this.TEN_SANH = tenSanh;
            this.MA_LOAI_SANH = loaiSanh;
            this.SL_BAN_TOI_DA = int.Parse(soLuongBan);
            this.GHI_CHU = ghiChu;
        }
        public string MA_SANH { get; set; }
        public string TEN_SANH { get; set; }
        public string MA_LOAI_SANH { get; set; }
        public int SL_BAN_TOI_DA { get; set; }
        public string GHI_CHU { get; set; }
    }
}
