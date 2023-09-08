using starwars.Domain;

namespace Starwars.WebApi.Models.In;
public class CharacterModel
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Character ToEntity()
    {
        return new Character()
        {
            Name = Name,
            Description = Description
        };
    }
}
