namespace WindowsFormsApp1.GUI
{
    partial class UC_DatLich
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DatLich));
            this.btn_timKiemLich = new System.Windows.Forms.Button();
            this.btn_xoaLich = new System.Windows.Forms.Button();
            this.btn_themLich = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_suaLich = new System.Windows.Forms.Button();
            this.txt_gioHen = new System.Windows.Forms.TextBox();
            this.txt_ngayHen = new System.Windows.Forms.TextBox();
            this.txt_khachHang = new System.Windows.Forms.TextBox();
            this.txt_maLichHen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_DichVu = new System.Windows.Forms.ComboBox();
            this.btn_ThemKhachHang = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.dtp_datlich = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_timKiemLich
            // 
            this.btn_timKiemLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_timKiemLich.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_timKiemLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timKiemLich.ForeColor = System.Drawing.Color.White;
            this.btn_timKiemLich.Location = new System.Drawing.Point(318, 73);
            this.btn_timKiemLich.Name = "btn_timKiemLich";
            this.btn_timKiemLich.Size = new System.Drawing.Size(75, 23);
            this.btn_timKiemLich.TabIndex = 16;
            this.btn_timKiemLich.Text = "Tìm Kiếm";
            this.btn_timKiemLich.UseVisualStyleBackColor = false;
            this.btn_timKiemLich.Click += new System.EventHandler(this.btn_timKiemLich_Click);
            // 
            // btn_xoaLich
            // 
            this.btn_xoaLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_xoaLich.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xoaLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaLich.ForeColor = System.Drawing.Color.White;
            this.btn_xoaLich.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaLich.Image")));
            this.btn_xoaLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaLich.Location = new System.Drawing.Point(220, 175);
            this.btn_xoaLich.Name = "btn_xoaLich";
            this.btn_xoaLich.Size = new System.Drawing.Size(117, 40);
            this.btn_xoaLich.TabIndex = 14;
            this.btn_xoaLich.Text = "       Xoá Lịch";
            this.btn_xoaLich.UseVisualStyleBackColor = false;
            this.btn_xoaLich.Click += new System.EventHandler(this.btn_xoaLich_Click);
            // 
            // btn_themLich
            // 
            this.btn_themLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_themLich.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_themLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themLich.ForeColor = System.Drawing.Color.White;
            this.btn_themLich.Image = ((System.Drawing.Image)(resources.GetObject("btn_themLich.Image")));
            this.btn_themLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themLich.Location = new System.Drawing.Point(37, 175);
            this.btn_themLich.Name = "btn_themLich";
            this.btn_themLich.Size = new System.Drawing.Size(117, 40);
            this.btn_themLich.TabIndex = 13;
            this.btn_themLich.Text = "         Thêm Lịch";
            this.btn_themLich.UseVisualStyleBackColor = false;
            this.btn_themLich.Click += new System.EventHandler(this.btn_themLich_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngày Đặt:";
            // 
            // btn_suaLich
            // 
            this.btn_suaLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_suaLich.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_suaLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaLich.ForeColor = System.Drawing.Color.White;
            this.btn_suaLich.Image = ((System.Drawing.Image)(resources.GetObject("btn_suaLich.Image")));
            this.btn_suaLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suaLich.Location = new System.Drawing.Point(397, 175);
            this.btn_suaLich.Name = "btn_suaLich";
            this.btn_suaLich.Size = new System.Drawing.Size(117, 40);
            this.btn_suaLich.TabIndex = 15;
            this.btn_suaLich.Text = "      Sửa Lịch";
            this.btn_suaLich.UseVisualStyleBackColor = false;
            this.btn_suaLich.Click += new System.EventHandler(this.btn_suaLich_Click);
            // 
            // txt_gioHen
            // 
            this.txt_gioHen.Location = new System.Drawing.Point(335, 38);
            this.txt_gioHen.Name = "txt_gioHen";
            this.txt_gioHen.Size = new System.Drawing.Size(139, 20);
            this.txt_gioHen.TabIndex = 10;
            // 
            // txt_ngayHen
            // 
            this.txt_ngayHen.Location = new System.Drawing.Point(116, 135);
            this.txt_ngayHen.Name = "txt_ngayHen";
            this.txt_ngayHen.Size = new System.Drawing.Size(131, 20);
            this.txt_ngayHen.TabIndex = 9;
            // 
            // txt_khachHang
            // 
            this.txt_khachHang.Location = new System.Drawing.Point(116, 83);
            this.txt_khachHang.Name = "txt_khachHang";
            this.txt_khachHang.Size = new System.Drawing.Size(131, 20);
            this.txt_khachHang.TabIndex = 8;
            // 
            // txt_maLichHen
            // 
            this.txt_maLichHen.Location = new System.Drawing.Point(116, 39);
            this.txt_maLichHen.Name = "txt_maLichHen";
            this.txt_maLichHen.Size = new System.Drawing.Size(131, 20);
            this.txt_maLichHen.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dịch Vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giờ Hẹn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Hẹn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Lịch Hẹn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "- - ĐẶT LỊCH - -";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.dtp_datlich);
            this.panel2.Controls.Add(this.btn_timKiemLich);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(531, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 147);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "- - TRA LỊCH ĐẶT - -";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cbb_DichVu);
            this.panel1.Controls.Add(this.btn_suaLich);
            this.panel1.Controls.Add(this.btn_xoaLich);
            this.panel1.Controls.Add(this.btn_themLich);
            this.panel1.Controls.Add(this.txt_gioHen);
            this.panel1.Controls.Add(this.txt_ngayHen);
            this.panel1.Controls.Add(this.txt_khachHang);
            this.panel1.Controls.Add(this.txt_maLichHen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 232);
            this.panel1.TabIndex = 4;
            // 
            // cbb_DichVu
            // 
            this.cbb_DichVu.FormattingEnabled = true;
            this.cbb_DichVu.Location = new System.Drawing.Point(335, 81);
            this.cbb_DichVu.Name = "cbb_DichVu";
            this.cbb_DichVu.Size = new System.Drawing.Size(139, 21);
            this.cbb_DichVu.TabIndex = 16;
            // 
            // btn_ThemKhachHang
            // 
            this.btn_ThemKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_ThemKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemKhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_ThemKhachHang.Location = new System.Drawing.Point(755, 151);
            this.btn_ThemKhachHang.Name = "btn_ThemKhachHang";
            this.btn_ThemKhachHang.Size = new System.Drawing.Size(149, 33);
            this.btn_ThemKhachHang.TabIndex = 16;
            this.btn_ThemKhachHang.Text = "Thêm Khách Hàng";
            this.btn_ThemKhachHang.UseVisualStyleBackColor = false;
            this.btn_ThemKhachHang.Click += new System.EventHandler(this.btn_ThemKhachHang_Click);
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
            this.listView1.Location = new System.Drawing.Point(0, 253);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(944, 247);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Đặt Lịch";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Khách Hàng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Đặt";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giờ Đặt";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Dịch Vụ";
            this.columnHeader5.Width = 200;
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_hienthi.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_hienthi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hienthi.ForeColor = System.Drawing.Color.White;
            this.btn_hienthi.Location = new System.Drawing.Point(755, 201);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(149, 23);
            this.btn_hienthi.TabIndex = 7;
            this.btn_hienthi.Text = "Hiển Thị Lịch";
            this.btn_hienthi.UseVisualStyleBackColor = false;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // dtp_datlich
            // 
            this.dtp_datlich.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtp_datlich.Location = new System.Drawing.Point(79, 73);
            this.dtp_datlich.Name = "dtp_datlich";
            this.dtp_datlich.Size = new System.Drawing.Size(216, 20);
            this.dtp_datlich.TabIndex = 17;
            // 
            // UC_DatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_ThemKhachHang);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_DatLich";
            this.Size = new System.Drawing.Size(944, 477);
            this.Load += new System.EventHandler(this.UC_DatLich_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_timKiemLich;
        private System.Windows.Forms.Button btn_xoaLich;
        private System.Windows.Forms.Button btn_themLich;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_suaLich;
        private System.Windows.Forms.TextBox txt_gioHen;
        private System.Windows.Forms.TextBox txt_ngayHen;
        private System.Windows.Forms.TextBox txt_khachHang;
        private System.Windows.Forms.TextBox txt_maLichHen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Button btn_ThemKhachHang;
        private System.Windows.Forms.ComboBox cbb_DichVu;
        private System.Windows.Forms.DateTimePicker dtp_datlich;
    }
}
