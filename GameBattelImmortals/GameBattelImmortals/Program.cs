using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class Program
    {
        //public event Delegate create;

        private static UiManager uiManager = null;
        private static ItemManager itemManager = null;
        public static CharacterManager characterManager = null;
        public static ListUiManager listUiManagers = null;
        public static ListItemManager listItemManager = null;
        public static void Main(string[] args)
        {
            uiManager = new UiManager();
            itemManager = new ItemManager();
            characterManager = new CharacterManager();
            listUiManagers = new ListUiManager();
            listItemManager = new ListItemManager();
            StartGame();
            Console.ReadKey();
        }
        public static void StartGame()
        {
            Console.Clear();
            uiManager.ShowMenu();
            uiManager.Select()?.Invoke();
        }
    }
}
