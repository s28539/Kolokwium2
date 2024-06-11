using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using WebApplication1.DTO_s;
using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IDbService
{
    public Task<characters> GetCharactersDetail(int characterID);
    public Task<ICollection<backpacks>> AddBackpack(List<AddBackpackDTO> backpackDto);
    public Task<bool> allBackpacksAreInDatabase(List<AddBackpackDTO> backpackDtos);
    


}