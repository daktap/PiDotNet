using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;

namespace Data.Models
{
    public partial class gedContext : DbContext
    {
        static gedContext()
        {
            Database.SetInitializer<gedContext>(null);
        }

        public gedContext()
            : base("Name=gedContext")
        {
        }

        public DbSet<archive> archives { get; set; }
        public DbSet<document> documents { get; set; }
        public DbSet<document1> documents1 { get; set; }
        public DbSet<folder> folders { get; set; }
        public DbSet<reclamation> reclamations { get; set; }
        public DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new archiveMap());
            modelBuilder.Configurations.Add(new documentMap());
            modelBuilder.Configurations.Add(new document1Map());
            modelBuilder.Configurations.Add(new folderMap());
            modelBuilder.Configurations.Add(new reclamationMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}
