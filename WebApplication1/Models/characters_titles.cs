using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;


[Table("characters_titles")]
[PrimaryKey(nameof(CharacterId),nameof(TitleId))]

public class characters_titles
{
    public int CharacterId { get; set; }
    public int TitleId { get; set; }
    public DateTime AcquriedAt { get; set; }

    [ForeignKey(nameof(TitleId))]
    public titles title { get; set; } = null!;
    [ForeignKey(nameof(CharacterId))]
    public characters character { get; set; } = null!;
}