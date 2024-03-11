using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerItem
{

    public class Item
    {
        public int level;
        public Itemtype itemtype;
        public RarityItem rarityItem;

        public Item()
        {
            this.level = 1;
            this.itemtype = (Itemtype)GameHelper.Randomvalue(0, 4);
            this.rarityItem = (RarityItem)GameHelper.Randomvalue(0, 4);

        }

        public Item(int level, Itemtype itemType, RarityItem rarityItem)
        {
            this.level = level;
            this.itemtype = itemType;
            this.rarityItem = rarityItem;
        }
    }
}
