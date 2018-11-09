namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountingModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        JournalId = c.Int(nullable: false, identity: true),
                        JournalEntryDate = c.DateTime(nullable: false),
                        DebitJournalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DebitAccountsHeadId = c.Int(nullable: false),
                        CreditJournalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreditAccountsHeadId = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.JournalId);
            
            CreateTable(
                "dbo.ReportHeads",
                c => new
                    {
                        ReportHeadId = c.Int(nullable: false, identity: true),
                        ReportHeadName = c.String(nullable: false),
                        ReportType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReportHeadId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReportHeads");
            DropTable("dbo.Journals");
        }
    }
}
