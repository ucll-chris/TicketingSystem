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
        [ForeignKey("User_id")]
        public virtual User User { get; set; }
        public int User_id { get; set; }
        
        [ForeignKey("Assigned_to_id")]
        public virtual User Assigend_to{ get; set; }
        public int Assigned_to_id { get; set; }
    }
}