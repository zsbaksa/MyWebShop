namespace MyWebShop.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryToProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Category");
        }
    }
}
