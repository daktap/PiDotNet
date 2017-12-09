using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class document1Map : EntityTypeConfiguration<document1>
    {
        public document1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Body)
                .HasMaxLength(2000);

            this.Property(t => t.Footer)
                .HasMaxLength(255);

            this.Property(t => t.Titre1)
                .HasMaxLength(255);

            this.Property(t => t.Titre2)
                .HasMaxLength(255);

            this.Property(t => t.Type)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("documents", "ged");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Body).HasColumnName("Body");
            this.Property(t => t.Entry_Date).HasColumnName("Entry_Date");
            this.Property(t => t.Footer).HasColumnName("Footer");
            this.Property(t => t.Titre1).HasColumnName("Titre1");
            this.Property(t => t.Titre2).HasColumnName("Titre2");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.picture).HasColumnName("picture");
        }
    }
}
