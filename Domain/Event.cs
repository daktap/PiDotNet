using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }
        public String EventPlace { get; set; }
        public String EventTitle { get; set; }
        public String EventDesc { get; set; }
        public String EventAffiche { get; set; }


        [ForeignKey("usr")]
        public String cin { get; set; }

        public virtual user usr { get; set; }




    }
}
