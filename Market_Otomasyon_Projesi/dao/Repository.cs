using Market_Otomasyon_Projesi.enumaration;
using Market_Otomasyon_Projesi.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyon_Projesi.dao
{
   
    public class Repository
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        int returnValue;
        List<LoginTables> loginTableList;
        public Repository()
        {
            con = new SqlConnection("Data Source=(local);Initial Catalog=Market;User ID=sa;password=1");

        }
        public void baglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }
        }


        public User login(string kullaniciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select * from loginTable where kullaniciAdi=@kulAd and sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kulAd", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre",sifre);
            dr=cmd.ExecuteReader();

            if(dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.yetki = dr["yetki"].ToString();
                user.kullaniciAdi = dr["kullaniciAdi"].ToString() ;
                user.emailAddress = dr["emailAdres"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.status = loginStatus.basarili;
                return user;
            }
            else
            {
                User user=new User();
                user.status = loginStatus.basarisiz;
                return user;
            }

        }
        public List<LoginTables> getLoginTable()
        {
            loginTableList = new List<LoginTables>();
            con.Open ();
            cmd = new SqlCommand("guvenlikSorusuGetir_sp", con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                LoginTables loginTable=new LoginTables();
                loginTable.id = int.Parse(dr["id"].ToString());
                loginTable.kullaniciAdi = dr["kullaniciAdi"].ToString();
                loginTable.yetki = dr["yetki"].ToString() ;
                loginTable.emailAdres = dr["emailAdres"].ToString();
                loginTable.sifre = dr["sifre"].ToString();
                loginTable.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                loginTable.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                loginTableList.Add(loginTable);

            }
            con.Close();
            return loginTableList;
        }
        public loginStatus doAuthentication(string kullaniciAdi,string guvenlikSorusu,string guvenlikCevabi)
        {
            con.Open();
            cmd = new SqlCommand("select count(*) from loginTable where kullaniciAdi=@kulad and guvenlikSorusu=@guvSorusu and guvenlikCevabi=@guvCevabi",con);
            cmd.Parameters.AddWithValue("@kulad", kullaniciAdi);
            cmd.Parameters.AddWithValue("@guvSorusu", guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvCevabi", guvenlikCevabi);
            returnValue=(int)cmd.ExecuteScalar();
            con.Close ();

            if(returnValue == 1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }
        }
        public loginStatus changePassword(string kullaniciAdi,string sifre)
        {
            con.Open();
            cmd = new SqlCommand("sifreGüncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnValue=cmd.ExecuteNonQuery();
           
            con.Close() ;

            return loginStatus.basarili;

        }
        public string checkEmilAddres(string kullaniciAdi)
        {
             con.Open ();
            cmd = new SqlCommand("select emailAdres from loginTable where kullaniciAdi=@kulAd", con);
            cmd.Parameters.AddWithValue("@kulAd", kullaniciAdi);
            string emailAdres=(string)cmd.ExecuteScalar();

            con.Close();
            return emailAdres;
        }


        //tek bir kolon dönüyorsa ExecuteScalar metodu kullanılır

        public Urun urunuGetir(string barkod)
        { 
            con.Open ();
            SqlCommand cmd = new SqlCommand("select *from urun where barkodKod = @code", con);
            cmd.Parameters.AddWithValue("@code", barkod);
            dr=cmd.ExecuteReader();

            Urun urun = new Urun();

            while (dr.Read())
            {
           
                urun.fiyat = int.Parse(dr["fiyat"].ToString());
                urun.urunIsim = dr["urunIsim"].ToString();
              
            }

            con.Close();
            return urun;
        }

        public List<User> tumKullanicilariGetir()
        {
            List<User> userList = new List<User>();
            con.Open();
            cmd = new SqlCommand("select * from loginTable", con);
            dr= cmd.ExecuteReader();

            while (dr.Read())
            {
                User user = new User();
                user.id=int.Parse(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.bolge = dr["bölge"].ToString();
                user.emailAddress = dr["emailAdres"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabi"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                userList.Add(user);
            }

            con.Close ();
            return userList;
        }
        public loginStatus kullaniciEkle(User user)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullanicEkle",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@bolge", user.bolge);
            cmd.Parameters.AddWithValue("@mailAdres", user.emailAddress);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", user.guvenlikCevabi);
            int returnvalue = cmd.ExecuteNonQuery();
            
                con.Close();

            if (returnvalue == 1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }

        }
        public loginStatus kullaniciGuncelle(User user)
        {
            con.Open();
            cmd = new SqlCommand("sp_kullaniciGuncelle", con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", user.id);
            cmd.Parameters.AddWithValue("@kullaniciAdi", user.kullaniciAdi);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@bolge", user.bolge);
            cmd.Parameters.AddWithValue("@emailadres", user.emailAddress);
            cmd.Parameters.AddWithValue("@guvenlikCevabi", user.guvenlikCevabi);
            cmd.Parameters.AddWithValue("@guvenlikSorusu", user.guvenlikSorusu);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }
        }
        public loginStatus kullaniciSil(int id)
        {
            con.Open();
            cmd = new SqlCommand("delete from loginTable where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnvalue= cmd.ExecuteNonQuery();
            con.Close();

            if (returnvalue == 1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }
        }
        public List<Urun> tumUrunleriGetir()
        {
            List<Urun> urunList = new List<Urun>();
            con.Open();
            cmd = new SqlCommand("select * from urun", con);
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {

                Urun urun = new Urun();
                urun.id = int.Parse(dr["id"].ToString());
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodKod = dr["barkodKod"].ToString();
                if (!string.IsNullOrEmpty(dr["guncellemeTarih"].ToString()))
                {
                    urun.guncellenmeTarih = DateTime.Parse(dr["guncellemeTarih"].ToString());
                }
                urun.olusturmaTarih = DateTime.Parse(dr["olusturmaTarih"].ToString());
                
                urun.urunIsim = dr["urunIsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString()) ;
                urun.fiyat = int.Parse(dr["fiyat"].ToString() ) ;
                urun.ciro = int.Parse(dr["ciro"].ToString());
                urunList.Add(urun);
            }
            
            con.Close() ;
            return urunList;

        }
        public loginStatus urunEkle(Urun urun)
        {
            con.Open() ;

            cmd = new SqlCommand("sp_urunEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodKod ", urun.barkodKod);
            cmd.Parameters.AddWithValue("@olusturmaTarih", urun.olusturmaTarih);
            cmd.Parameters.AddWithValue("@guncellemeTarih", urun.guncellenmeTarih);
            cmd.Parameters.AddWithValue("@urunIsim", urun.urunIsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            int returnvalue=cmd.ExecuteNonQuery();
            con.Close();

            if(returnvalue==1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }
        }
        public loginStatus urunGuncelle(Urun urun)
        {
            con.Open();
            cmd = new SqlCommand("sp_urunGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodKod", urun.barkodKod);
            cmd.Parameters.AddWithValue("@olusturmaTarih", urun.olusturmaTarih);
            cmd.Parameters.AddWithValue("@guncellemeTarih", urun.guncellenmeTarih);
            cmd.Parameters.AddWithValue("@urunIsim", urun.urunIsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            int returnvalue = cmd.ExecuteNonQuery();

            con.Close();
            if (returnvalue == 1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }

        }
        public loginStatus urunSil( string id)
        {
            con.Open();
            cmd = new SqlCommand("delete from urun where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnvalue = cmd.ExecuteNonQuery();

            con.Close() ;
            if (returnvalue == 1)
            {
                return loginStatus.basarili;
            }
            else
            {
                return loginStatus.basarisiz;
            }
        }

    } }



