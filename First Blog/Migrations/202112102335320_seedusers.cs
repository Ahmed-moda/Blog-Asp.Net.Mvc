namespace First_Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedusers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'02408712-a2c9-4689-b98d-8eaeea7245d2', N'admin@blog.com', 0, N'AAd7pgtj0cVwlO5uS+6dUDSp9DJmCb8VxDG3/2A3HwOhMVln6V9v5IST1qlI2Ixriw==', N'20d54afb-9e91-45e7-885a-7013a91c0f1d', NULL, 0, 0, NULL, 1, 0, N'admin@blog.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a1168160-4ae7-4f2a-8426-48f16f03d678', N'ahmedmoda2040@gmail.com', 0, N'APo8GkMRj30m6UTCvZqcPJ+CRy6RYEJVfH/vFTc/UJ2nMbIcVBQdr2ddHcT/nA7szw==', N'c1adeae4-cda3-4baf-829f-67ef8a154966', NULL, 0, 0, NULL, 1, 0, N'ahmedmoda2040@gmail.com')
 
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'86d7f5e9-f753-4470-bd56-6f92a889995c', N'Admin')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'02408712-a2c9-4689-b98d-8eaeea7245d2', N'86d7f5e9-f753-4470-bd56-6f92a889995c')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
