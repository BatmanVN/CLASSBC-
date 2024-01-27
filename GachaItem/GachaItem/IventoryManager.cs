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
        public int price { get; set; }
        public float value;
        public IventoryManager()
        {

        }
        public static int[] goldToUpgrade = new int[5] { 10, 20, 30, 40, 50 };
    }


}
