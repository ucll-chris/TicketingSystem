using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public int Urgency { get; set; }
        public bool Finished { get; set; }
        //public int User_id { get; set; }
        public User User { get; set; }
        //public int Assigned_to { get; set; }
        public User  Assigend_to{ get; set; }
}
}