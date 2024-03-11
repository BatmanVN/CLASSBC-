using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class Assasin : Character
    {
        public Assasin() : base() 
        {
            health = GameHelper.GetRandomValue(100,120);
            phyAtk = GameHelper.GetRandomValue(40, 50);
            spdAtk = GameHelper.GetRandomValue(4,6);
            magicAtk = 0;
        }
    }
}
