using System.Data.Entity.Migrations;

namespace DevNext.Web.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserGroupEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 500),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        IsVirtualEvent = c.Boolean(nullable: false),
                        Address = c.String(maxLength: 1000),
                        City = c.String(),
                        Country = c.String(),
                        Url = c.String(),
                        Description = c.String(nullable: false, maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FullName = c.String(),
                        Email = c.String(),
                        ContactNumber = c.String(),
                        UserGroupEvent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserGroupEvents", t => t.UserGroupEvent_Id)
                .Index(t => t.UserGroupEvent_Id);

            CreateTable(
                "dbo.TechnicalContents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 500),
                        Url = c.String(),
                        SlidesUrl = c.String(),
                        DemoCodeUrl = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropIndex("dbo.UserProfile", new[] {"UserGroupEvent_Id"});
            DropForeignKey("dbo.UserProfile", "UserGroupEvent_Id", "dbo.UserGroupEvents");
            DropTable("dbo.TechnicalContents");
            DropTable("dbo.UserProfile");
            DropTable("dbo.UserGroupEvents");
        }
    }
}