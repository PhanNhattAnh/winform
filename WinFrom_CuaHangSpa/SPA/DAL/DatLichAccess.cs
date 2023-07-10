using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.ComponentModel;

namespace DAL
{
    public class DatLichAccess : DBConnection
    {
        List<DatLich> dsdl = new List<DatLich>();
        public List<DatLich> laytoanbosanpham()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Lichhen";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string madatlich = reader.GetString(0);
                string ten = reader.GetString(1);
                DateTime ngayhen = reader.GetDateTime(2);
                string giohen = reader.GetTimeSpan(3).ToString();
                string tendichvu = reader.GetString(4);
                DatLich dl = new DatLich();
                dl.idLichHen = madatlich;
                dl.tenKhachHang = ten;
                dl.ngayHen = ngayhen;
                dl.gioHen = giohen;
                dl.tendichvu = tendichvu;
                dsdl.Add(dl);   
            }
            reader.Close();
            return dsdl;
        }
        public bool xoadatlich(string madatlich)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Lichhen where idlichhen=@madatlich";
            command.Connection = conn;
            command.Parameters.Add("@madatlich",SqlDbType.VarChar).Value = madatlich;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool Themdatlich(DatLich dl)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Lichhen (idlichhen, hoten, ngayhen, giohen, tendichvu) VALUES (@IdLichHen, @TenKhachHang, @NgayHen, @GioHen, @TenDichVu)";
            command.Connection = conn;
            command.Parameters.AddWithValue("@IdLichHen", dl.idLichHen);
            command.Parameters.AddWithValue("@TenKhachHang", dl.tenKhachHang);
            command.Parameters.AddWithValue("@NgayHen", dl.ngayHen);
            command.Parameters.AddWithValue("@GioHen", dl.gioHen);
            command.Parameters.AddWithValue("@TenDichVu", dl.tendichvu);

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool Suadatlich(DatLich dl)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Lichhen SET idlichhen = @IdLichHen, hoten = @TenKhachHang, ngayhen = @NgayHen, giohen = @GioHen ,tendichvu = @TenDichVu Where idlichhen = @IdLichHen";
            command.Connection = conn;
            command.Parameters.AddWithValue("@IdLichHen", dl.idLichHen);
            command.Parameters.AddWithValue("@TenKhachHang", dl.tenKhachHang);
            command.Parameters.AddWithValue("@NgayHen", dl.ngayHen);
            command.Parameters.AddWithValue("@GioHen", dl.gioHen);
            command.Parameters.AddWithValue("@TenDichVu", dl.tendichvu);

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }

    }
}
