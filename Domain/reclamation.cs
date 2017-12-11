using Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public partial class reclamation
    {
        

       
  

        public int id { get; set; }
       
        [JsonConverter(typeof(TimeConversion))]
        public Nullable<System.DateTime> dateSol { get; set; }
        
        [JsonConverter(typeof(TimeConversion))]
        public Nullable<System.DateTime> dateTrait { get; set; }
        public string message { get; set; }
        public string type { get; set; }
        [DataType(DataType.Date)]
        [JsonConverter(typeof(TimeConversion))]
        public Nullable<System.DateTime> reclamDate { get; set; }
        public string statuts { get; set; }
        public string subject { get; set; }
        public string usr_cin { get; set; }
    }
}
