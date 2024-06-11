using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO_s;
using WebApplication1.Services;

namespace WebApplication1.Contrlollers;
[Route("api/[controller]")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly IDbService _dbService;
    public CharactersController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{characterId}")]
    public async Task<IActionResult> GetCharacterData(int CharacterID)
    {
        var character = await _dbService.GetCharactersDetail(CharacterID);

        return  Ok(new GetInformationDTO()
        {
            firstName = character.FirstName,
            lastName = character.LastName,
            currentWeight = character.CurrentWeight,
            maxWeight = character.MaxWeight,
            backpacksItems = character.Backpacks.Select(p=>new GetBackPackDTO
            {
                itemName = p.item.Name,
                itemWeight = p.item.Weight,
                amount = p.Amount
            }).ToList(),
            titles = character.character_titles.Select(p=>new GetTitleDTO
            {
                title = p.title.Name,
                aquierdAt = p.AcquriedAt,
            }).ToList()
        });
    }
    //[HttpPost("{characterID}/backpacks")]
    
    
}