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
    public partial class Frm_ThemKhachHang : Form
    {
        public Frm_ThemKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();

            kh.idKhachHang = txt_MaKhachHang.Text;
            kh.tenKhachHang = txt_TenKhachHang.Text;
            kh.ngaySinh = DateTime.Parse(txt_NgaySinh.Text);
            if (rd_Nam.Checked == true)
                kh.gioiTinh = rd_Nam.Text;
            else
                kh.gioiTinh = rd_Nu.Text;
            kh.diaChi = txt_DiaChi.Text;
            kh.sdt = txt_sodienthoai.Text;
            kh.email = txt_email.Text;
            KhachHangBUS khbus = new KhachHangBUS();
            bool kq = khbus.themkhachhang(kh);
            if (kq)
            {
                DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    Frm_ThemKhachHang frm = new Frm_ThemKhachHang();
                    this.Close();
                }
            }
        }
    }
}
