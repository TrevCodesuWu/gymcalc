namespace addingFieldsLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmodelidealweight : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IdealWeights",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        EmailLogin = c.String(),
                        log = c.DateTime(nullable: false),
                        weightsum = c.Double(),
                        height = c.Double(nullable: false),
                        age = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .Index(t => t.GenderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdealWeights", "GenderId", "dbo.Genders");
            DropIndex("dbo.IdealWeights", new[] { "GenderId" });
            DropTable("dbo.IdealWeights");
        }
    }
}
