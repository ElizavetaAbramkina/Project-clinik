namespace progect_clinik_models.Models
{
    public class Analysis : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; set; }
        [Required] public string Name { get; set; } = null!;
        public string Results { get; set; } = null!;
        public AnalysisType Type { get; set; }

        public virtual Patient? Patient { get; set; }
    }
}
