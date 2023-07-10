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
    public class NhaCungCapAccess : DBConnection
    {
        public bool ThemNhaCungCap(NhaCungCap cc)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Nhacungcap (idnhacungcap, tennhacungcap, diachi, sodt) VALUES (@Idkhachhang,@TenKhachHang,@DiaChi,@sodt)";
            command.Connection = conn;
            command.Parameters.AddWithValue("@Idkhachhang", cc.nhaCungCapID);
            command.Parameters.AddWithValue("@TenKhachHang", cc.tenNhaCungCap);
            command.Parameters.AddWithValue("@DiaChi", cc.diaChi);
            command.Parameters.AddWithValue("@sodt", cc.soDienThoai);
           
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
    }
}
