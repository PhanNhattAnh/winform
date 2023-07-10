using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienAccess : DBConnection
    {
        public bool ThemNhanVien(NhanVien nv)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO NhanVien (tennhanvien, tentaikhoan, matkhau, ngaysinh, chucvu, gioitinh) VALUES (@TenNhanVien, @TenTaiKhoan, @MatKhau, @NgaySinh, @ChucVu,@GioiTinh)";
            command.Connection = conn;
            command.Parameters.AddWithValue("@TenNhanVien", nv.TenNhanVien);
            command.Parameters.AddWithValue("@TenTaiKhoan", nv.TenTaiKhoan);
            command.Parameters.AddWithValue("@MatKhau", nv.MatKhau);
            command.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
            command.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
            command.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
    }
}
