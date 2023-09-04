using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progect_clinik_models.Models
{
    public class Patient : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }
        [Required] public string Name { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        public virtual Species_enimals SpeciesEnimals { get; set; } = null!;
        public virtual ICollection<Analysis> Analyses { get; set; } = null!;
        public virtual ICollection<Appointment> Appointments { get; set; } = null!;
        public virtual ICollection<Consultation> Consultations { get; set; } = null!;
    }
}
