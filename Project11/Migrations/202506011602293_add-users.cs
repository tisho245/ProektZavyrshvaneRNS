namespace Project11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addusers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 128),
                        ProductNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductNumber, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Username)
                .Index(t => t.Username)
                .Index(t => t.ProductNumber);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 50),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Username)
                .Index(t => t.Email, unique: true);
            
            AddColumn("dbo.ProductTypes", "ProductTypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sells", "Username", "dbo.Users");
            DropForeignKey("dbo.Sells", "ProductNumber", "dbo.Products");
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Sells", new[] { "ProductNumber" });
            DropIndex("dbo.Sells", new[] { "Username" });
            DropColumn("dbo.ProductTypes", "ProductTypeName");
            DropTable("dbo.Users");
            DropTable("dbo.Sells");
        }
    }
}
