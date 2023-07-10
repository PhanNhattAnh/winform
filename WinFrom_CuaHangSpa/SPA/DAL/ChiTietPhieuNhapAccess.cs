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
    public class ChiTietPhieuNhapAccess : DBConnection
    {
        List<ChiTietPhieuNhap> dsCTPN = new List<ChiTietPhieuNhap>();
        public List<ChiTietPhieuNhap> laytoanbosanpham()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from CTPhieunhap";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string CTphieunhapid = reader.GetString(0);
                string Phieunhapid = reader.GetString(1);
                string Sanphamid = reader.GetString(2);
                int Soluong = reader.GetInt32(3);
                int Gianhap = reader.GetInt32(4);
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                ctpn.chiTietPhieuNhapID = CTphieunhapid;
                ctpn.phieuNhapID = Phieunhapid;
                ctpn.sanPhamID = Sanphamid;
                ctpn.soLuong = Soluong;
                ctpn.giaNhap = Gianhap;
                dsCTPN.Add(ctpn);
            }
            reader.Close();
            return dsCTPN;
        }
        public bool xoaCTPhieuNhap(string CTphieunhapid)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from CTPhieunhap where idctphieunhap=@CTphieunhapid";
            command.Connection = conn;
            command.Parameters.Add("@CTphieunhapid", SqlDbType.VarChar).Value = CTphieunhapid;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool ThemCTPhieunhap(ChiTietPhieuNhap CTPN)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ThemChiTietPhieuNhap";
            command.Connection = conn;
            command.Parameters.AddWithValue("@idCTphieunhap", CTPN.chiTietPhieuNhapID);
            command.Parameters.AddWithValue("@idPhieuNhap", CTPN.phieuNhapID);
            command.Parameters.AddWithValue("@idSanPham", CTPN.sanPhamID);
            command.Parameters.AddWithValue("@soLuong", CTPN.soLuong);
            command.Parameters.AddWithValue("@giaNhap", CTPN.giaNhap);

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool SuaCTPhieunhap(ChiTietPhieuNhap CTPN)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "ChinhSuaChiTietPhieuNhap";
            command.Connection = conn;
            command.Parameters.AddWithValue("@idCTphieunhap", CTPN.chiTietPhieuNhapID);
            command.Parameters.AddWithValue("@idPhieuNhap", CTPN.phieuNhapID);
            command.Parameters.AddWithValue("@idSanPham", CTPN.sanPhamID);
            command.Parameters.AddWithValue("@soLuong", CTPN.soLuong);
            command.Parameters.AddWithValue("@giaNhap", CTPN.giaNhap);

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
    }
}
