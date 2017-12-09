namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ged.archive",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Date_archive = c.DateTime(precision: 0),
                        version = c.String(maxLength: 255, storeType: "nvarchar"),
                        document_fk = c.Int(),
                        folder_fk = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ged.document",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Body = c.String(maxLength: 2000, storeType: "nvarchar"),
                        Entry_Date = c.DateTime(precision: 0),
                        Footer = c.String(maxLength: 255, storeType: "nvarchar"),
                        Titre1 = c.String(maxLength: 255, storeType: "nvarchar"),
                        Titre2 = c.String(maxLength: 255, storeType: "nvarchar"),
                        Type = c.String(maxLength: 255, storeType: "nvarchar"),
                        picture = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ged.documents",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Body = c.String(maxLength: 2000, storeType: "nvarchar"),
                        Entry_Date = c.DateTime(precision: 0),
                        Footer = c.String(maxLength: 255, storeType: "nvarchar"),
                        Titre1 = c.String(maxLength: 255, storeType: "nvarchar"),
                        Titre2 = c.String(maxLength: 255, storeType: "nvarchar"),
                        Type = c.String(maxLength: 255, storeType: "nvarchar"),
                        picture = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ged.folder",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(maxLength: 255, storeType: "nvarchar"),
                        Type = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ged.reclamation",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dateSol = c.DateTime(precision: 0),
                        dateTrait = c.DateTime(precision: 0),
                        message = c.String(maxLength: 255, storeType: "nvarchar"),
                        reclamDate = c.DateTime(precision: 0),
                        statuts = c.String(maxLength: 255, storeType: "nvarchar"),
                        subject = c.String(maxLength: 255, storeType: "nvarchar"),
                        usr_cin = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "ged.user",
                c => new
                    {
                        cin = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        login = c.String(maxLength: 255, storeType: "nvarchar"),
                        mail = c.String(maxLength: 255, storeType: "nvarchar"),
                        nomUser = c.String(maxLength: 255, storeType: "nvarchar"),
                        password = c.String(maxLength: 255, storeType: "nvarchar"),
                        prenomUser = c.String(maxLength: 255, storeType: "nvarchar"),
                        role = c.String(maxLength: 255, storeType: "nvarchar"),
                        tel = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.cin);
            
        }
        
        public override void Down()
        {
            DropTable("ged.user");
            DropTable("ged.reclamation");
            DropTable("ged.folder");
            DropTable("ged.documents");
            DropTable("ged.document");
            DropTable("ged.archive");
        }
    }
}
