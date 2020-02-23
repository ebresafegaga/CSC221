namespace Northwind.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Complains",
                c => new
                    {
                        ComplainID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Location = c.Int(nullable: false),
                        User_MainUserID = c.Int(),
                    })
                .PrimaryKey(t => t.ComplainID)
                .ForeignKey("dbo.MainUsers", t => t.User_MainUserID)
                .Index(t => t.User_MainUserID);
            
            CreateTable(
                "dbo.MainUsers",
                c => new
                    {
                        MainUserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.Int(nullable: false),
                        PasswordCheck = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MainUserID);
            
            CreateTable(
                "dbo.FacilityManagers",
                c => new
                    {
                        FacilityManagerID = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        UserName = c.String(),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.Int(nullable: false),
                        PasswordCheck = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FacilityManagerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Complains", "User_MainUserID", "dbo.MainUsers");
            DropIndex("dbo.Complains", new[] { "User_MainUserID" });
            DropTable("dbo.FacilityManagers");
            DropTable("dbo.MainUsers");
            DropTable("dbo.Complains");
        }
    }
}
