namespace ClassWorkTemplate.DataContext.Entities
{
    public class Speaker:BaseEntity
    {
        public string Name { get; set; } = null!;
        public string ProfileImagePath { get; set; } = null!;
        public List<SpeakerProfession> Professions { get; set; } = [];
        public List<Epizod> Epizods { get; set; } = [];
    }
}
