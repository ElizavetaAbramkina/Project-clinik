namespace progect_clinik_models.Models
{
    public class Doctor : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }
        [Required] public string Name { get; set; } = null!;
        [Required] [StringLength(20)] public string Email { get; set; } = null!;

        [JsonIgnore] public virtual ICollection<Department> Departments { get; set; } = null!;
        [JsonIgnore] public virtual ICollection<Consultation> Consultations { get; set; } = null!;

    }
}
