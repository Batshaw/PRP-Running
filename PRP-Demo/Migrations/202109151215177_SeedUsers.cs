namespace PRP_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FullName], [DateOfBirth], [WeightsInKg], [GenderId]) VALUES (N'e302672f-9c62-4ef6-b189-6e58c1223d21', N'guest@prp.com', 0, N'AFPXoS17Muh6OjMPyf9rAI18rNNnC5Dcl5FP4gfrqOZj2TT3wliBDJmAKni3/wC4HA==', N'b9f42265-080b-4acf-a8bd-2f926138162e', NULL, 0, 0, NULL, 1, 0, N'guest@prp.com', N'guest01', CAST('1992-02-25' AS DATETIME), 63, 1)
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FullName], [DateOfBirth], [WeightsInKg], [GenderId]) VALUES (N'e9ef32f7-83ec-4e1b-ae56-fe783ba78978', N'admin@prp.com', 0, N'AERNQ9vemQ0aKLK4Rqflm6vQNFHlofW5flTwidlixcFOVUJYI2yMmSZ8cd1Tu979WA==', N'58861698-ea11-4707-bd7c-cae6728f0ae8', NULL, 0, 0, NULL, 1, 0, N'admin@prp.com', N'admin', CAST('1992-02-25' AS DATETIME), 63, 1)
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bb3600c8-b029-4e9d-9e92-cf36904f8ff1', N'CanManageCustomers')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e9ef32f7-83ec-4e1b-ae56-fe783ba78978', N'bb3600c8-b029-4e9d-9e92-cf36904f8ff1')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
