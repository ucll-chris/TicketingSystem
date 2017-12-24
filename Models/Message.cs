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
        [ForeignKey("TicketId")]
        public virtual Ticket Ticket { get; set; }
        public int TicketId { get; set; }

        //[Required]
        //ForeignKey("UserId")]
        //public virtual User User { get; set; }
        //public int UserId { get; set; }
 
        [Required]
        public String Text { get; set; }
   
        [Required]
        public DateTime Datum {get; set;}
    }
}