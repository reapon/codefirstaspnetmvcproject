namespace CodeFirstProject_Ashraful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Five : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerRegistrations",
                c => new
                    {
                        CustomerRegistrationID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 30),
                        Gender = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerRegistrationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerRegistrations");
        }
    }
}
