using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangAccess kh = new KhachHangAccess();
        public bool themkhachhang(KhachHang khh)
        {
            return kh.ThemKhachHang(khh);
        }
    }
}
