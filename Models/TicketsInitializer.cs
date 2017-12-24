using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    public class TicketsInitializer : DropCreateDatabaseIfModelChanges<TicketsContext>
    {
        protected override void Seed(TicketsContext context)
        {
            //default db settings here

            base.Seed(context);
        }
    }
}