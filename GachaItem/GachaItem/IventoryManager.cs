using System;
using System.Collections.Generic;
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
    public class IventoryManager
    {
        public float price { get; set; }
        public float value;
        public static ItemType itemType;
        public float atk { get; set; }
        public IventoryManager(float value, ItemType itemType)
        {
            Rarity itemRarity = (Rarity)GameHelper.Getrandom(0,5);
            switch (itemRarity)
            {
                case Rarity.Common:
                    itemRarity = (Rarity)GameHelper.Getrandom(0,75);
                    break;
                case Rarity.Rare:
                    itemRarity = (Rarity)GameHelper.Getrandom(0, 15);
                    break;
                case Rarity.Epic:
                    itemRarity = (Rarity)GameHelper.Getrandom(0, 5);
                    break;
                case Rarity.Legendary:
                    itemRarity= (Rarity)GameHelper.Getrandom(0, 35/100);
                    break;
                case Rarity.Mythical:
                    itemRarity = (Rarity)GameHelper.Getrandom(0, 15 / 100);
                    break;
            }
        }
        public static int[] goldToUpgrade = new int[5] { 150, 200, 250, 300, 500 };

        public static int[] goldFromSellItem = new int[5] { 100, 150, 200, 250, 400 };

        public static int ShowInforMationItem(Item item)
        {
            Console.WriteLine("===Thong Tin Chi Tiet Item===");
            Console.WriteLine($"Loai trang bi: {itemType.ToString()}");
            /*Console.WriteLine($"Gia: {price.ToString()}")*/;
            Console.WriteLine("=============================");
            Console.WriteLine("1.Ban Vat Pham");
            Console.WriteLine("2.Nang cap vat pham");
            Console.WriteLine("3.Quay lai.");
        //label:
            int key = int.Parse(Console.ReadLine());
            return key;
            //if(key == 3)
            //{
            //    Program.ShowMenu();
            //}
            //if(key == 1)
            //{

            //}
            //if(key == 2)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Vui long nhap dung");
            //    goto label;
            //}
        }
    }


}
