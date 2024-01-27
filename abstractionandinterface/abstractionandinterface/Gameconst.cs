using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionandinterface
{
    public class Gameconst
    {
        public static int[] goldToUpgradeItem = new int[5] { 100, 200, 300, 400, 500 };
    }

    public enum ItemType
    {
        Sword,
        Bow,
        Armour,
        Staff
    }

    public enum Rarity
    {
        Common,
        Rare,
        Epic,
        Legendary,
        Mythical
    }
}
