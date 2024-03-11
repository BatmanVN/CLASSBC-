using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class Character
    {
        public CharacterType characterType;
        public string characterName;
        public int PhysicalAtk { get; protected set; }
        public int MagicAtk {  get; protected set; }
        public int Health { get; protected set; }
        public int SpeedAtk {  get; protected set; }
        public int Level {  get; protected set; }
        public int level
        {
            get { return Level; }
            set { this.Level = value; }
        }
        public int physicalAtk
        {
            get
            { return PhysicalAtk;}
            set 
            { this.PhysicalAtk = value;}
        }
        public int magicAtk
        {
            get { return MagicAtk;}
            set { this.MagicAtk = value; }
        }
       public int health
        {
            get { return Health; }
            set { Health = value; }
        }
        public int speedAtk
        {
            get { return SpeedAtk; }
            set { this.SpeedAtk = value; }
        }
        public Character()
        {

        }
        //public Character(int health, int speedAtk, int physicalAtk, int magicAtk) 
        //{
        //    this.Health = health;
        //    this.SpeedAtk = speedAtk;
        //    this.PhysicalAtk = physicalAtk;
        //    this.MagicAtk = magicAtk;
        //}
    }
}
