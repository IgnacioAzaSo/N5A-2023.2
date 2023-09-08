using System.Collections.Generic;
using Moq;
using starwars.DataAccess;
using starwars.Exceptions;
using starwars.IDataAccess;
using static System.Net.Mime.MediaTypeNames;

// USAR MSTEST, no Xunit o Nunit
namespace starwars.BusinessLogic.Tests;

[TestClass]
public class CharacterTest
{
    // DA1 -> Problema: Queremos testear CharacterService pero necesita de CharacterManagment
    // Al instanciar CharacterManagment y usarlo estamos testeandolo indirectamente también
    // Por ende, NO es un test unitario, sino de integración

    // [TestMethod]
    // public void InsertCharacterOk()
    // {
    //     // Arrange -> Setup del contexto
    //     var character = new Character()
    //     {
    //         Id = 1,
    //         Description = "Test",
    //         Name = "Darth Nico",
    //         ImageUrl = ""
    //     };
    //     var charactersManagement = new CharacterManagment(); -> ACA esta el problema, tmb testeo esta clase al instanciarla y usarla
    //     var service = new CharacterService(charactersManagement);
    //
    //     //Act
    //     service.InsertCharacter(character);
    //
    //     //Assert
    //     Assert.IsTrue(true);
    // }


    // DA2 -> Queremos hacer tests unitarios

    [TestInitialize]
    public void InitTest()
    {
        // TODO: Mejorar usando TestInitialize
    }

    // [TestMethod]
    // public void GetAllCharactersOk()
    // {
    //     // Arrange
    //     var character = new Character()
    //     {
    //         Id = 1,
    //         Description = "Test",
    //         Name = "Darth Nico",
    //         ImageUrl = ""
    //     };
    //     var characters = new List<Character>() { character };
    //
    //     var characterManagerMock = new Mock<ICharacterManagment>(MockBehavior.Strict);
    //     var service = new CharacterService(characterManagerMock.Object);
    //
    //     // Setup del mock
    //     characterManagerMock.Setup(m => m.GetCharacters()).Returns(characters);
    //
    //     var result = service.GetCharacters();
    //     CollectionAssert.AreEqual(result.ToList(), characters);
    //
    //     // Verifica que todo lo que hice setup se haya llamado
    //     characterManagerMock.VerifyAll();
    // }

    // [TestMethod]
    // public void GetAllCharatersException()
    // {
    //     var characterManagerMock = new Mock<ICharacterManagment>(MockBehavior.Strict);
    //     var service = new CharacterService(characterManagerMock.Object);
    //
    //     // Setup del mock
    //     characterManagerMock.Setup(m => m.GetCharacters()).Throws(new Exception("hola"));
    //
    //     var result = service.GetCharacters();
    //     Assert.IsTrue(result.ToList().Count == 0);
    //
    //     // Verifica que todo lo que hice setup se haya llamado
    //     characterManagerMock.VerifyAll();
    // }

    // [TestMethod]
    // public void AnotherTest()
    // {
    //     var character = new Character()
    //     {
    //         Id = 1,
    //         Description = "Test",
    //         Name = "Darth Nico",
    //         ImageUrl = ""
    //     };
    //
    //     var mock = new Mock<ICharacterManagment>(MockBehavior.Strict);
    //     var service = new CharacterService(mock.Object);
    //     
    //     mock.Setup(m => m.GetCharacterById(It.IsAny<int>())).Returns(character);
    //
    //     var result = service.GetCharacterById(812);
    //     Assert.AreEqual(character, result);
    //
    //     // Verifica que todo lo que hice setup se haya llamado
    //     mock.VerifyAll();
    // }
}