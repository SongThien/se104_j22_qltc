using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TiecCuoi
    {
        public DTO_TiecCuoi()
        {
        }

        public DTO_TiecCuoi(string maTC, string maKH, string maS, string ngayToChuc, string maCa, int tienDatCoc, int slBan, int slDuTru)
        {
            MA_TIEC_CUOI = maTC;
            MA_KHACH_HANG = maKH;
            MA_SANH = maS;
            NGAY_TO_CHUC = ngayToChuc;
            MA_CA = maCa;
            TIEN_DAT_COC = tienDatCoc;
            SL_BAN = slBan;
            SL_BAN_DU_TRU = SL_BAN_DU_TRU;
        }

        public string MA_TIEC_CUOI { get; set; }
        public string MA_KHACH_HANG { get; set; }
        public string MA_SANH { get; set; }
        public string NGAY_TO_CHUC { get; set; }
        public string MA_CA { get; set; }
        public int TIEN_DAT_COC { get; set; }
        public int SL_BAN { get; set; }
        public int SL_BAN_DU_TRU { get; set; }
    }
}