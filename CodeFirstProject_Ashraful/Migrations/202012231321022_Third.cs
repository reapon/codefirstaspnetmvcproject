namespace CodeFirstProject_Ashraful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String());
            AlterColumn("dbo.Suppliers", "Email", c => c.String());
            AlterColumn("dbo.Suppliers", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "ImagePath", c => c.String(nullable: false));
            AlterColumn("dbo.Suppliers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String(nullable: false));
        }
    }
}
