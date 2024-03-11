using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void CreateItems(int count);

    public delegate void UpgradItem(int index);

    public delegate void MergeItems(int index1, int index2);

    

    public class Program
    {
        public static CreateItems GachaDelegate;
        public static UpgradItem UpgradeItemDelegate;
        public static MergeItems MergeItemsDelegate;

        private static ItemsManager itemsManager = null;
        private static UIManager uiManager = null;

        static void Main(string[] args)
        {
            itemsManager = new ItemsManager();
            uiManager = new UIManager();

            StartGame();

            Console.ReadKey();
        }

        public static void StartGame()
        {
            int input = uiManager.MainMenu();

            if (input == 1)
            {
                uiManager.Gacha();
            }
            else if (input == 2)
            {
                uiManager.ShowItems(itemsManager.items);
            }
        }
    }
}
