using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Migrations;

namespace TicketingSystem.Models
{
    public class TicketsInitializer : DbMigrationsConfiguration<TicketsContext>
    {
        private UserManager<User> userManager;

        protected override void Seed(TicketsContext context)
        {
            //default db settings here
            this.userManager = new UserManager<User>(new UserStore<User>(context));

            var PasswordHash = new PasswordHasher();

            User firstUser = new User() {
                Email = "test@mail.com"
                //PasswordHash = PasswordHash.HashPassword("Test4test.")
            };

            //toevoegen
            this.userManager.Create(firstUser, "Test4test.");
            this.userManager.AddToRole(firstUser.Id,"Admin");
            
            base.Seed(context);
        }
    }
}