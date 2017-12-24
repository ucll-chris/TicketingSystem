using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    //Replace it by db.AspNetUser ?
    public class User
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String F_name { get; set; }
        [Required]
        public String L_name { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public User_rights User_rights { get; set; }

        public virtual List<Ticket> Tickets { get; set; }
        //public virtual List<Message> Messages { get; set; }
    }
}