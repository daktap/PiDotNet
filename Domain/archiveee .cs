using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class archive
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date_archive { get; set; }
        public string version { get; set; }
        public Nullable<int> document_fk { get; set; }
        public Nullable<int> folder_fk { get; set; }
    }
}
