using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class UiManager
    {
        public void ShowMenu()
        {
            Console.WriteLine("====IMMORTAL FIGHT====");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.Create Character");
            Console.WriteLine("2.Character Information");
            Console.WriteLine("3.Create Item");
            Console.WriteLine("4.Item Information");
            Console.WriteLine("5.Upgrade Item Level");
            Console.WriteLine("6.Merge Item");
        }
        public Action Select()
        {
            int key = int.Parse(Console.ReadLine())-1;
            while(key <0 || key > 5 )
            {
                Console.Clear();
                Program.StartGame();
            }
            return Program.listUiManagers.listUiManager[key];
        }
        //public Action Select2()
        //{
        //    int key = int.Parse(Console.ReadLine()) - 1;
        //    return Program.listItemManager.listItemManager[key]; 
        //}
    }
} 

