namespace progect_clinik_models.Models
{
    public class Consultation : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Complaints { get; set; }
        public string Anamnesis { get; set; }
        public string TreatmentPrescriptions { get; set; }

        public virtual AppointmentAddress AppointmentAddress { get; set; } = null!;
        public virtual Diagnosis Diagnosis { get; set; } = null!;
        public virtual Analysis? Analysis { get; set; }
        public virtual Doctor Doctor { get; set; } = null!;
        public virtual Department Department { get; set; } = null!;
        public virtual Patient? Patient { get; set; } 
    }
}
