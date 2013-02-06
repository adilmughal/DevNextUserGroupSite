using System.Data.Entity.Migrations;
using System.Web.Security;
using DevNext.Web.Models;
using WebMatrix.WebData;

namespace DevNext.Web.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DevNextDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DevNextDbContext context)
        {
            if (!WebSecurity.Initialized)
                WebSecurity.InitializeDatabaseConnection(
                    "DefaultConnection",
                    "UserProfile",
                    "UserId",
                    "UserName", autoCreateTables: true);

            if (!Roles.RoleExists("Administrator"))
                Roles.CreateRole("Administrator");

            if (!Roles.RoleExists("CommunityLeader"))
                Roles.CreateRole("CommunityLeader");


            if (!Roles.RoleExists("CommunityMember"))
                Roles.CreateRole("CommunityMember");

            if (!WebSecurity.UserExists("adil.mughal"))
                WebSecurity.CreateUserAndAccount(
                    "adil.mughal",
                    "p@ssw0rd12345",
                    new
                        {
                            Email = "adil.mughal@live.com",
                            FullName = "Adil Ahmed Mughal",
                            ContactNumber = "+92"
                        });
            if (!Roles.IsUserInRole("adil.mughal", "Administrator"))
                Roles.AddUserToRole("adil.mughal", "Administrator");

            if (!Roles.IsUserInRole("adil.mughal", "CommunityLeader"))
                Roles.AddUserToRole("adil.mughal", "CommunityLeader");


            context.TechnicalContents.AddOrUpdate(c => c.Id,
                                                  new TechnicalContent
                                                      {
                                                          Title = "Beginning Web Development using ASP.NET MVC",
                                                          Url = @"http://www.adilmughal.com/2013/01/beginning-web-development-using-aspnet-mvc.html",
                                                          SlidesUrl = @"http://www.slideshare.net/adil.mughal/web-development-using-aspnet-mvc",
                                                          CreatedDate = System.DateTime.UtcNow
                                                      },
                                                  new TechnicalContent
                                                      {
                                                          Title = "Refactoring to SOLID Code",
                                                          Url =
                                                              @"http://edotnetdevs.wordpress.com/2011/10/30/event-summary-oct-ug-meeting-on-design-principles-and-practices/",
                                                          SlidesUrl = @"http://www.slideshare.net/adil.mughal/refactoring-to-solid-code",
                                                          DemoCodeUrl = @"https://www.box.com/shared/umg9df76k6b1s2jtfr7j",
                                                          CreatedDate = System.DateTime.UtcNow
                                                      },
                                                  new TechnicalContent
                                                      {
                                                          Title = "What's New in Visual Studio 2010",
                                                          Url =
                                                              @"http://edotnetdevs.wordpress.com/2010/12/04/event-summary-visual-studio-2010-ultimate-loadfest/",
                                                          SlidesUrl = @"http://www.slideshare.net/adil.mughal/whats-new-in-visual-studio-2010-6034750",
                                                          CreatedDate = System.DateTime.UtcNow
                                                      });
            base.Seed(context);
        }
    }
}