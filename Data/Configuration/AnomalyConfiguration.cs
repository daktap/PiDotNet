using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class AnomalyConfiguration:EntityTypeConfiguration<Anomaly>
    {
        public AnomalyConfiguration() {
                    HasOptional(e => e.DocumentFact).WithMany(e => e.Anomalies).HasForeignKey(e => e.DocId).WillCascadeOnDelete(false);
        }
    }
}
