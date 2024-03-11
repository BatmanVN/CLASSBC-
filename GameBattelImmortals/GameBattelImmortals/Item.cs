using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class Item
    {
        public ItemType itemType;
        public ItemRarity itemRarity;
        public float Value { get; protected set; }
        public Item() 
        {
            
        }
        public Item(float value, ItemType itemType, ItemRarity itemRarity) 
        { 
            this.Value = value;
            this.itemType = itemType;
            this.itemRarity = itemRarity;
        }
    }
}
