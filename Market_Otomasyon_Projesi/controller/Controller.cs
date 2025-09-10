using Market_Otomasyon_Projesi.dao;
using Market_Otomasyon_Projesi.enumaration;
using Market_Otomasyon_Projesi.model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Otomasyon_Projesi.controller
{
    public class Controller
    {
        Repository repository;

        public Controller()
        {
            repository = new Repository();
        }
        public User login(string kullaniciAdi, string sifre)
        {

            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                User result = repository.login(kullaniciAdi, sifre);
                return result;
            }
            else
            {
                User user = new User();
                user.status = loginStatus.eksikParametre;
                return user;
            }

        }
        public List<LoginTables> getLoginTable()
        {
            List<LoginTables> loginTablelist = repository.getLoginTable();
            return loginTablelist;
        }
        public loginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(guvenlikCevabi) && !string.IsNullOrEmpty(guvenlikSorusu))
            {
                loginStatus result = repository.doAuthentication(kullaniciAdi, guvenlikSorusu, guvenlikCevabi);

                if (result == loginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return loginStatus.basarisiz;
                }

            }
            else
            {
                return loginStatus.eksikParametre;
            }

        }
        public loginStatus changePassword(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return repository.changePassword(kullaniciAdi, sifre);
            }
            else
            {
                return loginStatus.eksikParametre;

            }
        }

        public string checkEmilAddres(string kullaniciAdi)
        {
            return repository.checkEmilAddres(kullaniciAdi);
        }
        public Urun urunuGetir(string barkod)
        { 
            if (!string.IsNullOrEmpty(barkod))
            {
                return repository.urunuGetir(barkod);
            }
            return null;

        }

        public List<User> tumKullanicilariGetir()
        {
            Controller controller = new Controller();
            return repository.tumKullanicilariGetir();
        }
        public loginStatus kullaniciEkle(User user)
        {
            if (!string.IsNullOrEmpty(user.kullaniciAdi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.yetki) && !string.IsNullOrEmpty(user.emailAddress) && !string.IsNullOrEmpty(user.guvenlikCevabi)&& !string.IsNullOrEmpty(user.guvenlikCevabi))
            {
               
                loginStatus sonuc = repository.kullaniciEkle(user);
                return sonuc;
            }
            else
            {
                return loginStatus.eksikParametre;
            }
        }


        public loginStatus kullaniciGuncelle(User user)
        {
            //return repository.kullaniciGuncelle(user);

            if (!string.IsNullOrEmpty(user.id.ToString()))
            {
                return repository.kullaniciGuncelle(user);
            }
            else
            {
                return loginStatus.eksikParametre;
            }
        }
        public loginStatus kullaniciSil(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                return repository.kullaniciSil(id);
             
            }
            else
            {
                return loginStatus.eksikParametre;
            }
        }
        public List<Urun> tumUrunleriGetir()
        {
            return repository.tumUrunleriGetir();
        }
        public loginStatus urunEkle(Urun urun)
        {
            if(!string.IsNullOrEmpty(urun.id.ToString()) && !string.IsNullOrEmpty(urun.urunIsim)&& !string.IsNullOrEmpty(urun.barkodKod))
            {
                return repository.urunEkle(urun);
            }
            else
            {
                return loginStatus.eksikParametre;
            }
        }
        public loginStatus urunGuncelle(Urun urun)
        {
            if (!string.IsNullOrEmpty(urun.id.ToString()) && !string.IsNullOrEmpty(urun.urunIsim) && !string.IsNullOrEmpty(urun.barkodKod))
            {
                return repository.urunGuncelle(urun);
            }
            else
            {
                return loginStatus.eksikParametre;
            }
        }
        public loginStatus urunSil(string id)
        {  if (!string.IsNullOrEmpty(id))
            {
                return repository.urunSil(id);
            }
            else
            {
                return loginStatus.eksikParametre;
            }
            
        }
    }

}
