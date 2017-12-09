using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class reclamationMap : EntityTypeConfiguration<reclamation>
    {
        public reclamationMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.message)
                .HasMaxLength(255);

            this.Property(t => t.statuts)
                .HasMaxLength(255);

            this.Property(t => t.subject)
                .HasMaxLength(255);

            this.Property(t => t.usr_cin)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("reclamation", "ged");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.dateSol).HasColumnName("dateSol");
            this.Property(t => t.dateTrait).HasColumnName("dateTrait");
            this.Property(t => t.message).HasColumnName("message");
            this.Property(t => t.reclamDate).HasColumnName("reclamDate");
            this.Property(t => t.statuts).HasColumnName("statuts");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.usr_cin).HasColumnName("usr_cin");
        }
    }
}
