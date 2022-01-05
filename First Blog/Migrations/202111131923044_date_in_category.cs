namespace First_Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date_in_category : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT dbo.categories ON");
            Sql("INSERT INTO[dbo].[categories]([Id], [Name]) VALUES(1, N'Sports')");
            Sql("INSERT INTO[dbo].[categories]([Id], [Name]) VALUES(2, N'Food')");
            Sql("INSERT INTO[dbo].[categories]([Id], [Name]) VALUES(3, N'Movies')");
            

        }
        
        public override void Down()
        {
        }
    }
}
