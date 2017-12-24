using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    public class TicketsContext : DbContext
    {
        public DbSet<Ticket> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Why O why !!!!!!

            //to prevent error:
            //Introducing FOREIGN KEY constraint 'FK_dbo.Tickets_dbo.Users_Assigned_to_id' on table 'Tickets' may cause cycles or multiple cascade paths.Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
            //Could not create constraint or index. See previous errors.
            modelBuilder.Entity<Ticket>()
                    .HasRequired(s => s.User)
                    .WithMany()
                    .HasForeignKey(n => n.UserId)
                    .WillCascadeOnDelete(false);

           modelBuilder.Entity<Ticket>()
                    .HasRequired(s => s.AssigendTo)
                    .WithMany()
                    .HasForeignKey(n => n.AssignedToId)
                    .WillCascadeOnDelete(false);

            //probleem zat dus nie in Ticket,maar in messages
            //ik snap het niet
            /*modelBuilder.Entity<Message>()
                    .HasRequired(s => s.User)
                    .WithMany()
                    .HasForeignKey(n => n.UserId)
                    .WillCascadeOnDelete(false);
            */
            base.OnModelCreating(modelBuilder);
        }
    }
}