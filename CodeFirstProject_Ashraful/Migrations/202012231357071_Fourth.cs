namespace CodeFirstProject_Ashraful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fourth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.String(),
                        Office = c.String(),
                        Salary = c.Int(nullable: false),
                        ImagePath = c.String(),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String(nullable: false));
            AlterColumn("dbo.Suppliers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Email", c => c.String());
            AlterColumn("dbo.Suppliers", "SupplierName", c => c.String());
            DropTable("dbo.Employees");
        }
    }
}
