using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public DateTime Start_date { get; set; }

        public DateTime End_date { get; set; }

        [Required]
        public int Urgency { get; set; }

        public bool Finished { get; set; }

        [Required]
        //[ForeignKey("User_id")] //we gaan fluent API gebruiken -> ticketContext
        public virtual User User { get; set; }
        public int UserId { get; set; }
 
        //[ForeignKey("Assigned_to_id")]
        public virtual User AssigendTo{ get; set; }
        public int? AssignedToId { get; set; }

        //voor messsages in
        public virtual List<Message> Messages { get; set; }
    }
}