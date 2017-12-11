namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventDate = c.DateTime(nullable: false, precision: 0),
                        EventPlace = c.String(unicode: false),
                        EventTitle = c.String(unicode: false),
                        EventDesc = c.String(unicode: false),
                        EventAffiche = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Eventusers",
                c => new
                    {
                        Event_EventId = c.Int(nullable: false),
                        user_cin = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.Event_EventId, t.user_cin })
                .ForeignKey("dbo.Events", t => t.Event_EventId, cascadeDelete: true)
                .ForeignKey("ged.user", t => t.user_cin, cascadeDelete: true)
                .Index(t => t.Event_EventId)
                .Index(t => t.user_cin);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Eventusers", "user_cin", "ged.user");
            DropForeignKey("dbo.Eventusers", "Event_EventId", "dbo.Events");
            DropIndex("dbo.Eventusers", new[] { "user_cin" });
            DropIndex("dbo.Eventusers", new[] { "Event_EventId" });
            DropTable("dbo.Eventusers");
            DropTable("dbo.Events");
        }
    }
}
