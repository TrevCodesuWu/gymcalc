namespace addingFieldsLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
           INSERT INTO [dbo].[AspNetUsers] ([Id], [Name], [year_born], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a3c2838-e919-4824-9a58-35523c60170c', N'Trainer01', N'1990-12-25 00:00:00', N'Trainer01@gmail.com', 0, N'APXtoux1ikyXaHjgpTJFY9UKaSwgwB0VXw6RfJLqNn41IiJkG0+KzhhFKukmzKPB7Q==', N'cec789f6-2d4b-4e43-b575-88385468fc91', NULL, 0, 0, NULL, 1, 0, N'Trainer01@gmail.com')
           INSERT INTO [dbo].[AspNetUsers] ([Id], [Name], [year_born], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'af166403-a7cc-4896-b207-9848b52a8759', N'AdminUser01', N'2000-09-23 00:00:00', N'AdminUser01@gmail.com', 0, N'ACc6LlP5I5m84BVuG2f/O7Vvml2jbffZJZ573lxSjHcjSJoqeHjDSwONwN7T4R/TYg==', N'5f6d4869-57e3-4a36-82fc-cd89cc6c3af1', NULL, 0, 0, NULL, 1, 0, N'AdminUser01@gmail.com')

           INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7c2a5338-271c-4103-8450-07a03707c874', N'AdminRole')
           INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4afd7208-d4e4-4f02-aad9-5191e90829d7', N'TrainerRole')

           INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a3c2838-e919-4824-9a58-35523c60170c', N'4afd7208-d4e4-4f02-aad9-5191e90829d7')
           INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'af166403-a7cc-4896-b207-9848b52a8759', N'7c2a5338-271c-4103-8450-07a03707c874')

");
        }
        
        public override void Down()
        {
        }
    }
}
