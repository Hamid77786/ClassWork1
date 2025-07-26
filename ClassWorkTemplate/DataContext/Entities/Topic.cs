namespace ClassWorkTemplate.DataContext.Entities
{
    public class Topic:BaseEntity
    {
        public string? Name { get; set; }
        public List<Epizod>? Epizods { get; set; }
    }
}
