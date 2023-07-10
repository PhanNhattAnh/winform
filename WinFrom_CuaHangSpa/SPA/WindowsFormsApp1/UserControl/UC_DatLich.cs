using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace WindowsFormsApp1.GUI
{
    public partial class UC_DatLich : UserControl
    {
        public UC_DatLich()
        {
            InitializeComponent();
        }

        private void UC_DatLich_Load(object sender, EventArgs e)
        {
            FillComboBox();

        }

        private void btn_xoaLich_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = listView1.SelectedItems[0];
                    DatLich dl = lvi.Tag as DatLich;
                    DatLichBUS dlbus = new DatLichBUS();
                    bool kq = dlbus.xoadatlich(dl.idLichHen);
                    if (kq)
                    {
                        DialogResult tb = MessageBox.Show("Bạn Có Muốn Xoá Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (tb == DialogResult.OK)
                        {
                            txt_maLichHen.ResetText();
                            txt_khachHang.ResetText();
                            cbb_DichVu.ResetText();
                            txt_gioHen.ResetText();
                            txt_ngayHen.ResetText();
                            btn_hienthi.PerformClick();
                        }
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            DatLichBUS dlbus = new DatLichBUS();
            List<DatLich> dsdlGUI = dlbus.laytoanbosanpham();
            listView1.Items.Clear();
            foreach (DatLich dl in dsdlGUI)
            {
                ListViewItem lvi = new ListViewItem(dl.idLichHen + "");
                lvi.SubItems.Add(dl.tenKhachHang);
                lvi.SubItems.Add(dl.ngayHen + "");
                lvi.SubItems.Add(dl.gioHen);
                lvi.SubItems.Add(dl.tendichvu);
                listView1.Items.Add(lvi);
                lvi.Tag = dl;
            }
        }

        private void btn_themLich_Click(object sender, EventArgs e)
        {
            try {
                DatLich dl = new DatLich();

                dl.idLichHen = txt_maLichHen.Text;
                dl.tenKhachHang = txt_khachHang.Text;
                dl.ngayHen = DateTime.Parse(txt_ngayHen.Text);
                dl.gioHen = txt_gioHen.Text;
                dl.tendichvu = cbb_DichVu.Text;
                DatLichBUS dlbus = new DatLichBUS();
                bool kq = dlbus.themdatlich(dl);
                if (kq)
                {
                    DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tb == DialogResult.OK)
                    {
                        txt_maLichHen.ResetText();
                        txt_khachHang.ResetText();
                        cbb_DichVu.ResetText();
                        txt_gioHen.ResetText();
                        txt_ngayHen.ResetText();
                        btn_hienthi.PerformClick();
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Chưa Có Dữ Liệu Khách Hàng","Thông Báo",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }

        }

        

        private void btn_suaLich_Click(object sender, EventArgs e)
        {
            try
            {
                DatLich dl = new DatLich();
                dl.idLichHen = txt_maLichHen.Text;
                dl.tenKhachHang = txt_khachHang.Text;
                dl.ngayHen = DateTime.Parse(txt_ngayHen.Text);
                dl.gioHen = txt_gioHen.Text;
                dl.tendichvu = cbb_DichVu.Text;
                DatLichBUS dlbus = new DatLichBUS();
                bool kq = dlbus.suadatlich(dl);
                if (kq)
                {
                    DialogResult tb = MessageBox.Show("Sửa Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tb == DialogResult.OK)
                    {
                        txt_maLichHen.ResetText();
                        txt_khachHang.ResetText();
                        cbb_DichVu.ResetText();
                        txt_gioHen.ResetText();
                        txt_ngayHen.ResetText();
                        btn_hienthi.PerformClick();
                    }

                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("Sữa Thất Bại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txt_maLichHen.Text = item.Text;
            txt_khachHang.Text = item.SubItems[1].Text;
            txt_ngayHen.Text = item.SubItems[2].Text;
            txt_gioHen.Text = item.SubItems[3].Text;
            cbb_DichVu.Text = item.SubItems[4].Text;
        }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            Frm_ThemKhachHang frm = new Frm_ThemKhachHang();
            frm.Show();
        }
        const string connectionString = "Data Source=DESKTOP-RAH6IHC;Initial Catalog=QL_Spa;Integrated Security=True";
        protected SqlConnection conn = null;
        private void btn_timKiemLich_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                conn = new SqlConnection(connectionString);
                conn.Open();
                string query = @"Select * From Lichhen where ngayhen = @NgayHen";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@NgayHen", DateTime.Parse(dtp_datlich.Text));
                SqlDataReader reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    listView1.Items.Add((i + 1).ToString());
                    listView1.Items[i].SubItems.Add(reader[1].ToString());
                    listView1.Items[i].SubItems.Add(reader[2].ToString());
                    listView1.Items[i].SubItems.Add(reader[3].ToString());
                    listView1.Items[i].SubItems.Add(reader[4].ToString());
                    i++;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm Kiếm Thất Bại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        protected void FillComboBox()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand sqlCmd = new SqlCommand("SELECT tendichvu FROM Dichvu", conn);
            
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cbb_DichVu.Items.Add(sqlReader["tendichvu"].ToString());
                }

                sqlReader.Close();
            

        }
    }
}
