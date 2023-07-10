namespace WindowsFormsApp1.GUI
{
    partial class UC_DichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DichVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_suaLich = new System.Windows.Forms.Button();
            this.btn_xoaDichVu = new System.Windows.Forms.Button();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.btn_themDichVu = new System.Windows.Forms.Button();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_TenDichVu = new System.Windows.Forms.TextBox();
            this.txt_maDichVu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_suaLich);
            this.panel1.Controls.Add(this.btn_xoaDichVu);
            this.panel1.Controls.Add(this.btn_hienthi);
            this.panel1.Controls.Add(this.btn_themDichVu);
            this.panel1.Controls.Add(this.txt_GiaTien);
            this.panel1.Controls.Add(this.txt_MoTa);
            this.panel1.Controls.Add(this.txt_TenDichVu);
            this.panel1.Controls.Add(this.txt_maDichVu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 232);
            this.panel1.TabIndex = 17;
            // 
            // btn_suaLich
            // 
            this.btn_suaLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_suaLich.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_suaLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaLich.ForeColor = System.Drawing.Color.White;
            this.btn_suaLich.Image = ((System.Drawing.Image)(resources.GetObject("btn_suaLich.Image")));
            this.btn_suaLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suaLich.Location = new System.Drawing.Point(560, 178);
            this.btn_suaLich.Name = "btn_suaLich";
            this.btn_suaLich.Size = new System.Drawing.Size(119, 36);
            this.btn_suaLich.TabIndex = 15;
            this.btn_suaLich.Text = "        Sửa Dịch Vụ";
            this.btn_suaLich.UseVisualStyleBackColor = false;
            this.btn_suaLich.Click += new System.EventHandler(this.btn_suaLich_Click);
            // 
            // btn_xoaDichVu
            // 
            this.btn_xoaDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_xoaDichVu.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xoaDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_xoaDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaDichVu.Image")));
            this.btn_xoaDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaDichVu.Location = new System.Drawing.Point(350, 178);
            this.btn_xoaDichVu.Name = "btn_xoaDichVu";
            this.btn_xoaDichVu.Size = new System.Drawing.Size(119, 36);
            this.btn_xoaDichVu.TabIndex = 13;
            this.btn_xoaDichVu.Text = "        Xoá Dịch Vụ";
            this.btn_xoaDichVu.UseVisualStyleBackColor = false;
            this.btn_xoaDichVu.Click += new System.EventHandler(this.btn_xoaLich_Click);
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_hienthi.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_hienthi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hienthi.ForeColor = System.Drawing.Color.White;
            this.btn_hienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hienthi.Location = new System.Drawing.Point(765, 203);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(149, 23);
            this.btn_hienthi.TabIndex = 20;
            this.btn_hienthi.Text = "Hiển Thị Dịch Vụ";
            this.btn_hienthi.UseVisualStyleBackColor = false;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // btn_themDichVu
            // 
            this.btn_themDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_themDichVu.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_themDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themDichVu.ForeColor = System.Drawing.Color.White;
            this.btn_themDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btn_themDichVu.Image")));
            this.btn_themDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themDichVu.Location = new System.Drawing.Point(136, 178);
            this.btn_themDichVu.Name = "btn_themDichVu";
            this.btn_themDichVu.Size = new System.Drawing.Size(128, 36);
            this.btn_themDichVu.TabIndex = 13;
            this.btn_themDichVu.Text = "            Thêm Dịch Vụ";
            this.btn_themDichVu.UseVisualStyleBackColor = false;
            this.btn_themDichVu.Click += new System.EventHandler(this.btn_themLich_Click);
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Location = new System.Drawing.Point(481, 105);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(189, 20);
            this.txt_GiaTien.TabIndex = 11;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(481, 48);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(189, 20);
            this.txt_MoTa.TabIndex = 9;
            // 
            // txt_TenDichVu
            // 
            this.txt_TenDichVu.Location = new System.Drawing.Point(136, 103);
            this.txt_TenDichVu.Name = "txt_TenDichVu";
            this.txt_TenDichVu.Size = new System.Drawing.Size(189, 20);
            this.txt_TenDichVu.TabIndex = 8;
            // 
            // txt_maDichVu
            // 
            this.txt_maDichVu.Location = new System.Drawing.Point(136, 46);
            this.txt_maDichVu.Name = "txt_maDichVu";
            this.txt_maDichVu.Size = new System.Drawing.Size(189, 20);
            this.txt_maDichVu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giá Tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mô Tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Dịch Vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Dịch Vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "- - DỊCH VỤ - -";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 231);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(944, 247);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Dịch Vụ";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Dịch Vụ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mô Tả";
            this.columnHeader3.Width = 550;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá Tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // UC_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "UC_DichVu";
            this.Size = new System.Drawing.Size(944, 477);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_suaLich;
        private System.Windows.Forms.Button btn_xoaDichVu;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Button btn_themDichVu;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_TenDichVu;
        private System.Windows.Forms.TextBox txt_maDichVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
