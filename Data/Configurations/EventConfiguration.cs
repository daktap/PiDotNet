using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class EventConfiguration:EntityTypeConfiguration<Event>
    {
        public EventConfiguration()
        {
            HasOptional(e => e.usr).WithMany(e => e.events).HasForeignKey(e => e.cin).WillCascadeOnDelete(false);
        }
    }
}
