namespace TicketingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
    INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'65cfe62f-64a1-4a9c-bfd9-7902735e3679', N'test@mail.com', 0, N'AP48NUr2KcsrYz+EMtak80MUCGojgN3VutXjCTsXGFM5IA/qzNxGQcksq+4+0TGe8g==', N'f0f00e4d-b5bf-4cb3-92b1-e30c672202d0', NULL, 0, 0, NULL, 1, 0, N'test@mail.com');
    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'61ad7bda-29bb-45cc-8674-36c4e83172cf', N'Admin');
            ");

            //foreign key constraint ?? what ??
            //wilt dus nie gemaakt worden omdat de vorige lijnen nog niet in de db staan
            //en in een tweede reload bestaat de DB al en maakt hij het dus niet aan.
            //Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'65cfe62f-64a1-4a9c-bfd9-7902735e3679', N'61ad7bda-29bb-45cc-8674-36c4e83172cf');");

            //andere users
            Sql(@"
    INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'207b4b0a-e9ec-436d-9571-358573c24f9d', N'user2@mail.com', 0, N'AJOxRUW8TBSM5KuaJcGVzthz7Nkhha3yB/m/dz42ZltmkjlCPkQIp1tp0AQffYwbyA==', N'0873b33e-df67-437b-85f0-9a9664ee9fc8', NULL, 0, 0, NULL, 1, 0, N'user2@mail.com');
    INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'5d8ab9a0-9907-40dd-9e89-82bcd40af0a4', N'user1@mail.com', 0, N'ANb8M2IDdWhxOr8ypomThWRZtO2XLp4JiXRppfnKKLvzf1uadxe/AuHrBfc+efbEsQ==', N'acbb4744-1dbc-42d4-bc95-cf15c982eb84', NULL, 0, 0, NULL, 1, 0, N'user1@mail.com');
            ");
        }

        public override void Down()
        {
        }
    }
}
