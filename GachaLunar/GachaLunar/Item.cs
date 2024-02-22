using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaLunar
{
    public enum ItemType
    {
        Bow,
        Sword,
        Staff,
        Armour
    }
    public enum Rarity
    {
        Common,
        Rare,
        Legendary,
        Mythic
    }
    public class Item
    {
        public ItemType itemtype;

        public Item() { }
        public Item(ItemType itemtype) 
        {
            this.itemtype = itemtype;
        }

        public void ShowInformation(Item items)
        {
            Console.WriteLine("====Thong tin Vat Pham====");
            Console.WriteLine($"Loai trang bi: {items.itemtype}");
            Console.WriteLine("1.Ban vat pham");
            Console.WriteLine("2.Nang cap vat pham");
            Console.WriteLine("3.Thoat");
            int key = int.Parse( Console.ReadLine() );
            if (key == 3)
                Program.GameUI();
        }
    }
}
