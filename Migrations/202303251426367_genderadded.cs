namespace addingFieldsLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genderadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        gender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Users", "GenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "GenderId");
            AddForeignKey("dbo.Users", "GenderId", "dbo.Genders", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "GenderId", "dbo.Genders");
            DropIndex("dbo.Users", new[] { "GenderId" });
            DropColumn("dbo.Users", "GenderId");
            DropTable("dbo.Genders");
        }
    }
}
