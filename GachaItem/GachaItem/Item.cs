using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaItem
{
    public enum ItemType
    {
        Bow,
        Staff,
        Sword,
        Armour
    }

    public enum Rarity
    {
        Common,
        Rare,
        Epic,
        Legendary,
        Mythical
    }
    public class Item
    {
        public string itemName;
        public float price { get; set; }
        public float value { get; set; }
        public static ItemType itemType { get; set; }
        public ItemType ItemType { get; }

        //public static ItemType itemType;

        public Rarity rarity;
        public static int[] goldToUpgrade = new int[5] { 150, 200, 250, 300, 500 };

        public static int[] goldFromSellItem = new int[5] { 100, 150, 200, 250, 400 };
        public static int ShowInforMationItem(Item item)
        {
            Console.WriteLine("===Thong Tin Chi Tiet Item===");
            Console.WriteLine($"Loai trang bi: {itemType}");
            /*Console.WriteLine($"Gia: {price.ToString()}")*/
            ;
            Console.WriteLine("=============================");
            Console.WriteLine("1.Ban Vat Pham");
            Console.WriteLine("2.Nang cap vat pham");
            Console.WriteLine("3.Quay lai.");
            //label:
            int key = int.Parse(Console.ReadLine());
            return key;
        }

        public Item(ItemType itemType, Rarity rarity)
        {
            this.itemName = itemType.ToString();
            this.rarity = rarity;
        }

        public Item(ItemType itemType1)
        {
            this.ItemType = itemType1;
        }

        public Item() { }
        public bool CanUpgrade(Rarity rarityToUpgrade)
        {
            return MoneyManager.currentGold >= Item.goldToUpgrade[(int)rarityToUpgrade];
        }

        public void OnUpgradeItem(Rarity rarityToUpgrade)
        {
            if(!CanUpgrade(rarityToUpgrade))
                return;
        }
    }
}
