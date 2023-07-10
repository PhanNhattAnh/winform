using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienAccess kh = new NhanVienAccess();
        public bool themNhanVien(NhanVien nv)
        {
            return kh.ThemNhanVien(nv);
        }
    }
}
