using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_NhaCungCap : Form
    {
        public Frm_NhaCungCap()
        {
            InitializeComponent();
        }

        private void Frm_NhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhaCungCap kh = new NhaCungCap();

            kh.nhaCungCapID = txt_MaNCC.Text;
            kh.tenNhaCungCap = txt_TenNCC.Text;
            
            kh.diaChi = txt_DiaChi.Text;
            kh.soDienThoai = txt_sodienthoai.Text;
            
            NhaCungCapBUS nccbus = new NhaCungCapBUS();
            bool kq = nccbus.themNhaCungCap(kh);
            if (kq)
            {
                DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    Frm_NhaCungCap frm = new Frm_NhaCungCap();
                    this.Close();
                }
            }
        }
    }
}
