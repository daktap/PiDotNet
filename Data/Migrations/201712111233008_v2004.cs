namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2004 : DbMigration
    {
        public override void Up()
        {
            AddColumn("ged.reclamation", "type", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("ged.reclamation", "type");
        }
    }
}
