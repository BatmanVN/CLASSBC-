using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GachaItem
{
    public class ItemManager
    {
        public List<Item> items;
        //public List<Item> itemused;
        public ItemManager() 
        {
            items = new List<Item>();
            //itemused = new List<Item>(4);
            Program.gacha = CreatItem;
            Program.upgradeLV = UpgradeLV;
            Program.mergerItem = Merger;
            Program.deleteitem = DeleteItem;
        }
        private void CreatItem()
        {
            Console.Clear();
            Console.WriteLine("1.Roll x1 \t 2.Roll x10\n0.Nhan 0 de quay lai menu");
            int key = 0;
            try
            {
                key = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.Clear();
                CreatItem();
            }
            if (key == 0)
                Program.StartGame();
            else if (key == 1)
            {
                Console.Clear();
                Item item = new Item();
                items.Add(item);
                Console.WriteLine($"Ban da quay ra:\n Type: {item.itemType}\t\tRarity: {item.rarity}\t\tLevel: {item.level}");
                Console.Write("Nhap bat ky de quay lai");
                Console.ReadKey();
                CreatItem();
            }
            else if (key == 2)
            {
                Console.Clear();
                Console.WriteLine("Ban da quay ra:");
                for (int i = 0; i < 10; i++)
                {
                    Item itemx10 = new Item();
                    items.Add(itemx10);
                    Console.WriteLine($"{i + 1}.Type: {itemx10.itemType}\t\tRarity: {itemx10.rarity}\t\tLevel: {itemx10.level}");
                    Thread.Sleep(300);
                }
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Khoi tao thanh cong! Nhan bat ky de quay lai");
                Console.ReadKey();
                CreatItem();
            }
            Console.ReadKey();
        }
        private void DeleteItem(int index)
        {
            Item item = new Item();
            items.RemoveAt(index);
        }
        private void UpgradeLV(int index, Character character)
        {
            items[index].level++;
        }

        private void Merger(int index1, int index2, Character character)
        {
            if (items[index1].rarity != items[index2].rarity || items[index1].itemType != items[index2].itemType)
                return;
            Item item = new Item(items[index1].itemType, (Rarity)((int)items[index1].rarity + 1), 1);
            items.Remove(items[index1]);
            items.Remove(items[index2]);
            items.Add(item);
        }
    }
}
