namespace ClassWorkTemplate.DataContext.Entities
{
    public class Epizod:BaseEntity
    {
        public string? Titile { get; set; }
        public int SpeakerId { get; set; }
        public Speaker? Speaker { get; set; }
        public int TopicId { get; set; }
        public Topic? Topic { get; set; }
        public string? CoverImagePath { get; set; }
        public string? Mp3FilePath { get; set; }
        public int DurationMinutes { get; set; }
        public int ListeningMinutes { get; set; }
        public int DownloadCount { get; set; }
        public int LikeCount { get; set; }
    }
}
