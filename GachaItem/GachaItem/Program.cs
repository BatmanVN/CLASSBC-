using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GachaItem
{
    internal class Program
    {
        public static Item[] items = null; 
        public static int[] configItemValue = null;
        public static int itemIndex;
        private static ItemType itemType;

        static void Main(string[] args)
        {
            GameUI();
        }

        public static int ShowMenu()
        {
            Console.WriteLine("===Thong Tin Vat Pham===");
            Console.WriteLine("1.Gacha Number1.");
            Console.WriteLine("2.Kho Do"); //trong kho do se co them ban vat pham va nang cap vat pham
            Console.WriteLine("3.Hien Thi Vat Pham"); //trong case 3 se co them chuc nang nang cap vat pham va hien thi chi tiet vat pham
            Console.WriteLine("4.Nang cap vat pham");
            Console.WriteLine("5.Merge Vat Pham"); //trong nay se co hien thi kho do va vat pham co trong do
            Console.WriteLine("6.Thoat!");
            int key = int.Parse(Console.ReadLine());
            Console.ReadKey();
            return key;
        }

        public static void GameUI()
        {
            int key = ShowMenu();
            switch (key)
            {
                case 1:
                    GachaRoll(items,itemType);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    Console.WriteLine("Chao Tam Biet!!!");
                    break;
            }
        }
        public static void GachaRoll(Item[] items,ItemType itemType)
        {
            Console.Clear();
            Console.WriteLine("1.Roll X1");
            Console.WriteLine("2.Roll x10");
            int key = int.Parse(Console.ReadLine());
            Item item = new Item(itemType);
            if (key == 1)
            {
                Console.WriteLine($"Ban da roll ra {GetItemName(item)}");
                Thread.Sleep(20);
            }
            else
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] != null)
                    {
                        Console.WriteLine($"Ban da roll ra {i + 1}.{items[i].itemName}");
                        Thread.Sleep(100);
                    }
                }
            }
            AddItemtoArray(items,item);
            Item.ShowInforMationItem(item);
            Console.WriteLine("Press any key to back...");
            Console.ReadKey();
            GameUI();
        }

        private static string GetItemName(Item item)
        {
            return item.itemName;
        }

        public static void AddItemtoArray(Item[] items, Item itemtoAdd)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if(items[i] != null)
                {
                    items[i] = itemtoAdd;
                    break;
                }
            }
        }
        public static void ShowAllItems(Item[] items)
        {
            Console.Clear();
            SortItems(items);
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i+1}.{items[i].itemName}");
            }

            Console.Write("Chon vat pham muon thao tac:");
            itemIndex = int.Parse(Console.ReadLine());
            Console.Clear();
            int sellItem = Item.ShowInforMationItem(items[itemIndex-1]);
        }
        public static void SortItems(Item[] items)
        {
            for(int j = 0; j < items.Length; j++)
            {
                for(int i = j + 1; i < items.Length; i++)
                {
                    if(items[i] != null && items[j] != null)
                    {
                        if((int)items[i].rarity > (int)items[j].rarity)
                        {
                            Item temp = items[j];
                            items[j] = items[i];
                            items[j] = temp;
                        }
                    }
                }
            }
        }
    }
}
