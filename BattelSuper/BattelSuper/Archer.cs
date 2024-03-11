using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class Archer : Character
    {
        public Archer() : base()
        {
            health = GameHelper.GetRandomValue(120, 130);
            phyAtk = GameHelper.GetRandomValue(30, 40);
            spdAtk = GameHelper.GetRandomValue(6, 8);
            magicAtk = 0;
        }
    }
}
