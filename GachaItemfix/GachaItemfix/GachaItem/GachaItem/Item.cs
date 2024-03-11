using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaItem
{
    public class Item
    {
        public Rarity rarity;
        public ItemType itemType;
        public int level;

        public Item() 
        {
            this.itemType = (ItemType)GameHelper.GetRandomValue(0,4);
            this.rarity = (Rarity)GameHelper.GetRandomValue(0,5);
            this.level = 1;
        }
        public Item(ItemType itemType, Rarity rarity, int level)
        {
            this.rarity = rarity;
            this.itemType = itemType;
            this.level = level;
        }
    }
}
