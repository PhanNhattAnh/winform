using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapHang
    {
        public string phieuNhapID {  get; set; }
        public string nhaCungCapID { get; set; }
       
        public DateTime ngayNhap { get; set; }
        public int tongTien { get; set; }

        public NhapHang() { }
    }
}
