using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        public string chiTietPhieuNhapID { get; set; }
        public string phieuNhapID { get; set; }
        public string sanPhamID { get; set; }
        public int soLuong { get; set; }
        public int giaNhap { get; set; }
        
        public ChiTietPhieuNhap() { }
    }
}
