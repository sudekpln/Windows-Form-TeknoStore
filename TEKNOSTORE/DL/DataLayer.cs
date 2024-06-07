using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using TEKNOSTORE;

namespace TEKNOSTORE.DL
{
    public static class DataLayer
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public static int MüşteriEkle(Musteri m)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_MusteriEkle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static int MüşteriSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_MusteriSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MüşteriGüncelle(Musteri m)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_MusteriGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_UrunSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SatisSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_SatisSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunGüncelle(Urun u)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_UrunGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@kategori", u.Kategori);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@stok", u.Stok);
                komut.Parameters.AddWithValue("@birim", u.Birim);
                komut.Parameters.AddWithValue("@detay", u.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new SqlCommand("tekno_MusterilerHepsi", conn);
                    komut.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    komut = new SqlCommand("tekno_MusteriBul", conn);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunEkle(Urun u)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_UrunEkle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@kategori", u.Kategori);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@stok", u.Stok);
                komut.Parameters.AddWithValue("@birim", u.Birim);
                komut.Parameters.AddWithValue("@detay", u.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new SqlCommand("tekno_UrunlerHepsi", conn);
                    komut.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    komut = new SqlCommand("tekno_UrunBul", conn);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SatisEkle(Satis s)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_SatisEkle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.MusteriID);
                komut.Parameters.AddWithValue("@uid", s.UrunID);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeEkle(Odeme o)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_OdemeEkle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tur", o.Tur);
                komut.Parameters.AddWithValue("@aciklama", o.Aciklama);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeGüncelle(Odeme o)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_OdemeGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tur", o.Tur);
                komut.Parameters.AddWithValue("@aciklama", o.Aciklama);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int SatisGüncelle(Satis s)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_SatisGuncelle", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.MusteriID);
                komut.Parameters.AddWithValue("@uid", s.UrunID);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet SatisDeyat()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_SatisDetay", conn);
                komut.CommandType = CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_OdemeDetay", conn);
                komut.CommandType = CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeSil(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand komut = new SqlCommand("tekno_OdemeSil", conn);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", id);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
}
