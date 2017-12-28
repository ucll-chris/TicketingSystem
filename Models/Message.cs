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

        //[Required] //echt ?? required is de rede ????
        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }
        public string CreatorId { get; set; }
        //gaat nie, want Introducing FOREIGN KEY constraint 'FK_dbo.Tickets_dbo.Users_UserId' on table 'Tickets' may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
        //Could not create constraint or index.See previous errors. 

        [Required]
        public String Text { get; set; }
   
        [Required]
        public DateTime Datum {get; set;}
    }
}