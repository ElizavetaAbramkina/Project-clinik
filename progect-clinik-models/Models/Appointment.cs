using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progect_clinik_models.Models
{
    public class Appointment : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public virtual AppointmentAddress AppointmentAddress { get; set; } = null!;
        public virtual Doctor Doctor { get; set; } = null!;
        public virtual Patient Patient { get; set; } = null!;
        public virtual Consultation? Consultation { get; set; } 
    }
}
