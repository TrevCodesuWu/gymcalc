namespace addingFieldsLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedmodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CalorieUsers", "CalorieUserId", "dbo.CalorieUsers");
            DropIndex("dbo.CalorieUsers", new[] { "CalorieUserId" });
            AddColumn("dbo.CalorieUsers", "UserActivityId", c => c.Int(nullable: false));
            CreateIndex("dbo.CalorieUsers", "UserActivityId");
            AddForeignKey("dbo.CalorieUsers", "UserActivityId", "dbo.UserActivities", "id", cascadeDelete: true);
            DropColumn("dbo.CalorieUsers", "CalorieUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CalorieUsers", "CalorieUserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.CalorieUsers", "UserActivityId", "dbo.UserActivities");
            DropIndex("dbo.CalorieUsers", new[] { "UserActivityId" });
            DropColumn("dbo.CalorieUsers", "UserActivityId");
            CreateIndex("dbo.CalorieUsers", "CalorieUserId");
            AddForeignKey("dbo.CalorieUsers", "CalorieUserId", "dbo.CalorieUsers", "id");
        }
    }
}
