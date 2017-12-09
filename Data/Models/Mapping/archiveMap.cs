using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class archiveMap : EntityTypeConfiguration<archive>
    {
        public archiveMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.version)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("archive", "ged");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Date_archive).HasColumnName("Date_archive");
            this.Property(t => t.version).HasColumnName("version");
            this.Property(t => t.document_fk).HasColumnName("document_fk");
            this.Property(t => t.folder_fk).HasColumnName("folder_fk");
        }
    }
}
