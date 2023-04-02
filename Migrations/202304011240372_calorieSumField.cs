namespace addingFieldsLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calorieSumField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CalorieUsers", "caloriessum", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CalorieUsers", "caloriessum");
        }
    }
}
