namespace Project11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProjectNumber = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpirationDate = c.DateTime(nullable: false),
                        ProductTypeNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectNumber)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeNumber, cascadeDelete: true)
                .Index(t => t.ProductTypeNumber);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        ProductTypeNumber = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ProductTypeNumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductTypeNumber", "dbo.ProductTypes");
            DropIndex("dbo.Products", new[] { "ProductTypeNumber" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
        }
    }
}
