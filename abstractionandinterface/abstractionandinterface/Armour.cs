using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionandinterface
{
    public class Armour : Items, IItemscs
    {
        public float _value;
        public float value
        {
            get => _value;
            set => _value = value;
        }
        public override void DoUpgradeItem(Rarity rarityToUpgrade)
        {
            rarity = (Rarity)((int)rarity + 1);
        }
        public void RarityUp()
        {
            rarity = (Rarity)((int)rarity + 1);
        }
    }
}
