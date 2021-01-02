namespace finalproje1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resulmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActiveUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        KullaniciAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DeleteUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        KullaniciAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PasiveUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        KullaniciAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiteUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        KullaniciAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SiteUsers");
            DropTable("dbo.PasiveUsers");
            DropTable("dbo.DeleteUsers");
            DropTable("dbo.ActiveUsers");
        }
    }
}
