using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    internal class Program
    {
        public static ListUiManager listUiManager = null;
        public static CharacterManager characterManager = null;
        public static ItemManager itemManager = null;
        public static UserManager userManager = null;
        public static UiManager uiManager = null;
        static void Main(string[] args)
        {
            listUiManager = new ListUiManager();
            characterManager = new CharacterManager();
            itemManager = new ItemManager();
            userManager = new UserManager();
            uiManager = new UiManager();
            listUiManager.AccountUi();
            Start();
            Console.ReadKey();
        }
        public static void Start()
        {
            Console.Clear();
            uiManager.UiManagers()?.Invoke();
        }
    }
}
