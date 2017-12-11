using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Anomaly
    {
        [Key]
        public int AnomalyID { get; set; }
        public string TitleAnomaly { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateAnomaly { get; set; }
        public string DescAnomaly { get; set; }
        [ForeignKey("DocumentFact")]
        public int DocId { get; set; }
        public document DocumentFact { get; set; }



    }
}
