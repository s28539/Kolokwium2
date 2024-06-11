using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class titles
{
    [Key] 
    public int Id { get; set; }

    [MaxLength(100)] 
    public string Name { get; set; }

    public ICollection<characters_titles> character_titles { get; set; } = new HashSet<characters_titles>();
}