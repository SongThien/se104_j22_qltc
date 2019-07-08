﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {

        public string MA_KHACH_HANG { get; set; }
        public string TEN_CHU_RE { get; set; }
        public string TEN_CO_DAU { get; set; }
        public string NS_CHU_RE { get; set; }
        public string NS_CO_DAU { get; set; }
        public string SDT { get; set; }
       

        public DTO_KhachHang(string maKH, string tenChuRe, string tenCoDau,string nsChuRe, string nsCoDau, string sdt)
        {
            MA_KHACH_HANG = maKH;
            TEN_CHU_RE = tenChuRe;
            TEN_CO_DAU = tenCoDau;
            NS_CHU_RE = nsChuRe;
            NS_CO_DAU = nsCoDau;
            SDT = sdt;
            
        }

        public DTO_KhachHang()
        {
        }

        public static implicit operator DTO_KhachHang(DTO_Sanh v)
        {
            throw new NotImplementedException();
        }
    }
}