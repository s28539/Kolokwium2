using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class items
{
    [Key] 
    public int Id { get; set; }

    [MaxLength(100)] 
    public string Name { get; set; }

    public int Weight { get; set; }
    public ICollection<backpacks> backpacks { get; set; } = new HashSet<backpacks>();
}