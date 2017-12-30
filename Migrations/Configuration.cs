namespace TicketingSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TicketingSystem.Models;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.SqlClient;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        //private UserManager<User> userManager;

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {  //not working ! why ?
            //nu gdaan door seedUsers.cs
            //this.ueserManager = new UserManager<User>(new UserStore<User>(context));
            //roles
            //context.Roles.AddOrUpdate(x=>x.Name,new IdentityRole("Admin") );
            //context.SaveChanges();
            //user, werk dus nie.
            //var firstUser = new User { Email="test@mail.com",UserName="Test User"};
            //this.userManager.Create(firstUser,"Test4test.");  //is not created here
            //this.userManager.AddToRole(firstUser.Id,"Admin"); //error on this line


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
