using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public String F_name { get; set; }
        public String L_name { get; set; }
        public String Email { get; set; }
        public User_rights User_rights { get; set; }
}
}