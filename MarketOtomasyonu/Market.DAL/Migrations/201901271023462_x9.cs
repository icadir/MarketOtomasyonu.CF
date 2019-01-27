namespace Market.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcceptanceDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Id2 = c.Int(nullable: false),
                        Numberofpieces = c.Decimal(nullable: false, precision: 10, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.Id, t.Id2 })
                .ForeignKey("dbo.Acceptances", t => t.Id2, cascadeDelete: true)
                .ForeignKey("dbo.MultiProducts", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.Id2);
            
            CreateTable(
                "dbo.Acceptances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MultiProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MPBarkod = c.String(nullable: false, maxLength: 11),
                        MPPiece = c.Decimal(nullable: false, precision: 6, scale: 0),
                        MPPrice = c.Decimal(nullable: false, precision: 8, scale: 2),
                        MPExplanation = c.String(nullable: false),
                        MPPicture = c.Binary(),
                        UrunId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.MPBarkod, unique: true, name: "IX_MPUQ")
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PName = c.String(),
                        Barkod = c.String(nullable: false, maxLength: 5),
                        UBPrice = c.Decimal(nullable: false, precision: 10, scale: 2),
                        UPicture = c.Binary(),
                        Stock = c.Decimal(nullable: false, precision: 7, scale: 0),
                        PPiece = c.Decimal(nullable: false, precision: 1, scale: 0),
                        CategoryId = c.Int(nullable: false),
                        PExplanation = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.Barkod, unique: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CName = c.String(nullable: false),
                        KDV = c.Decimal(nullable: false, precision: 4, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales_Detail",
                c => new
                    {
                        UrunId = c.Int(nullable: false),
                        SaleId = c.Int(nullable: false),
                        SPiece = c.Decimal(nullable: false, precision: 10, scale: 0),
                        STotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.UrunId, t.SaleId })
                .ForeignKey("dbo.Products", t => t.UrunId, cascadeDelete: true)
                .ForeignKey("dbo.Sales", t => t.SaleId, cascadeDelete: true)
                .Index(t => t.UrunId)
                .Index(t => t.SaleId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaledTime = c.DateTime(nullable: false),
                        PaymentType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales_Detail", "SaleId", "dbo.Sales");
            DropForeignKey("dbo.Sales_Detail", "UrunId", "dbo.Products");
            DropForeignKey("dbo.MultiProducts", "UrunId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.AcceptanceDetails", "Id", "dbo.MultiProducts");
            DropForeignKey("dbo.AcceptanceDetails", "Id2", "dbo.Acceptances");
            DropIndex("dbo.Sales_Detail", new[] { "SaleId" });
            DropIndex("dbo.Sales_Detail", new[] { "UrunId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "Barkod" });
            DropIndex("dbo.MultiProducts", new[] { "UrunId" });
            DropIndex("dbo.MultiProducts", "IX_MPUQ");
            DropIndex("dbo.AcceptanceDetails", new[] { "Id2" });
            DropIndex("dbo.AcceptanceDetails", new[] { "Id" });
            DropTable("dbo.Sales");
            DropTable("dbo.Sales_Detail");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.MultiProducts");
            DropTable("dbo.Acceptances");
            DropTable("dbo.AcceptanceDetails");
        }
    }
}
