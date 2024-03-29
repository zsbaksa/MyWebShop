namespace MyWebShop.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductValidatorAttributesAgain : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 21));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
