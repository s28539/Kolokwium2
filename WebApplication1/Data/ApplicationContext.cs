using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1;

public class ApplicationContext : DbContext
{
    protected ApplicationContext()
    {
    }

    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<backpacks> Backpacks { get; set; }
    public DbSet<characters> Characters { get; set; }
    public DbSet<characters_titles> CharactersTitles { get; set; }
    public DbSet<items> Items { get; set; }
    public DbSet<titles> Titles { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<items>().HasData(new List<items>
        {
            new items {
                Id = 1,
                Name = "Bidon",
                Weight = 2
            }
        });
        modelBuilder.Entity<backpacks>().HasData(new List<backpacks>
        {
            new backpacks {
                CharacterId = 1,
                ItemId = 1,
                Amount = 2
            }
        });
        modelBuilder.Entity<characters>().HasData(new List<characters>
        {
            new characters {
                Id = 1,
                FirstName = "Mariusz",
                LastName = "Kowalski",
                CurrentWeight = 20,
                MaxWeight = 30
            }
        });
        
        modelBuilder.Entity<characters_titles>().HasData(new List<characters_titles>
        {
            new characters_titles {
                CharacterId = 1,
                TitleId = 1,
                AcquriedAt = DateTime.Parse("2024-05-31")
            }
        });
        
        modelBuilder.Entity<titles>().HasData(new List<titles>
        {
            new titles {
                Id = 1,
                Name = "example1"

            }
        });
        
    }
}