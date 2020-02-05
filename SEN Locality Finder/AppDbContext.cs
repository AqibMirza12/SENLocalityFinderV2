using Microsoft.EntityFrameworkCore;
using SEN_Locality_Finder.Models;

namespace SEN_Locality_Finder
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
        : base(options)
        {
        }

        public AppDbContext()
        {
            
        }

        public DbSet<Academy> Academies { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<Nursery> Nurseries { get; set; }
        public DbSet<Primary_School> Primary_Schools { get; set; }
        public DbSet<Secondary_School> Secondary_Schools { get; set; }
        public DbSet<PRU> PRU { get; set; }
        public DbSet<Special_School> Special_Schools { get; set; }
        public DbSet<SEN_Condition> SEN_Conditions { get; set; }

        

        //property declaration with getter and setter
        //public DbSet<Institution> Colleges { get; set; } //property declaration with getter and setter
        //public DbSet<Institution> Nurseries { get; set; } //property declaration with getter and setter
        //public DbSet<Institution> Primary_Schools { get; set; } //property declaration with getter and setter
        //public DbSet<Institution> Secondary_Schools { get; set; } //property declaration with getter and setter
        //public DbSet<Institution> Special_Schools { get; set; } //property declaration with getter and setter
        //public DbSet<Institution> PRU { get; set; } //property declaration with getter and setter
        //public DbSet<Institution> SEN_Conditions { get; set; } //property declaration with getter and setter

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-M02R3MPS\\SQLBACKUP; Database = FYPDB; Trusted_Connection = True");
        }
    }
}