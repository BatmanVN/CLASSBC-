using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace abstractionandinterface
{
    public abstract class Items
    {
        public ItemType itemType;
        public Rarity rarity;

        public Items() 
        {
            
        }
        public Items(ItemType itemType, Rarity rarity)
        {
            this.itemType = itemType;
            this.rarity = rarity;
        }
        public bool CanUpgarade(Rarity rarityToUpgrade) 
        {
            return CurrencyManager.currentGold >= Gameconst.goldToUpgradeItem[(int)rarityToUpgrade];
        }
        public void OnUpgradeItem(Rarity rarityToUpgrade)
        {
            if (!CanUpgarade(rarityToUpgrade))
                return;
            DoUpgradeItem(rarityToUpgrade);
        }
        public abstract void DoUpgradeItem(Rarity rarityToUpgrade);
    }
}
