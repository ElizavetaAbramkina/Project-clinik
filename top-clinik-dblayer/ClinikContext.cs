using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using progect_clinik_models;
using progect_clinik_models.Models;

namespace top_clinik_dblayer
{
    public class ClinikContext : DbContext
    {
        public DbSet<Analysis> Аnalyzes { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentAddress> Appointment_Address { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Species_enimals> Species_Enimals { get; set; }

        private const string confingPath = "Db_config.json";
        private const string connectionStringKey = "Clinik_ConnectionString";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!File.Exists(confingPath))
                throw new Exception($"There is no file for \"{confingPath}\" path!");
            var json = JObject.Parse(File.ReadAllText(confingPath));

            if (!json.ContainsKey(connectionStringKey))
                throw new Exception($"Inconsistent {confingPath} file!");

            optionsBuilder
                .UseSqlServer((string?)json[connectionStringKey])
                .UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in ModelController.GetModelTypes())
                modelBuilder.Entity(entityType).Property(nameof(IEntity.Id)).HasDefaultValue("NEWSEQUENTIALID()");

            modelBuilder.Entity<Patient>().HasMany(x => x.Consultations).WithOne(x => x.Patient).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Consultation>().HasOne(x => x.Doctor).WithMany(x => x.Consultations).OnDelete(DeleteBehavior.SetNull).OnDelete(DeleteBehavior.ClientSetNull) ;
        }
    }
}