using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class Character
    {
        public CharacterType characterType;
        public string Name { get; set; }
        public int health {  get; protected set; }
        public int phyAtk {  get; protected set; }
        public int spdAtk {  get; protected set; }
        public int magicAtk {  get; protected set; }
        public List<Item> itemused;
        public int Health
        {
            get { return health; }
            set { this.health = value; }
        }
        public int PhyAtk
        {
            get { return phyAtk; }
            set { this.phyAtk = value; }
        }
        public int SpdAtk
        {
            get { return spdAtk; }
            set { this.spdAtk = value; }
        }
        public int MagicAtk
        {
            get { return magicAtk; }
            set { this.magicAtk = value; }
        }
        public Character() 
        {
            itemused = new List<Item>(5);
        }
    }
}
