using starwars.Domain;

namespace Starwars.WebApi.Models.Out;
public class CharacterBasicInfo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public CharacterBasicInfo(Character character)
    {
        Id = character.Id;
        Name = character.Name;
        Description = character.Description;
    }
}
