using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicketingSystem.Models
{
    public class Message
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Ticket_id")]
        public virtual Ticket Ticket { get; set; }
        public int Ticket_id { get; set; }

        [Required]
        [ForeignKey("User_id")]
        public virtual User User { get; set; }
        public int User_id { get; set; }
    
        [Required]
        public String Text { get; set; }
   
        [Required]
        public DateTime Datum {get; set;}
    }
}