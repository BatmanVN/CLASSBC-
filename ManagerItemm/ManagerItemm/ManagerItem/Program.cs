using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerItem
{
    //public delegate void MergerItem(int index1, int index2);
    //public delegate void UpgradeLevel(int level);
    //public delegate void Gacha(List<Item>inventory);


    public class Program
    {
        private static UIManager uiManager = null;
        private static ItemManeger itemManeger = null;

        static void Main(string[] args)
        {
            uiManager = new UIManager();
            itemManeger = new ItemManeger();

            while (true)
            {
                UIManager.Choice();
            }
        }

        public static void StartGame()
        {

        }
    }
}
