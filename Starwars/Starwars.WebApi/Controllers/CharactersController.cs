using Microsoft.AspNetCore.Mvc;
using starwars.Domain;
using Starwars.WebApi.Models.In;
using Starwars.WebApi.Models.Out;
using starwars.IBusinessLogic;

namespace Starwars.WebApi.Controllers;

// Data Annotations
[ApiController]
[Route("/api/characters")]
public class CharactersController : ControllerBase
{
    private static List<Character> _characters = new List<Character>() { new Character() { Id = 1, Name = "Yoda", Description = "description", ImageUrl = "image"} };
    private readonly ICharacterService _service;

    // Inyeccion de dependencias
    public CharactersController(ICharacterService service)
    {
        _service = service;
    }

    // GET api/characters -> index
    [HttpGet]
    public IActionResult GetAll()
    {
        var parsedCharacters = _service.GetCharacters().ToList().Select(c => new CharacterBasicInfo(c));
        return Ok(parsedCharacters);
    }

    // GET api/v1/characters/{id} -> show
    [HttpGet("{id}")]
    public IActionResult GetSpecific([FromRoute] int id)
    {
        var retrievedCharacter = _characters.Find(x => x.Id == id);

        if (retrievedCharacter == null)
        {
            return NotFound(new { Message = "Cant find character"});
        }
        else 
        {
            // TODO: Devolver model
            return Ok(retrievedCharacter);
        }
    }

    // POST api/v1/characters -> create
    [HttpPost]
    // Model binding, hasta pueden definir custom web-bindings 
    public IActionResult CreateCharacter([FromBody] CharacterModel character)
    {
        if(character.Name == "" || character.Description == "")
        {
            return BadRequest(new { Message = "Invalid character" });
        }
        else 
        {
            var parsedCharacter = character.ToEntity();

            parsedCharacter.Id = _characters.Count() + 1;
            _characters.Add(parsedCharacter);

            // TODO: CreatedResult() y devolver un modelo
            return Ok(parsedCharacter);
        }
    }

    // PUT/PATCH api/v1/characters/{id} -> update
    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] CharacterModel updatedCharacter)
    {
        // TODO
        return Ok();
    }

    // DELETE api/v1/characters/{id} -> delete
    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        // TODO
        return Ok();
    }

    // GET api/characters/{id}/friends
    [HttpGet("{id}/friends")]
    public IActionResult GetFriends([FromRoute] int id)
    {
        return Ok();
    }
}
