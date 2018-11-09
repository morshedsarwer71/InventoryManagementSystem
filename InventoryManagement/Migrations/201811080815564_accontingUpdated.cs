namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class accontingUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountsHeads", "AccountsHeadNameEN", c => c.String());
            AddColumn("dbo.AccountsHeads", "CreationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AccountsHeads", "CreatorId", c => c.Int(nullable: false));
            AddColumn("dbo.AccountsHeads", "IsDelete", c => c.Int(nullable: false));
            AddColumn("dbo.AccountsHeads", "ModificationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AccountsHeads", "ModifierId", c => c.Int(nullable: false));
            AddColumn("dbo.AccountsHeads", "AccountsHeadNameAR", c => c.String());
            AddColumn("dbo.AccountsHeads", "ConcernId", c => c.Int(nullable: false));
            AddColumn("dbo.Journals", "ConcernId", c => c.Int(nullable: false));
            AddColumn("dbo.Journals", "IsDelete", c => c.Int(nullable: false));
            AddColumn("dbo.Journals", "JournalCreationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Journals", "JournalCreator", c => c.Int(nullable: false));
            AddColumn("dbo.Journals", "JournalModificationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Journals", "JournalModifierId", c => c.Int(nullable: false));
            AddColumn("dbo.ReportHeads", "ReportHeadNameEN", c => c.String());
            AddColumn("dbo.ReportHeads", "ReportHeadNameAR", c => c.String());
            AddColumn("dbo.ReportHeads", "CreationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ReportHeads", "CreatorId", c => c.Int(nullable: false));
            AddColumn("dbo.ReportHeads", "IsDelete", c => c.Int(nullable: false));
            AddColumn("dbo.ReportHeads", "ModificationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ReportHeads", "ModifierId", c => c.Int(nullable: false));
            AlterColumn("dbo.Journals", "Description", c => c.String());
            DropColumn("dbo.AccountsHeads", "AccountsHeadName");
            DropColumn("dbo.ReportHeads", "ReportHeadName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReportHeads", "ReportHeadName", c => c.String(nullable: false));
            AddColumn("dbo.AccountsHeads", "AccountsHeadName", c => c.String(nullable: false));
            AlterColumn("dbo.Journals", "Description", c => c.String(nullable: false));
            DropColumn("dbo.ReportHeads", "ModifierId");
            DropColumn("dbo.ReportHeads", "ModificationDate");
            DropColumn("dbo.ReportHeads", "IsDelete");
            DropColumn("dbo.ReportHeads", "CreatorId");
            DropColumn("dbo.ReportHeads", "CreationDate");
            DropColumn("dbo.ReportHeads", "ReportHeadNameAR");
            DropColumn("dbo.ReportHeads", "ReportHeadNameEN");
            DropColumn("dbo.Journals", "JournalModifierId");
            DropColumn("dbo.Journals", "JournalModificationDate");
            DropColumn("dbo.Journals", "JournalCreator");
            DropColumn("dbo.Journals", "JournalCreationDate");
            DropColumn("dbo.Journals", "IsDelete");
            DropColumn("dbo.Journals", "ConcernId");
            DropColumn("dbo.AccountsHeads", "ConcernId");
            DropColumn("dbo.AccountsHeads", "AccountsHeadNameAR");
            DropColumn("dbo.AccountsHeads", "ModifierId");
            DropColumn("dbo.AccountsHeads", "ModificationDate");
            DropColumn("dbo.AccountsHeads", "IsDelete");
            DropColumn("dbo.AccountsHeads", "CreatorId");
            DropColumn("dbo.AccountsHeads", "CreationDate");
            DropColumn("dbo.AccountsHeads", "AccountsHeadNameEN");
        }
    }
}
