using ClassWorkTemplate.DataContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassWorkTemplate.DataContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Epizod> Epizods { get; set; }
        public List<Profession> Professions { get; set; }
        public DbSet<SpeakerProfession> SpeakerProfessions { get; set; }

    }
}
