using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class KhachHangAccess : DBConnection
    {
        public bool ThemKhachHang(KhachHang kh)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Khachhang (idkhach, hoten, ngaysinh, gioitinh, diachi, sodt, email) VALUES (@Idkhachhang, @TenKhachHang, @NgaySinh, @GioiTinh, @DiaChi,@sodt,@email)";
            command.Connection = conn;
            command.Parameters.AddWithValue("@Idkhachhang", kh.idKhachHang);
            command.Parameters.AddWithValue("@TenKhachHang", kh.tenKhachHang);
            command.Parameters.AddWithValue("@NgaySinh", kh.ngaySinh);
            command.Parameters.AddWithValue("@GioiTinh", kh.gioiTinh);
            command.Parameters.AddWithValue("@DiaChi", kh.diaChi);
            command.Parameters.AddWithValue("@sodt", kh.sdt);
            command.Parameters.AddWithValue("@email", kh.email);
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
    }
}
