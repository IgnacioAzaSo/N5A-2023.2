using System;
using starwars.Domain;
using starwars.Domain.Enums;
using starwars.IBusinessLogic;
using starwars.IDataAccess;

namespace starwars.BusinessLogic
{
    public class CharacterService : ICharacterService
    {
        public void DeleteCharacter(int id)
        {
            return;
        }

        public Character GetCharacterById(int id)
        {
            return new Character();
        }

        public IEnumerable<Character> GetCharacters()
        {
            return new List<Character>();
        }

        public void InsertCharacter(Character? character)
        {
            return;
        }

        public Character? UpdateCharacter(Character? character)
        {
            return null;
        }
    }
}

