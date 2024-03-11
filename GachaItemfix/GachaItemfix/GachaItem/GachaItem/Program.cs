using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaItem
{
    //tao 1 class rieng quan ly delegate va events
    //trong class do se define cac delegate va event
    //nhung delegate co cung hanh vi vao 1 event de quan ly
    public delegate void CreatItem();
    public delegate void UpgradeLV(int index, Character character);
    public delegate void MergerItem(int index1, int index2, Character character);
    public delegate void CreatCharacter();
    public delegate void EquiqItem(int index, List<Item> items, Character character);
    public delegate void UnequipMent(int index, List<Item> items, Character character);
    public delegate bool FullSlot(Character character);
    public delegate int ShowMenu();
    public delegate void DeleteItem(int index);
    public delegate void DeleteCharacter(int index);
    public class Program
    {
        public static CreatItem gacha;
        public static UpgradeLV upgradeLV;
        public static MergerItem mergerItem;
        public static ShowMenu showmenu;
        public static EquiqItem equiqItem;
        public static UnequipMent unequiqItem;
        public static CreatCharacter character;
        public static DeleteItem deleteitem;
        public static FullSlot fullSlot;

        private static UIManager uiManager = null;
        private static ItemManager itemManager = null;
        private static CharacterManager characterManager = null;
        static void Main(string[] args)
        {
            uiManager = new UIManager();
            itemManager = new ItemManager();
            characterManager = new CharacterManager();
            StartGame();
            Console.ReadKey();
        }
        public static void StartGame()
        {
            int input = uiManager.ShowMenu();
            switch (input)
            {
                case 1:
                    uiManager.CreatHero();
                    Console.ReadKey();
                    break;
                case 2:
                    uiManager.ShowInfoHero(characterManager.character);
                    Console.ReadKey();
                    break;
                case 3:
                    uiManager.Roll();
                    Console.ReadKey();
                    break;
                case 4:
                    uiManager.ShowAllItem(itemManager.items,characterManager.character);
                    Console.ReadKey();
                    break;
                case 5:
                    uiManager.UpLevel(itemManager.items,characterManager.character);
                    Console.ReadKey();
                    break;
                case 6:
                    uiManager.UpRarity(itemManager.items,characterManager.character);
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}
