namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anomalies",
                c => new
                    {
                        AnomalyID = c.Int(nullable: false, identity: true),
                        TitleAnomaly = c.String(unicode: false),
                        DateAnomaly = c.DateTime(nullable: false, precision: 0),
                        DescAnomaly = c.String(unicode: false),
                        DocId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AnomalyID)
                .ForeignKey("ged.document", t => t.DocId, cascadeDelete: true)
                .Index(t => t.DocId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Anomalies", "DocId", "ged.document");
            DropIndex("dbo.Anomalies", new[] { "DocId" });
            DropTable("dbo.Anomalies");
        }
    }
}
