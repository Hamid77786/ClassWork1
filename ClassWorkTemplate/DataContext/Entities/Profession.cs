namespace ClassWorkTemplate.DataContext.Entities
{
    public class Profession:BaseEntity
    {
        public string Name { get; set; } = null!;
        public List<SpeakerProfession> Professions { get; set; } = [];
    }
}
