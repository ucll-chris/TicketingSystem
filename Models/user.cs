using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    public class User : IdentityUser //exetend db.AspNetUser ?
    {
        public virtual ICollection<Ticket> TicketsCreated { get; set; }
        public virtual ICollection<Message> Messages { get; set; }

        //public String F_name { get; set; }
        //[Required]
        //public String L_name { get; set; }
    }
}