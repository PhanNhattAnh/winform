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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void taikhoan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (taikhoan.Text == "")
                {
                    taikhoan.Text = "Username";
                    return;
                }
                taikhoan.ForeColor = Color.White;
                panel4.Visible = false;

            }
            catch
            {
            }
        }

        private void matkhau_Click(object sender, EventArgs e)
        {
            matkhau.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            dangnhap.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            dangnhap.ForeColor = Color.PaleVioletRed;
        }

        

        private void taikhoan_Click(object sender, EventArgs e)
        {
            taikhoan.SelectAll(); 
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
                panel8.Visible = false;
            }
            catch
            {

            }
        }
        const string connectionString = "Data Source=DESKTOP-RAH6IHC;Initial Catalog=QL_Spa;Integrated Security=True";
        protected SqlConnection conn = null;
        protected void FillComboBox()
        {
            if (cbb_ChucVu.SelectedIndex == -1)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT chucvu FROM NhanVien", conn);

                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cbb_ChucVu.Items.Add(sqlReader["chucvu"].ToString());
                }

                sqlReader.Close();
            }




        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RAH6IHC;Initial Catalog=QL_Spa;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = taikhoan.Text;
                string mk = matkhau.Text;
                string cv = cbb_ChucVu.Text;
                string sql;
                sql = "select * from NhanVien Where tentaikhoan='" + tk + "' and matkhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main frm = new Main(tk, cv);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (taikhoan.Text == "Tài Khoản" && matkhau.Text == "Mật Khẩu")
                {
                    panel4.Visible = true;
                    taikhoan.Focus();
                    panel8.Visible = true;
                    matkhau.Focus();
                    return;
                }

            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void dangky_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}