using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate
{
    public class ItemsManager
    {

        public List<Item> items = null;


        public ItemsManager()
        {
            items = new List<Item>();
            Program.GachaDelegate = CreateItems;
            Program.UpgradeItemDelegate = UpgradeItemLevel;
            Program.MergeItemsDelegate = MergeItems;
        }


        private void CreateItems(int count)
        {
            for (int i = 0; i < count; i++)
            {
                ItemType type = (ItemType)GameHelper.GetRandomInt(0, 4);
                ItemRarity rarity = (ItemRarity)GameHelper.GetRandomInt(0, 5);
                Item item = new Item(type, rarity, 1);
                items.Add(item);
                Thread.Sleep(100);
            }
        }

        private void UpgradeItemLevel(int index)
        {
            items[index].level++;
        }

        private void MergeItems(int index1, int index2)
        {
            if (items[index1].type != items[index2].type || items[index1].rarity != items[index2].rarity)
                return;

            Item item = new Item(items[index1].type, (ItemRarity)((int)items[index1].rarity + 1), 1);
            items.RemoveAt(index1);
            items.RemoveAt(index2);
            items.Add(item);
        }


    }
}
