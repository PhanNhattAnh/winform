using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class UC_Kho : UserControl
    {
        public UC_Kho()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Kho));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.cbb_phieunhap = new System.Windows.Forms.ComboBox();
            this.btn_suaCTphieunhap = new System.Windows.Forms.Button();
            this.btn_xoaCTphieunhap = new System.Windows.Forms.Button();
            this.btn_themCTphieunhap = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_masanpham = new System.Windows.Forms.TextBox();
            this.txt_maCTphieunhap = new System.Windows.Forms.TextBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_HienThiPhieuNhap = new System.Windows.Forms.Button();
            this.btn_suaPhieuNhap = new System.Windows.Forms.Button();
            this.btn_xoaPhieuNhap = new System.Windows.Forms.Button();
            this.btn_ThemPhieuNhap = new System.Windows.Forms.Button();
            this.txt_nhacungcap = new System.Windows.Forms.TextBox();
            this.txt_phieunhap = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.btn_NhaCungCap = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 474);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.btn_hienthi);
            this.tabPage1.Controls.Add(this.cbb_phieunhap);
            this.tabPage1.Controls.Add(this.btn_suaCTphieunhap);
            this.tabPage1.Controls.Add(this.btn_xoaCTphieunhap);
            this.tabPage1.Controls.Add(this.btn_themCTphieunhap);
            this.tabPage1.Controls.Add(this.txt_soluong);
            this.tabPage1.Controls.Add(this.txt_masanpham);
            this.tabPage1.Controls.Add(this.txt_maCTphieunhap);
            this.tabPage1.Controls.Add(this.txt_gianhap);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi Tiết Phiếu Nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 220);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(937, 229);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã CT Phiếu Nhập";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Phiếu Nhập";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Sản Phẩm";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá Nhập";
            this.columnHeader5.Width = 200;
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_hienthi.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_hienthi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hienthi.ForeColor = System.Drawing.Color.White;
            this.btn_hienthi.Location = new System.Drawing.Point(761, 188);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(149, 23);
            this.btn_hienthi.TabIndex = 31;
            this.btn_hienthi.Text = "Hiển Thị Phiếu";
            this.btn_hienthi.UseVisualStyleBackColor = false;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // cbb_phieunhap
            // 
            this.cbb_phieunhap.FormattingEnabled = true;
            this.cbb_phieunhap.Location = new System.Drawing.Point(126, 82);
            this.cbb_phieunhap.Name = "cbb_phieunhap";
            this.cbb_phieunhap.Size = new System.Drawing.Size(139, 21);
            this.cbb_phieunhap.TabIndex = 30;
            this.cbb_phieunhap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbb_phieunhap_MouseClick);
            // 
            // btn_suaCTphieunhap
            // 
            this.btn_suaCTphieunhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_suaCTphieunhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_suaCTphieunhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaCTphieunhap.ForeColor = System.Drawing.Color.White;
            this.btn_suaCTphieunhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_suaCTphieunhap.Image")));
            this.btn_suaCTphieunhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suaCTphieunhap.Location = new System.Drawing.Point(500, 171);
            this.btn_suaCTphieunhap.Name = "btn_suaCTphieunhap";
            this.btn_suaCTphieunhap.Size = new System.Drawing.Size(117, 40);
            this.btn_suaCTphieunhap.TabIndex = 29;
            this.btn_suaCTphieunhap.Text = "      Sửa Phiếu";
            this.btn_suaCTphieunhap.UseVisualStyleBackColor = false;
            this.btn_suaCTphieunhap.Click += new System.EventHandler(this.btn_suaCTphieunhap_Click);
            // 
            // btn_xoaCTphieunhap
            // 
            this.btn_xoaCTphieunhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_xoaCTphieunhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xoaCTphieunhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaCTphieunhap.ForeColor = System.Drawing.Color.White;
            this.btn_xoaCTphieunhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaCTphieunhap.Image")));
            this.btn_xoaCTphieunhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaCTphieunhap.Location = new System.Drawing.Point(323, 171);
            this.btn_xoaCTphieunhap.Name = "btn_xoaCTphieunhap";
            this.btn_xoaCTphieunhap.Size = new System.Drawing.Size(117, 40);
            this.btn_xoaCTphieunhap.TabIndex = 28;
            this.btn_xoaCTphieunhap.Text = "       Xoá Phiếu";
            this.btn_xoaCTphieunhap.UseVisualStyleBackColor = false;
            this.btn_xoaCTphieunhap.Click += new System.EventHandler(this.btn_xoaCTphieunhap_Click);
            // 
            // btn_themCTphieunhap
            // 
            this.btn_themCTphieunhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_themCTphieunhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_themCTphieunhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themCTphieunhap.ForeColor = System.Drawing.Color.White;
            this.btn_themCTphieunhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_themCTphieunhap.Image")));
            this.btn_themCTphieunhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themCTphieunhap.Location = new System.Drawing.Point(140, 171);
            this.btn_themCTphieunhap.Name = "btn_themCTphieunhap";
            this.btn_themCTphieunhap.Size = new System.Drawing.Size(117, 40);
            this.btn_themCTphieunhap.TabIndex = 27;
            this.btn_themCTphieunhap.Text = "         Thêm Phiếu";
            this.btn_themCTphieunhap.UseVisualStyleBackColor = false;
            this.btn_themCTphieunhap.Click += new System.EventHandler(this.btn_themCTphieunhap_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(440, 37);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(139, 20);
            this.txt_soluong.TabIndex = 26;
            // 
            // txt_masanpham
            // 
            this.txt_masanpham.Location = new System.Drawing.Point(126, 134);
            this.txt_masanpham.Name = "txt_masanpham";
            this.txt_masanpham.Size = new System.Drawing.Size(139, 20);
            this.txt_masanpham.TabIndex = 25;
            // 
            // txt_maCTphieunhap
            // 
            this.txt_maCTphieunhap.Location = new System.Drawing.Point(126, 37);
            this.txt_maCTphieunhap.Name = "txt_maCTphieunhap";
            this.txt_maCTphieunhap.Size = new System.Drawing.Size(140, 20);
            this.txt_maCTphieunhap.TabIndex = 24;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Location = new System.Drawing.Point(440, 78);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(139, 20);
            this.txt_gianhap.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Giá Nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã Sản Phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã Phiếu Nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã CT Phiếu Nhập:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_NhaCungCap);
            this.tabPage2.Controls.Add(this.dtp_ngaynhap);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Controls.Add(this.btn_HienThiPhieuNhap);
            this.tabPage2.Controls.Add(this.btn_suaPhieuNhap);
            this.tabPage2.Controls.Add(this.btn_xoaPhieuNhap);
            this.tabPage2.Controls.Add(this.btn_ThemPhieuNhap);
            this.tabPage2.Controls.Add(this.txt_nhacungcap);
            this.tabPage2.Controls.Add(this.txt_phieunhap);
            this.tabPage2.Controls.Add(this.txt_tongtien);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu Nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 217);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(937, 229);
            this.listView2.TabIndex = 47;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView2_ItemSelectionChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã Phiếu Nhập";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã Nhà Cung Cấp";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ngày Nhập ";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tổng Tiền";
            this.columnHeader10.Width = 150;
            // 
            // btn_HienThiPhieuNhap
            // 
            this.btn_HienThiPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_HienThiPhieuNhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_HienThiPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HienThiPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btn_HienThiPhieuNhap.Location = new System.Drawing.Point(761, 185);
            this.btn_HienThiPhieuNhap.Name = "btn_HienThiPhieuNhap";
            this.btn_HienThiPhieuNhap.Size = new System.Drawing.Size(149, 23);
            this.btn_HienThiPhieuNhap.TabIndex = 46;
            this.btn_HienThiPhieuNhap.Text = "Hiển Thị Phiếu";
            this.btn_HienThiPhieuNhap.UseVisualStyleBackColor = false;
            this.btn_HienThiPhieuNhap.Click += new System.EventHandler(this.btn_HienThiPhieuNhap_Click);
            // 
            // btn_suaPhieuNhap
            // 
            this.btn_suaPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_suaPhieuNhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_suaPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btn_suaPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_suaPhieuNhap.Image")));
            this.btn_suaPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suaPhieuNhap.Location = new System.Drawing.Point(479, 153);
            this.btn_suaPhieuNhap.Name = "btn_suaPhieuNhap";
            this.btn_suaPhieuNhap.Size = new System.Drawing.Size(117, 40);
            this.btn_suaPhieuNhap.TabIndex = 44;
            this.btn_suaPhieuNhap.Text = "      Sửa Phiếu";
            this.btn_suaPhieuNhap.UseVisualStyleBackColor = false;
            this.btn_suaPhieuNhap.Click += new System.EventHandler(this.btn_suaPhieuNhap_Click);
            // 
            // btn_xoaPhieuNhap
            // 
            this.btn_xoaPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_xoaPhieuNhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xoaPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btn_xoaPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaPhieuNhap.Image")));
            this.btn_xoaPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaPhieuNhap.Location = new System.Drawing.Point(302, 153);
            this.btn_xoaPhieuNhap.Name = "btn_xoaPhieuNhap";
            this.btn_xoaPhieuNhap.Size = new System.Drawing.Size(117, 40);
            this.btn_xoaPhieuNhap.TabIndex = 43;
            this.btn_xoaPhieuNhap.Text = "       Xoá Phiếu";
            this.btn_xoaPhieuNhap.UseVisualStyleBackColor = false;
            this.btn_xoaPhieuNhap.Click += new System.EventHandler(this.btn_xoaPhieuNhap_Click);
            // 
            // btn_ThemPhieuNhap
            // 
            this.btn_ThemPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ThemPhieuNhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btn_ThemPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemPhieuNhap.Image")));
            this.btn_ThemPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemPhieuNhap.Location = new System.Drawing.Point(119, 153);
            this.btn_ThemPhieuNhap.Name = "btn_ThemPhieuNhap";
            this.btn_ThemPhieuNhap.Size = new System.Drawing.Size(117, 40);
            this.btn_ThemPhieuNhap.TabIndex = 42;
            this.btn_ThemPhieuNhap.Text = "         Thêm Phiếu";
            this.btn_ThemPhieuNhap.UseVisualStyleBackColor = false;
            this.btn_ThemPhieuNhap.Click += new System.EventHandler(this.btn_ThemPhieuNhap_Click);
            // 
            // txt_nhacungcap
            // 
            this.txt_nhacungcap.Location = new System.Drawing.Point(141, 72);
            this.txt_nhacungcap.Name = "txt_nhacungcap";
            this.txt_nhacungcap.Size = new System.Drawing.Size(139, 20);
            this.txt_nhacungcap.TabIndex = 40;
            // 
            // txt_phieunhap
            // 
            this.txt_phieunhap.Location = new System.Drawing.Point(140, 31);
            this.txt_phieunhap.Name = "txt_phieunhap";
            this.txt_phieunhap.Size = new System.Drawing.Size(140, 20);
            this.txt_phieunhap.TabIndex = 39;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(440, 75);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(139, 20);
            this.txt_tongtien.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tổng Tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ngày Nhập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Mã Nhà Cung Cấp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mã Phiếu Nhập:";
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.Location = new System.Drawing.Point(440, 34);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaynhap.TabIndex = 48;
            this.dtp_ngaynhap.Value = new System.DateTime(2023, 6, 6, 0, 0, 0, 0);
            // 
            // btn_NhaCungCap
            // 
            this.btn_NhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_NhaCungCap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_NhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_NhaCungCap.Location = new System.Drawing.Point(761, 132);
            this.btn_NhaCungCap.Name = "btn_NhaCungCap";
            this.btn_NhaCungCap.Size = new System.Drawing.Size(149, 33);
            this.btn_NhaCungCap.TabIndex = 49;
            this.btn_NhaCungCap.Text = "Thêm Nhà Cung Cấp";
            this.btn_NhaCungCap.UseVisualStyleBackColor = false;
            this.btn_NhaCungCap.Click += new System.EventHandler(this.btn_NhaCungCap_Click);
            // 
            // UC_Kho
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "UC_Kho";
            this.Size = new System.Drawing.Size(944, 477);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btn_themCTphieunhap_Click(object sender, EventArgs e)
        {
            try {
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                ctpn.chiTietPhieuNhapID = txt_maCTphieunhap.Text;
                ctpn.phieuNhapID = cbb_phieunhap.Text;
                ctpn.sanPhamID = txt_masanpham.Text;
                ctpn.giaNhap = Int32.Parse(txt_gianhap.Text);
                ctpn.soLuong = Int32.Parse(txt_soluong.Text);
                CTPhieuNhapBUS ctpnbus = new CTPhieuNhapBUS();
                ctpnbus.themCTPhieunhap(ctpn);
                DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tb == DialogResult.OK)
                    {
                        txt_gianhap.ResetText();
                        txt_maCTphieunhap.ResetText();
                        cbb_phieunhap.ResetText();
                        txt_masanpham.ResetText();
                        txt_soluong.ResetText();
                        btn_hienthi.PerformClick();
                    }
            }catch(Exception ex) {
                MessageBox.Show("Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btn_xoaCTphieunhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = listView1.SelectedItems[0];
                    ChiTietPhieuNhap ctpn = lvi.Tag as ChiTietPhieuNhap;
                    CTPhieuNhapBUS ctpnbus = new CTPhieuNhapBUS();
                    bool kq = ctpnbus.xoaCTPhieunhap(ctpn.chiTietPhieuNhapID);
                    if (kq)
                    {
                        DialogResult tb = MessageBox.Show("Bạn Có Muốn Xoá Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (tb == DialogResult.OK)
                        {
                            txt_maCTphieunhap.ResetText();
                            cbb_phieunhap.ResetText();
                            txt_masanpham.ResetText();
                            txt_soluong.ResetText();
                            txt_gianhap.ResetText();
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

        private void btn_suaCTphieunhap_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                ctpn.chiTietPhieuNhapID = txt_maCTphieunhap.Text;
                ctpn.phieuNhapID = cbb_phieunhap.Text;
                ctpn.sanPhamID = txt_masanpham.Text;
                ctpn.giaNhap = Int32.Parse(txt_gianhap.Text);
                ctpn.soLuong = Int32.Parse(txt_soluong.Text);
                CTPhieuNhapBUS ctpnbus = new CTPhieuNhapBUS();
                ctpnbus.suaCTphieunhap(ctpn);
                DialogResult tb = MessageBox.Show("Sửa Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tb == DialogResult.OK)
                    {
                        txt_maCTphieunhap.ResetText();
                        cbb_phieunhap.ResetText();
                        txt_masanpham.ResetText();
                        txt_soluong.ResetText();
                        txt_gianhap.ResetText();
                        btn_hienthi.PerformClick();
                    }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sữa Thất Bại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            CTPhieuNhapBUS ctpnbus = new CTPhieuNhapBUS();
            List<ChiTietPhieuNhap> ctpnGUI = ctpnbus.laytoanbosanpham();
            listView1.Items.Clear();
            foreach (ChiTietPhieuNhap ctpn in ctpnGUI)
            {
                ListViewItem lvi = new ListViewItem(ctpn.chiTietPhieuNhapID + "");
                lvi.SubItems.Add(ctpn.phieuNhapID);
                lvi.SubItems.Add(ctpn.sanPhamID + "");
                lvi.SubItems.Add(ctpn.soLuong+ "");
                lvi.SubItems.Add(ctpn.giaNhap+"");
                listView1.Items.Add(lvi);
                lvi.Tag = ctpn;
            }
            
        }
        const string connectionString = "Data Source=DESKTOP-RAH6IHC;Initial Catalog=QL_Spa;Integrated Security=True";
        protected SqlConnection conn = null;
        protected void FillComboBox()
        {
            if (cbb_phieunhap.SelectedIndex == -1)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT idphieunhap FROM Phieunhaphang", conn);

                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cbb_phieunhap.Items.Add(sqlReader["idphieunhap"].ToString());
                }

                sqlReader.Close();
            } 
                
            


        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txt_maCTphieunhap.Text = item.Text;
            cbb_phieunhap.Text = item.SubItems[1].Text;
            txt_masanpham.Text = item.SubItems[2].Text;
            txt_soluong.Text = item.SubItems[3].Text;
            txt_gianhap.Text = item.SubItems[4].Text;
        }

        private void btn_ThemPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                NhapHang NH = new NhapHang();

                NH.phieuNhapID = txt_phieunhap.Text;
                NH.nhaCungCapID = txt_nhacungcap.Text;
                
                NH.ngayNhap = DateTime.Parse(dtp_ngaynhap.Text);
                NH.tongTien = Int32.Parse(txt_tongtien.Text);
                
                NhapHangBUS NHbus = new NhapHangBUS();
                bool kq = NHbus.themPhieunhap(NH);
                if (kq)
                {
                    DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tb == DialogResult.OK)
                    {
                        txt_phieunhap.ResetText();
                        txt_nhacungcap.ResetText();
                        dtp_ngaynhap.Value = DateTime.Now;
                        txt_tongtien.Text = "0";
                        txt_tongtien.ResetText();
                        btn_HienThiPhieuNhap.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoaPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = listView2.SelectedItems[0];
                    NhapHang NH = lvi.Tag as NhapHang;
                    NhapHangBUS NHbus = new NhapHangBUS();
                    bool kq = NHbus.xoaNhapHang(NH.phieuNhapID);
                    if (kq)
                    {
                        DialogResult tb = MessageBox.Show("Bạn Có Muốn Xoá Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (tb == DialogResult.OK)
                        {
                            txt_phieunhap.ResetText();
                            txt_nhacungcap.ResetText();
                            dtp_ngaynhap.Value = DateTime.Now;
                            txt_tongtien.Text = "0";
                            txt_tongtien.ResetText();
                            btn_HienThiPhieuNhap.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_suaPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                NhapHang NH = new NhapHang();
                NH.phieuNhapID = txt_phieunhap.Text;
                NH.nhaCungCapID = txt_nhacungcap.Text;
                
                NH.ngayNhap = DateTime.Parse(dtp_ngaynhap.Text);
                NH.tongTien = Int32.Parse(txt_tongtien.Text);

                NhapHangBUS NHbus = new NhapHangBUS();
                bool kq = NHbus.suaphienhap(NH);
                if (kq)
                {
                    DialogResult tb = MessageBox.Show("Sửa Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (tb == DialogResult.OK)
                    {
                        txt_phieunhap.ResetText();
                        txt_nhacungcap.ResetText();
                        dtp_ngaynhap.Value = DateTime.Now;
                        txt_tongtien.Text = "0";
                        txt_tongtien.ResetText();
                        btn_HienThiPhieuNhap.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_HienThiPhieuNhap_Click(object sender, EventArgs e)
        {
            NhapHangBUS NHbus = new NhapHangBUS();
            List<NhapHang> NHGUI = NHbus.laytoanbosanpham();
            listView2.Items.Clear();
            foreach (NhapHang NH in NHGUI)
            {
                ListViewItem lvi = new ListViewItem(NH.phieuNhapID + "");
                lvi.SubItems.Add(NH.nhaCungCapID);
                
                lvi.SubItems.Add(NH.ngayNhap + "");
                lvi.SubItems.Add(NH.tongTien + "");
                listView2.Items.Add(lvi);
                lvi.Tag = NH;
            }
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txt_phieunhap.Text = item.Text;
            txt_nhacungcap.Text = item.SubItems[1].Text;
            
            dtp_ngaynhap.Text = item.SubItems[2].Text;
            txt_tongtien.Text = item.SubItems[3].Text;
        }

        

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            
            txt_tongtien.Text = "0";
            dtp_ngaynhap.Value = DateTime.Now;
        }

        private void cbb_phieunhap_MouseClick(object sender, MouseEventArgs e)
        {
            cbb_phieunhap.Items.Clear();
            FillComboBox();
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            Frm_NhaCungCap frm = new Frm_NhaCungCap();
            frm.Show();
        }
    }
}
