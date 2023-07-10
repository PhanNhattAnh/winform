using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DichVuAccess : DBConnection
    {
        List<DichVu> dsdv = new List<DichVu>();
        public List<DichVu> laytoanbosanpham()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Dichvu";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string madichvu = reader.GetString(0);
                string tendichvu = reader.GetString(1);
                string mota = reader.GetString(2);
                int giatien = reader.GetInt32(3);
                DichVu dv = new DichVu();
                dv.idDichVu = madichvu;
                dv.tenDichVu = tendichvu;
                dv.moTa = mota;
                dv.giaTien = giatien;
                dsdv.Add(dv);
            }
            reader.Close();
            return dsdv;
        }
        public bool xoadichvu(string madichvu)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Dichvu where iddichvu=@madichvu";
            command.Connection = conn;
            command.Parameters.Add("@madichvu", SqlDbType.VarChar).Value = madichvu;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool Themdichvu(DichVu dv)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Dichvu (iddichvu, tendichvu, mota, giatien) VALUES (@Iddichvu, @Tendichvu, @Mota, @Giatien)";
            command.Connection = conn;
            command.Parameters.AddWithValue("@Iddichvu", dv.idDichVu);
            command.Parameters.AddWithValue("@Tendichvu", dv.tenDichVu);
            command.Parameters.AddWithValue("@Mota", dv.moTa);
            command.Parameters.AddWithValue("@Giatien", dv.giaTien);
            

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool Suadichvu(DichVu dv)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE Dichvu SET iddichvu = @Iddichvu, tendichvu = @Tendichvu, mota = @Mota, giatien = @Giatien Where iddichvu = @Iddichvu";
            command.Connection = conn;
            command.Parameters.AddWithValue("@Iddichvu", dv.idDichVu);
            command.Parameters.AddWithValue("@Tendichvu", dv.tenDichVu);
            command.Parameters.AddWithValue("@Mota", dv.moTa);
            command.Parameters.AddWithValue("@Giatien", dv.giaTien);

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
    }
}
