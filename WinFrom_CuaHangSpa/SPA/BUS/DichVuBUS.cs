using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVuBUS
    {
        DichVuAccess dv = new DichVuAccess();
        public List<DichVu> laytoanbosanpham()
        {
            return dv.laytoanbosanpham();
        }
        public bool xoadichvu(string madichvu)
        {
            return dv.xoadichvu(madichvu);
        }
        public bool themdichvu(DichVu dvv)
        {
            return dv.Themdichvu(dvv);
        }
        public bool suadichvu(DichVu dvv)
        {
            return dv.Suadichvu(dvv);
        }
    }
}
