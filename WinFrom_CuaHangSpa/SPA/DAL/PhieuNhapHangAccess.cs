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
    public class PhieuNhapHangAccess : DBConnection
    {
        List<NhapHang> dsNH = new List<NhapHang>();
        public List<NhapHang> laytoanbosanpham()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Phieunhaphang";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                string Phieunhapid = reader.GetString(0);
                string Nhacungcapid = reader.GetString(1);
                
                DateTime Ngaynhap = reader.GetDateTime(2);
                int Tongtien = reader.GetInt32(3);
                NhapHang nh = new NhapHang();
                nh.phieuNhapID = Phieunhapid;
                nh.nhaCungCapID = Nhacungcapid;
                
                nh.ngayNhap = Ngaynhap;
                nh.tongTien = Tongtien;
                
                dsNH.Add(nh);
            }
            reader.Close();
            return dsNH;
        }
        public bool xoaNhapHang(string nhaphangid)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Phieunhaphang where idphieunhap=@Phieunhapid";
            command.Connection = conn;
            command.Parameters.Add("@Phieunhapid", SqlDbType.VarChar).Value = nhaphangid;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool ThemNhapHang(NhapHang NH)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Phieunhaphang (idphieunhap, idnhacungcap,ngaynhap, tongtien) VALUES (@Nhaphangid, @Nhacungcapid,@Ngaynhap, @Tongtien)";
            command.Connection = conn;
            command.Parameters.AddWithValue("@Nhaphangid", NH.phieuNhapID);
            command.Parameters.AddWithValue("@Nhacungcapid", NH.nhaCungCapID);
            
            command.Parameters.AddWithValue("@Ngaynhap", NH.ngayNhap);
            command.Parameters.AddWithValue("@Tongtien", NH.tongTien);

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool SuaNhaphang(NhapHang NH)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Phieunhaphang SET idphieunhap = @Nhaphangid, idnhacungcap = @Nhacungcapid, ngaynhap = @Ngaynhap, tongtien = @Tongtien Where idphieunhap = @Nhaphangid";
            command.Connection = conn;
            command.Parameters.AddWithValue("@Nhaphangid", NH.phieuNhapID);
            command.Parameters.AddWithValue("@Nhacungcapid", NH.nhaCungCapID);
            
            command.Parameters.AddWithValue("@Ngaynhap", NH.ngayNhap);
            command.Parameters.AddWithValue("@Tongtien", NH.tongTien);

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
    }
}
