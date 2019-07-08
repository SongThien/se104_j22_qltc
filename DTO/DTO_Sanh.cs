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
        public DTO_Sanh(string maSanh, string donGiaBan, string donGiaToiThieu)
        {
            this.MA_SANH = maSanh;
            this.TEN_SANH = long.Parse(donGiaBan);
            this.DON_GIA_TOI_THIEU = int.Parse(donGiaToiThieu);
        }
        public string MA_SANH { get; set; }
        public long TEN_SANH { get; set; }
        public int DON_GIA_TOI_THIEU { get; set; }
    }
}
