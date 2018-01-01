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
        public String Description { get; set; }

        [Required]
        public DateTime Start_date { get; set; }

        public DateTime End_date { get; set; }

        [Required]
        public Priority Urgency { get; set; }

        public bool Finished { get; set; }

        [Required]
        [ForeignKey("UserId")] //kunnen ook fluent API gebruiken -> ticketContext
        public virtual User User { get; set; }
        public string UserId { get; set; }

        [ForeignKey("AssignedToId")]
        public virtual User AssigendTo{ get; set; }
        public string AssignedToId { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}