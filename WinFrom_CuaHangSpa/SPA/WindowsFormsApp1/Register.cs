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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        

       

        

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btn_dangki.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btn_dangki.ForeColor = Color.PaleVioletRed;
        }

        private void taikhoan_Click(object sender, EventArgs e)
        {
            txt_hoten.SelectAll();
        }



        

        

        

        private void matkhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (matkhau.Text == "")
                {
                    matkhau.Text = "Mật Khẩu";
                    return;
                }
                matkhau.ForeColor = Color.White;
                panel11.Visible = false;
            }
            catch
            {

            }
        }

        private void gmail_Click(object sender, EventArgs e)
        {
            txt_taikhoan.SelectAll();
        }

        private void matkhau_Click(object sender, EventArgs e)
        {
            matkhau.SelectAll();
        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_hoten.Text == "")
                {
                    txt_hoten.Text = "Họ Tên";
                    return;
                }
                txt_hoten.ForeColor = Color.White;
                panel4.Visible = false;

            }
            catch
            {
            }
        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_hoten.Text == "")
                {
                    txt_hoten.Text = "Tài Khoản";
                    return;
                }
                txt_taikhoan.ForeColor = Color.White;
                panel7.Visible = false;

            }
            catch
            {
            }
        }

        private void txt_NgaySinh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_NgaySinh.Text == "")
                {
                    txt_NgaySinh.Text = "Ngày Sinh";
                    return;
                }
                txt_NgaySinh.ForeColor = Color.White;
                panel15.Visible = false;

            }
            catch
            {
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

            txt_ChucVu.Text = "Nhân Viên";
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();

                nv.TenNhanVien = txt_hoten.Text;
                nv.TenTaiKhoan = txt_taikhoan.Text;
                nv.MatKhau = matkhau.Text;
                nv.NgaySinh = DateTime.Parse(txt_NgaySinh.Text);
                nv.ChucVu = txt_ChucVu.Text;
                if (rd_Nam.Checked == true)
                    nv.GioiTinh = rd_Nam.Text;
                else
                    nv.GioiTinh = rd_Nu.Text;
                NhanVienBUS nvbus = new NhanVienBUS();
                bool kq = nvbus.themNhanVien(nv);
                if (kq)
                {
                    DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tb == DialogResult.OK)
                    {
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                if (txt_hoten.Text == "Họ Tên" && txt_taikhoan.Text == "Tài Khoản" && matkhau.Text == "Mật Khẩu")
                {

                    panel4.Visible = true;
                    panel7.Visible = true;
                    panel11.Visible = true;
                    panel15.Visible = true;
                    txt_hoten.Focus();
                    txt_taikhoan.Focus();
                    matkhau.Focus();
                    return;
                }
            }
        }

        private void txt_NgaySinh_Click(object sender, EventArgs e)
        {
            txt_NgaySinh.SelectAll();
        }
    }
}
