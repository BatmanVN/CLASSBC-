using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class ListUiManager
    {
        public List<Action> listUiManager = null;
        public Character character = null;

        public ListUiManager()
        {
            //if (Program.characterManager.CharacterList == null)
            //{
            //    //Program.characterManager.CharacterList = new List<Character>();
            //    character = Program.characterManager.CharacterList[0];
            //}
            character = new Character();
            listUiManager = new List<Action>(6)
                {
                    CreateCharacter,
                    ShowAllICharacters,
                    () => {CharacterInformation(character); }
                };
        }
        public void CreateCharacter()
        {
            Console.Clear();
            DelegateEvent.createCharacter();
            Console.ReadKey();
        }
        public void ShowAllICharacters()
        {

        }
        public void CharacterInformation(Character character)
        {
            Console.Clear();
            DelegateEvent.showInfomationCharacter(character);
            Console.ReadKey();
        }
        public void CreateItem()
        {
            Console.Clear();
            Console.WriteLine("3");
            Console.ReadKey();
        }
        public void ShowItem()
        {
            Console.Clear();
            Console.WriteLine("4");
            Console.ReadKey();
        }
        public void UpgradeLv()
        {
            Console.Clear();
            Console.WriteLine("5");
            Console.ReadKey();
        }
        public void MergerItem()
        {
            Console.Clear();
            Console.WriteLine("6");
            Console.ReadKey();
        }

    }
}
