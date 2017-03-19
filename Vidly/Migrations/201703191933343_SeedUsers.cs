namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6053d95d-31a2-4333-a419-268bb1feacdd', N'admin@vidly.com', 0, N'ADzx4+ASkMkoYE2YYCtJQZBWAftoMtff1IDdMCS4URH0g1YqDyr4NytgfZTxsM51mg==', N'd558dc52-f969-4ba2-a748-2a4eded17061', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fc8d8e6f-2976-4067-9f9a-e8a98da3d894', N'guest@vidly.com', 0, N'AMQYIPwDl27N1BMSYBpLpNdTPNu6lKHANevyjLqLe52TUyyL9MZagdQd9Vt2H8RJ9g==', N'247b8b09-23fa-43ac-8640-2ecd8169c9d3', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0f3e0305-58dd-47ba-9128-e90b410356da', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6053d95d-31a2-4333-a419-268bb1feacdd', N'0f3e0305-58dd-47ba-9128-e90b410356da')
");
        }

        public override void Down()
        {
        }
    }
}
