using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhapHangBUS
    {
        PhieuNhapHangAccess NH = new PhieuNhapHangAccess();
        public List<NhapHang> laytoanbosanpham()
        {
            return NH.laytoanbosanpham();
        }
        public bool xoaNhapHang(string maNhaphang)
        {
            return NH.xoaNhapHang(maNhaphang);
        }
        public bool themPhieunhap(NhapHang nh)
        {
            return NH.ThemNhapHang(nh);
        }
        public bool suaphienhap(NhapHang nh)
        {
            return NH.SuaNhaphang(nh);
        }
    }
}
