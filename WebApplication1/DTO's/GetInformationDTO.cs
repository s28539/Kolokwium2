namespace WebApplication1.DTO_s;

public class GetInformationDTO
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int currentWeight { get; set; }
    public int maxWeight { get; set; }
    public ICollection<GetBackPackDTO> backpacksItems { get; set; } = new List<GetBackPackDTO>();
    public ICollection<GetTitleDTO> titles { get; set; } = new List<GetTitleDTO>();
}

public class GetBackPackDTO
{
    public string itemName { get; set; }
    public int itemWeight { get; set; }
    public int amount { get; set; }
}

public class GetTitleDTO
{
    public string title { get; set; }
    public DateTime aquierdAt { get; set; }
}