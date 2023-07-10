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

namespace WindowsFormsApp1.GUI
{
    public partial class UC_DichVu : UserControl
    {
        public UC_DichVu()
        {
            InitializeComponent();
        }

        private void btn_themLich_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu dv = new DichVu();
                dv.idDichVu = txt_maDichVu.Text;
                dv.tenDichVu = txt_TenDichVu.Text;
                dv.moTa = txt_MoTa.Text;
                dv.giaTien = Int32.Parse(txt_GiaTien.Text);
                DichVuBUS dvbus = new DichVuBUS();
                bool kq = dvbus.themdichvu(dv);
                if (kq)
                {
                    DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tb == DialogResult.OK)
                    {
                        txt_maDichVu.ResetText();
                        txt_TenDichVu.ResetText();
                        txt_MoTa.ResetText();
                        txt_GiaTien.ResetText();
                        btn_hienthi.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Thất Bại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoaLich_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = listView1.SelectedItems[0];
                    DichVu dv = lvi.Tag as DichVu;
                    DichVuBUS dlbus = new DichVuBUS();
                    bool kq = dlbus.xoadichvu(dv.idDichVu);
                    if (kq)
                    {
                        DialogResult tb = MessageBox.Show("Bạn Có Muốn Xoá Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (tb == DialogResult.OK)
                        {
                            txt_maDichVu.ResetText();
                            txt_TenDichVu.ResetText();
                            txt_MoTa.ResetText();
                            txt_GiaTien.ResetText();
                            btn_hienthi.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_suaLich_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu dv = new DichVu();
                dv.idDichVu = txt_maDichVu.Text;
                dv.tenDichVu = txt_TenDichVu.Text;
                dv.moTa = txt_MoTa.Text;
                dv.giaTien = Int32.Parse(txt_GiaTien.Text);
                DichVuBUS dvbus = new DichVuBUS();
                bool kq = dvbus.suadichvu(dv);
                if (kq)
                {
                    DialogResult tb = MessageBox.Show("Sữa Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tb == DialogResult.OK)
                    {
                        txt_maDichVu.ResetText();
                        txt_TenDichVu.ResetText();
                        txt_MoTa.ResetText();
                        txt_GiaTien.ResetText();
                        btn_hienthi.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sữa Thất Bại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txt_maDichVu.Text = item.Text;
            txt_TenDichVu.Text = item.SubItems[1].Text;
            txt_MoTa.Text = item.SubItems[2].Text;
            txt_GiaTien.Text = item.SubItems[3].Text;
            
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            DichVuBUS dvbus = new DichVuBUS();
            List<DichVu> dsdlGUI = dvbus.laytoanbosanpham();
            listView1.Items.Clear();
            foreach (DichVu dv in dsdlGUI)
            {
                ListViewItem lvi = new ListViewItem(dv.idDichVu + "");
                lvi.SubItems.Add(dv.tenDichVu);
                lvi.SubItems.Add(dv.moTa);
                lvi.SubItems.Add(dv.giaTien + "");
                listView1.Items.Add(lvi);
                lvi.Tag = dv;
            }
        }
    }
}
