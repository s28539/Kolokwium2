using Microsoft.EntityFrameworkCore;
using WebApplication1.DTO_s;
using WebApplication1.Models;

namespace WebApplication1.Services;

public class DbService : IDbService
{
    private readonly ApplicationContext _context;
    public DbService(ApplicationContext context)
    {
        _context = context;
    }
    public async Task<characters> GetCharactersDetail(int characterID)
    {
        return await _context.Characters
            .Include(b => b.Backpacks)
            .ThenInclude(b => b.item)
            .Include(b => b.character_titles)
            .ThenInclude(b => b.title)
            .Where(b => b.Id == characterID)
            .FirstAsync();
    }

    public Task<ICollection<backpacks>> AddBackpack(List<AddBackpackDTO> backpackDto)
    {
        return null;
    }

    public async Task<bool> allBackpacksAreInDatabase(List<AddBackpackDTO> backpackDtos)
    {
        bool  allExists = true;
        foreach (var backpack in backpackDtos)
        {
            if ( ! await  _context.Backpacks.AnyAsync(b => b.ItemId == backpack.itemId))
            {
                allExists = false;
            }
        }

        return  allExists;
    }
    
}