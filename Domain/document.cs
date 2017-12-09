using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class document
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public Nullable<System.DateTime> Entry_Date { get; set; }
        public string Footer { get; set; }
        public string Titre1 { get; set; }
        public string Titre2 { get; set; }
        public string Type { get; set; }
        public byte[] picture { get; set; }
    }
}
