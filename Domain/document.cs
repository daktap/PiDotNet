using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public partial class document
    {
        public int Id { get; set; }
        public string Body { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Entry_Date { get; set; }
        public string Footer { get; set; }
        public string Titre1 { get; set; }
        public string Titre2 { get; set; }
        public string Type { get; set; }
        public string picture { get; set; }
        public ICollection<Anomaly> Anomalies { get; set; }
    }
}
