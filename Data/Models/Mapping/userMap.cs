using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.cin);

            // Properties
            this.Property(t => t.cin)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.mail)
                .HasMaxLength(255);

            this.Property(t => t.nomUser)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.prenomUser)
                .HasMaxLength(255);

            this.Property(t => t.role)
                .HasMaxLength(255);

            this.Property(t => t.tel)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "ged");
            this.Property(t => t.cin).HasColumnName("cin");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.nomUser).HasColumnName("nomUser");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.prenomUser).HasColumnName("prenomUser");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.tel).HasColumnName("tel");
        }
    }
}
