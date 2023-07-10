using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class DatLichBUS
    {
        DatLichAccess dl = new DatLichAccess();
        public List<DatLich> laytoanbosanpham()
        {
            return dl.laytoanbosanpham();
        }
        public bool xoadatlich(string madatlich)
        {
            return dl.xoadatlich(madatlich);
        }
        public bool themdatlich(DatLich dll)
        {
            return dl.Themdatlich(dll);
        }
        public bool suadatlich(DatLich dll)
        {
            return dl.Suadatlich(dll);
        }
    }
}
