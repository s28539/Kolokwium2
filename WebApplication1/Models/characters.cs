using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class characters
{
    [Key] 
    public int Id { get; set; }

    [MaxLength(50)] 
    public string FirstName { get; set; }
    [MaxLength(120)] 
    public string LastName { get; set; }

    public int CurrentWeight { get; set; }

    public int MaxWeight { get; set; }
    public ICollection<characters_titles> character_titles { get; set; } = new HashSet<characters_titles>();
    public ICollection<backpacks> Backpacks { get; set; } = new HashSet<backpacks>();

}