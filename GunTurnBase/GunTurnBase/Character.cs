using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunTurnBase
{
    public class Character
    {
        public string Charactername;
        public float Health { get; set; }

        public float atk { get; set; }
        public float spd { get; set; }

        public Weapon[] weapons = null;
        public bool Alive => Health > 0;
        public Character()
        {
            atk = 0;
            Health = GameHelper.GetRandom(100, 200);
            weapons = new Weapon[2];
        }

        public void Attack(Character target)
        {
            if(!target.Alive)
                return;
            target.TakedDame(atk);

        }

        public virtual void TakedDame(float dame)
        {
            if (!Alive)
                return;
            Health -= dame;
        }
    }
}
