namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountsHeads",
                c => new
                    {
                        AccountsHeadId = c.Int(nullable: false, identity: true),
                        AccountsHeadName = c.String(nullable: false),
                        TransactionType = c.Int(nullable: false),
                        ReportHeadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AccountsHeadId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountsHeads");
        }
    }
}
