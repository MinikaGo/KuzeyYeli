using KuzeyYeli.ORM.Entity;
using System.Data;
using System.Data.SqlClient;



namespace KuzeyYeli.ORM.Fascade
{
    public class Urunler
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("UrunListele", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public static bool Ekle(Urun entity)
        {
            SqlCommand komut = new SqlCommand("UrunEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@a", entity.UrunAdi);
            komut.Parameters.AddWithValue("@f", entity.Fiyat);
            komut.Parameters.AddWithValue("@s", entity.Stok);

            return Tools.ExecuteNonQuery(komut);
        }

        public static bool Sil (Urun entity)
        {
            SqlCommand komut = new SqlCommand("UrunSil", Tools.Baglanti);        komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.UrunId);
            return Tools.ExecuteNonQuery(komut);
        }
    }
}
