namespace progect_clinik_models.Models
{
    public class Diagnosis : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
