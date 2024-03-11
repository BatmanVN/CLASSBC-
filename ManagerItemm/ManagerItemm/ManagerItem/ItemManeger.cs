using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManagerItem
{
    public class ItemManeger
    {
        public static List<Item> inventory = new List<Item>();

        public ItemManeger()
        {
            UIManager.gachadelegate = Gacha;
        }
        private static void Gacha()
        {
            Console.Clear();
            Console.WriteLine("1.Roll x1\n2.Roll x10\n0.Nhan phim bat ky de quay lai Menu");
            Console.WriteLine("-------------------------------------");
            //UIManager.gachadelegate(inventory);
            int key = 0;
            try
            {
                key = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Gacha();
            }
            if (key == 1)
            {
                Console.Clear();
                Item item = new Item();
                inventory.Add(item);
                Console.WriteLine("Ban da quay ra:");
                Console.WriteLine($"Type: {item.itemtype}\tRarity: {item.rarityItem}   \t Level: {item.level}");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Nhan phim bat ky de quay lai");
                Console.ReadKey();
            }
            else if (key == 2)
            {
                Console.Clear();
                Console.WriteLine("Ban da quay ra:");
                for (int i = 0; i < 10; i++)
                {
                    Item itemx10 = new Item();
                    inventory.Add(itemx10);
                    Console.WriteLine($"{i + 1}. Type: {itemx10.itemtype}\t Rarity: {itemx10.rarityItem}   \t Level: {itemx10.level}");
                    Thread.Sleep(150);
                }
                Console.WriteLine("-------------------------------------------");
                Console.Write("Nhan phim bat ky de quay lai!");
                Console.ReadKey();
            }
            else
            {
                Gacha();
                Console.Clear();
            }
            //return key;
        }
        public static void ShowAllItem()
        {
            Console.Clear();
            Console.WriteLine("  ====Kho Do====");
            Console.WriteLine("-------------------");
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] != null)
                    Console.WriteLine($"{i + 1}. Type: {inventory[i].itemtype}\t Rarity: {inventory[i].rarityItem}   \t Level: {inventory[i].level}");
                Thread.Sleep(50);
            }
            Console.WriteLine("Nhan phim bat ky de quay lai");
            Console.ReadKey();
            UIManager.Choice();
        }
        public static void Upgrade()
        {
            Console.Clear();
            Console.WriteLine("1.Nang cap lv");
            Console.WriteLine("2.Nang cap pham chat");
            Console.WriteLine("Press any key to back");
            int key = 0;
            try
            {
                key = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Upgrade();
            }
            if (key == 1)
            {
                UpGradeLV();
            }
            else if (key == 2)
            {
                MergerItem();
            }
            else
            {
                ShowAllItem();
            }
            ShowAllItem();
            //return key;
        }

        public static void UpGradeLV()
        {
            Console.Clear();
            Console.WriteLine("====Kho Do====");
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] != null)
                {
                    Console.WriteLine($"{i + 1}. Type: {inventory[i].itemtype}\t Rarity: {inventory[i].rarityItem}   \t level: {inventory[i].level}");
                }
                Thread.Sleep(50);
            }
            Console.WriteLine("Nhap thu tu vat pham ban muong nang cap:");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            UpgradeItem.DoUpgradeLevel(inventory[num - 1]);
            Console.WriteLine($"Ban da Nang cap LV vat pham:\n {num}.Type: {inventory[num - 1].itemtype}\t Rarity: {inventory[num - 1].rarityItem}   \t level: {inventory[num - 1].level}");
            Console.WriteLine("Nhan phim bat ky de quay lai");
            Console.ReadKey();
            Console.Clear();
        }

        public static string UpGradeRarity(List<Item> inventory, int index1, int index2)
        {
            Console.Clear();
            Console.WriteLine("Thong tin vat pham moi sau khi nang cap la:");
            Console.WriteLine($"Type: {inventory[index1].itemtype} \t Rarity: {(RarityItem)((int)inventory[index1].rarityItem + 1)}  \t Level: {inventory[index1].level}");
            string key = InputString("Nhan Y/y de nang cap, N/n de huy va quay lai:");
            return key;
        }

        public static void MergerItem()
        {
            Console.Clear();
            int index1 = InputInt("Nhap vat pham thu 1: ") - 1;
            int index2 = InputInt("Nhap vat pham thu 2: ") - 1;
            string select = UpGradeRarity(inventory, index1, index2);
            if (select.Equals("Y") || select.Equals("y"))
            {
                UpgradeItem.DoUpGradeRarity(index1, index2);
                Console.WriteLine("Nang cap Pham chat vat pham thanh cong\nNhan bat ky de quay lai:");
                Console.ReadKey();
                ShowAllItem();
            }
        }
        public static int InputInt(string message)
        {
            Console.WriteLine(message);
            int key = int.Parse(Console.ReadLine());
            return key;
        }

        public static string InputString(string message)
        {
            Console.WriteLine(message);
            string key = Console.ReadLine();
            return key;
        }

    }
}
