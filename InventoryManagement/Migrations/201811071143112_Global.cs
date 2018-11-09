namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Global : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Concerns",
                c => new
                    {
                        ConcernID = c.Int(nullable: false, identity: true),
                        ConcernName = c.String(),
                        Description = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        Creator = c.Int(nullable: false),
                        IsDelete = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConcernID);
            
            CreateTable(
                "dbo.SystemUsers",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Password = c.String(),
                        IsDisabled = c.Int(nullable: false),
                        LoginDate = c.DateTime(nullable: false),
                        EmailAddress = c.String(),
                        LoginFailedCount = c.Int(nullable: false),
                        Language = c.String(),
                        ActivationDate = c.DateTime(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        HashSalt = c.String(),
                        CreatorId = c.Int(nullable: false),
                        ConcernID = c.Int(nullable: false),
                        IsDelete = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemUsers");
            DropTable("dbo.Concerns");
        }
    }
}
