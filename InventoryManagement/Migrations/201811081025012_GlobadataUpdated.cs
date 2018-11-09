namespace InventoryManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GlobadataUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Concerns", "ConcernNameAR", c => c.String());
            AddColumn("dbo.Concerns", "ConcernNameEN", c => c.String());
            AddColumn("dbo.Concerns", "CreatorId", c => c.Int(nullable: false));
            AddColumn("dbo.Concerns", "ModificationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Concerns", "ModifierId", c => c.Int(nullable: false));
            DropColumn("dbo.Concerns", "ConcernName");
            DropColumn("dbo.Concerns", "Description");
            DropColumn("dbo.Concerns", "Creator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Concerns", "Creator", c => c.Int(nullable: false));
            AddColumn("dbo.Concerns", "Description", c => c.String());
            AddColumn("dbo.Concerns", "ConcernName", c => c.String());
            DropColumn("dbo.Concerns", "ModifierId");
            DropColumn("dbo.Concerns", "ModificationDate");
            DropColumn("dbo.Concerns", "CreatorId");
            DropColumn("dbo.Concerns", "ConcernNameEN");
            DropColumn("dbo.Concerns", "ConcernNameAR");
        }
    }
}
