namespace addingFieldsLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calorieuser_activity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserActivities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Activity = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CalorieUsers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        EmailLogin = c.String(),
                        log = c.DateTime(nullable: false),
                        weight = c.Double(nullable: false),
                        height = c.Double(nullable: false),
                        age = c.Int(nullable: false),
                        GenderId = c.Int(nullable: false),
                        CalorieUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CalorieUsers", t => t.CalorieUserId)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .Index(t => t.GenderId)
                .Index(t => t.CalorieUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CalorieUsers", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.CalorieUsers", "CalorieUserId", "dbo.CalorieUsers");
            DropIndex("dbo.CalorieUsers", new[] { "CalorieUserId" });
            DropIndex("dbo.CalorieUsers", new[] { "GenderId" });
            DropTable("dbo.CalorieUsers");
            DropTable("dbo.UserActivities");
        }
    }
}
