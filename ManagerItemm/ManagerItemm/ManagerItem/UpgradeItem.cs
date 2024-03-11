using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerItem
{
    public class UpgradeItem
    {
        public static void UpgradeLevelItem(Item item)
        {
            DoUpgradeLevel(item);
        }
        public static void DoUpgradeLevel(Item item)
        {
            item.level += 1;
        }
        public static void DoUpGradeRarity(int index1, int index2 )
        {
            if (ItemManeger.inventory[index1].itemtype != ItemManeger.inventory[index2].itemtype
               || ItemManeger.inventory[index1].rarityItem != ItemManeger.inventory[index2].rarityItem)
                return;
            Item item = new Item(1, ItemManeger.inventory[index1].itemtype, (RarityItem)((int)ItemManeger.inventory[index1].rarityItem + 1));
            ItemManeger.inventory.Remove(ItemManeger.inventory[index1]);
            ItemManeger.inventory.Remove(ItemManeger.inventory[index2]);
            ItemManeger.inventory.Add(item);
        }
    }
}
