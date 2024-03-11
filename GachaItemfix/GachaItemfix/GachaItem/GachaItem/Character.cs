using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GachaItem
{
    public class Character
    {
        public CharacterType characterType;
        public string characterName;
        public List<Item> itemuse = null;
        public int PhysicalAtk { get;protected set; }
        public int MagicAtk { get;protected set; }
        public int Health {  get; protected set; }
        public int AtkSpeed {  get; protected set; }

        public int physicalAtk
        {
            get { return PhysicalAtk; }
            set { PhysicalAtk = value; }
        }
        public int magicAtk
        {
            get { return MagicAtk; }
            set { MagicAtk = value; }
        }
        public int health
        {
            get { return Health; }
            set { Health = value; } 
        }
        public int atkSpeed
        {
            get { return AtkSpeed; }
            set { AtkSpeed = value; }
        }
        public Character()
        {
            this.PhysicalAtk = physicalAtk;
            this.MagicAtk = magicAtk;
            this.Health = health;
            this.AtkSpeed = atkSpeed;
            //Program.fullSlot = FullSlot;
            //Program.equiqItem = EquiqItem;
            //Program.unequiqItem = UnequipMent;
        }
        //private void EquiqItem(int index, List<Item> itemss, Character character)
        //{
        //    if (Program.fullSlot(character) == true)
        //    {
        //        for (int i = 0; i < itemuse.Count; i++)
        //        {
        //            if (itemuse[i] == null)
        //            {
        //                //Console.WriteLine(itemuse[i]);
        //                itemuse.Add(itemss[index]);
        //                itemss.Remove(itemss[index]);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Da full slot!");
        //    }
        //}
        //private void UnequipMent(int index, List<Item> itemss, Character character)
        //{
        //    for (int i = 0; i < itemuse.Count; i++)
        //    {
        //        if (itemuse[i] != null)
        //        {
        //            itemss.Add(itemuse[index]);
        //            itemuse.Remove(itemuse[index]);
        //            break;
        //        }
        //    }
        //}

        //public Character(string characterName, CharacterType characterType, int PhysicalAtk, int MagicAtk
        //    , int Health, int AtkSpeed)
        //{
        //    this.characterName = characterName;
        //    this.characterType = characterType;
        //    this.PhysicalAtk = PhysicalAtk;
        //    this.MagicAtk = MagicAtk;
        //    this.Health = Health;
        //    this.AtkSpeed = AtkSpeed;
        //}
    }
}
