namespace finalproje1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<finalproje1.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(finalproje1.DatabaseContext context)
        {
            //TRIGGER: 
            context.Database.ExecuteSqlCommand(@"
           Create trigger Pasive_Users on ActiveUsers
           After delete
           As
           Begin
           Declare @ad nvarchar(50) 
           Declare @soyad nvarchar(50) 
           Declare @kullaniciadi nvarchar(50) 
           Select @ad=Ad from deleted
           Select @soyad=Soyad from deleted
           Select @kullaniciadi=KullaniciAdi from deleted
           Insert into PasiveUsers values(@ad,@soyad,@kullaniciadi)        
           End"
                );
            context.Database.ExecuteSqlCommand(@"
           Create trigger Active_Users on PasiveUsers
           After delete
           As
           Begin
           Declare @ad nvarchar(50) 
           Declare @soyad nvarchar(50) 
           Declare @kullaniciadi nvarchar(50) 
           Select @ad=Ad from deleted
           Select @soyad=Soyad from deleted
           Select @kullaniciadi=KullaniciAdi from deleted
           Insert into ActiveUsers values(@ad,@soyad,@kullaniciadi)
           End");
            context.Database.ExecuteSqlCommand(@"
            create TRIGGER Trg_After_Insert_Site_Users ON SiteUsers After INSERT
            AS
            BEGIN
            declare @ad varchar(50)
            SELECT @ad = Ad FROM inserted
            Declare @soyad nvarchar(50) 
            Select @soyad=Soyad from inserted
            Declare @kullaniciadi varchar(50)
            Select @kullaniciadi= KullaniciAdi from inserted
            Insert into Activeusers values(@ad,@soyad,@kullaniciadi)           
            END
");
            context.Database.ExecuteSqlCommand(@"
            Create trigger Delete_Users on SiteUsers
            After delete
            As
            Begin
            Declare @ad nvarchar(50) 
            Declare @soyad nvarchar(50) 
            Declare @kullaniciadi nvarchar(50) 
            Select @ad=Ad from deleted
            Select @soyad=Soyad from deleted
            Select @kullaniciadi=KullaniciAdi from deleted
            Insert into DeleteUsers values(@ad,@soyad,@kullaniciadi)
            delete from ActiveUsers where Ad=@ad and Soyad=@soyad and KullaniciAdi=@kullaniciadi
            End");

            //FONKSYON:sitedeki kullanici sayisi
            context.Database.ExecuteSqlCommand(@"
			create function SiteCount()
            returns int
            as
            begin
            declare @counter int;

            select @counter = Count(Id) from SiteUsers
            return @counter;
            end
            ");
            //PROSEDUR: idsi verilen kullanıcının kullanıcı bilgilerini verir
            context.Database.ExecuteSqlCommand(@"
            create procedure prosedurKullaniciBilgileriById
            @id int
            AS 
            Begin
            select Ad, Soyad, KullaniciAdi from SiteUsers where Id = @id
            end
            ");
        }
    }
}
