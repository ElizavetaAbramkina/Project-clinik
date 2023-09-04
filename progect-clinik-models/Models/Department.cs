namespace progect_clinik_models.Models
{
    public class Department : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Doctor> Doctors { get; set; } = null!;
    }
}