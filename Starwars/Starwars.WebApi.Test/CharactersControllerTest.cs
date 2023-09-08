using Moq;
using starwars.IBusinessLogic;
using starwars.Domain;
using Starwars.WebApi.Models.Out;
using Starwars.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Starwars.WebApi.Test;

[TestClass]
public class CharactersControllerTest
{
    private Mock<ICharacterService> _serviceMock;

    [TestInitialize]
    public void Setup()
    {
        _serviceMock = new Mock<ICharacterService>(MockBehavior.Strict);
    }

    // Testeen solo casos felices :) los casos que fallan lo vamos a extraer mas adelante en filters
    [TestMethod]
    public void TestGetAllOk()
    {
        //Arrange
        List<Character> serviceCharacters = new List<Character>();
        List<CharacterBasicInfo> expectedCharacters = serviceCharacters.Select(c => new CharacterBasicInfo(c)).ToList();
        _serviceMock.Setup(s => s.GetCharacters()).Returns(serviceCharacters);

        CharactersController controller = new CharactersController(_serviceMock.Object);
        
        // Act
        var result = controller.GetAll(); // IActionResult
        var parsedResult = result as OkObjectResult;
        var body = parsedResult.Value as IEnumerable<CharacterBasicInfo>;

        // Assert
        CollectionAssert.AreEqual(expectedCharacters, body.ToList());
        // Checkear que todos los metodos que setupeamos fueron llamados
        _serviceMock.VerifyAll();
    }
}