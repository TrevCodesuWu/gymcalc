namespace addingFieldsLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popgender : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genders ON;");
            Sql("INSERT INTO Genders (id , gender) VALUES (1 , 'Male')");
            Sql("INSERT INTO Genders (id , gender) VALUES (2 , 'Female')");
            Sql("SET IDENTITY_INSERT Genders OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
