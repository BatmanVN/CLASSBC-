using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaItem
{
    public abstract class Item
    {
        public ItemType itemType;
        public Rarity rarity;

        public Item()
        {

        }
        public bool CanUpgrade(Rarity rarityToUpgrade)
        {
            return MoneyManager.currentGold >= IventoryManager.goldToUpgrade[(int)rarityToUpgrade];
        }
    }
}
