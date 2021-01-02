using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalproje1.SqlKomutlari
{
    public class ExecuteCommand
    {
        DatabaseContext db;
        public ExecuteCommand()
        {
            db = new DatabaseContext();
        }
        
        public List<fonksyonSiteCount> SiteCount()
        {
            return db.Database.SqlQuery<fonksyonSiteCount>("select  resulkd.SiteCount() as sayi").ToList();
        }
        public List<prosedurKullaniciBilgileriById> prosedurKullaniciBilgileriById(int id)
        {
            return db.Database.SqlQuery<prosedurKullaniciBilgileriById>("exec prosedurKullaniciBilgileriById " + id ).ToList();
        }

        public List<fonksyonSiteCount> fonksyondanGelenSayi{ get; set; }
    }
    public class fonksyonSiteCount
    {
        public int sayi { get; set; }
    }  
    
    public class prosedurKullaniciBilgileriById
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
       
    }
}