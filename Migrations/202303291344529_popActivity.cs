namespace addingFieldsLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popActivity : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT UserActivities ON;");

            Sql("INSERT INTO UserActivities (id , Activity) VALUES (1 , 'BMR')");
            Sql("INSERT INTO UserActivities (id , Activity) VALUES (2 , 'Sedentary : little or no exercise')");
            Sql("INSERT INTO UserActivities (id , Activity) VALUES (3 , 'Light : exercise 1-3 times/week')");
            Sql("INSERT INTO UserActivities (id , Activity) VALUES (4 , 'Moderate : exercise 3-5 times/week')");
            Sql("INSERT INTO UserActivities (id , Activity) VALUES (5 , 'Active : exercise everyday/intense exercise 3-4 times/week')");
            Sql("INSERT INTO UserActivities (id , Activity) VALUES (6 , 'Very Active : intense exercise 6-7 times/week')");

            Sql("SET IDENTITY_INSERT UserActivities OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
