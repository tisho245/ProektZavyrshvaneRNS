namespace Project11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixdb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sells", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sells", "Status");
        }
    }
}
