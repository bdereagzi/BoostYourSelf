namespace BoostYourselfSonInch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Besinler",
                c => new
                    {
                        BesinId = c.Int(nullable: false, identity: true),
                        YiyecekAdi = c.String(nullable: false, maxLength: 50),
                        Miktar = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Porsiyonlar = c.Int(nullable: false),
                        Kalori = c.Decimal(nullable: false, precision: 5, scale: 2),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BesinId)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Ogunler",
                c => new
                    {
                        OgunId = c.Int(nullable: false, identity: true),
                        OgunAdi = c.String(nullable: false, maxLength: 50),
                        OlusturulmaZamani = c.DateTime(nullable: false),
                        Ogunler = c.Int(nullable: false),
                        ToplamKalori = c.Decimal(nullable: false, precision: 5, scale: 2),
                        KullaniciId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgunId)
                .ForeignKey("dbo.Kullanicilar", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50),
                        Ad = c.String(),
                        Soyad = c.String(),
                        KayitZamani = c.DateTime(nullable: false),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 50),
                        DogumTarihi = c.DateTime(nullable: false),
                        Boy = c.Int(nullable: false),
                        Kilo = c.Decimal(nullable: false, precision: 4, scale: 1),
                        Cinsiyet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KullaniciId);
            
            CreateTable(
                "dbo.OgunBesins",
                c => new
                    {
                        Ogun_OgunId = c.Int(nullable: false),
                        Besin_BesinId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogun_OgunId, t.Besin_BesinId })
                .ForeignKey("dbo.Ogunler", t => t.Ogun_OgunId, cascadeDelete: true)
                .ForeignKey("dbo.Besinler", t => t.Besin_BesinId, cascadeDelete: true)
                .Index(t => t.Ogun_OgunId)
                .Index(t => t.Besin_BesinId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogunler", "KullaniciId", "dbo.Kullanicilar");
            DropForeignKey("dbo.OgunBesins", "Besin_BesinId", "dbo.Besinler");
            DropForeignKey("dbo.OgunBesins", "Ogun_OgunId", "dbo.Ogunler");
            DropForeignKey("dbo.Besinler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.OgunBesins", new[] { "Besin_BesinId" });
            DropIndex("dbo.OgunBesins", new[] { "Ogun_OgunId" });
            DropIndex("dbo.Ogunler", new[] { "KullaniciId" });
            DropIndex("dbo.Besinler", new[] { "KategoriId" });
            DropTable("dbo.OgunBesins");
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.Ogunler");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Besinler");
        }
    }
}
