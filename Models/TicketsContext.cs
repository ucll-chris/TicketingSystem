using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    public class TicketsContext : IdentityDbContext<User>
    {
        //public virtual IDbSet<ApplicationUser> Users { get; set; } //al in IdentityDbContext
        public virtual IDbSet<Ticket> Tickets { get; set; }
        public virtual IDbSet<Message> Messages { get; set; }

        public TicketsContext() : base("DefaultConnection", throwIfV1Schema: false)
        { }

        public static TicketsContext Create()
        {
            return new TicketsContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Ticket>()
                    .HasRequired(s => s.User)
                    .WithMany()
                    .WillCascadeOnDelete(false);
 

            base.OnModelCreating(modelBuilder);
        }
    }
}
 