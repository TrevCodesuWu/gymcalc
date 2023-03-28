namespace addingFieldsLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usermodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        EmailLogin = c.String(),
                        log = c.DateTime(nullable: false),
                        weight = c.Double(nullable: false),
                        height = c.Double(nullable: false),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
