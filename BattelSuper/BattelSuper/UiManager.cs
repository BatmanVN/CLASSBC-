using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class UiManager
    {
        public Action UiManagers()
        {
            Console.WriteLine("====Battel Super====");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.Thong Tin Tai Khoan");
            Console.WriteLine("2.Gacha Item");
            Console.WriteLine("3.Create Character");
            Console.WriteLine("4.Show All Item");
            Console.WriteLine("5.Show All Character");
            Console.WriteLine("6.Batter Royal");
            Console.WriteLine("--------------------------");
            Console.Write("Nhap chuc nang: ");
            int key;
            do
            {
                string input = Console.ReadLine();
                if (!int.TryParse(input, out key) || key < 0 || key > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Vui long nhap dung!");
                    Program.Start();
                    break;
                }
                else if (int.TryParse(input, out key) && key == 1)
                {
                    Program.listUiManager.ShowInfoUser();
                    break;
                }
                else if (int.TryParse(input, out key) && key == 2)
                {
                    Program.listUiManager.GachaItem();
                    break;
                }
                else if (int.TryParse(input, out key) && key == 3)
                {
                    Program.listUiManager.CreateCharacter();
                    break;
                }
                else if (int.TryParse(input, out key) && key == 4)
                {
                   Program.listUiManager.ShowAllItem();
                    break;
                }
                else if (int.TryParse(input, out key) && key == 5)
                {
                    Program.listUiManager.ShowAllCharacter();
                    break;
                }
                else
                {
                    Program.listUiManager.BattelRoyal();
                    break;
                }
            } while (true);
            return Program.listUiManager.listUiManager[key];
        }
    }
}
