using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class reclamation
    {
        public int id { get; set; }
        public Nullable<System.DateTime> dateSol { get; set; }
        public Nullable<System.DateTime> dateTrait { get; set; }
        public string message { get; set; }
        public Nullable<System.DateTime> reclamDate { get; set; }
        public string statuts { get; set; }
        public string subject { get; set; }
        public string usr_cin { get; set; }
    }
}
