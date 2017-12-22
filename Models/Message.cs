using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    public class Message
    {
        public int Id { get; set; }
        //public int Ticket_id { get; set; }
        public Ticket Ticket { get; set; }
        //public int User_id { get; set; }
        public User User { get; set; }
        public String Text { get; set; }
        public DateTime Datum {get; set;}
    }
}