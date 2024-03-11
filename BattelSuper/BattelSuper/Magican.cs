using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class Magican : Character
    {
        public Magican() :base()
        {
            health = GameHelper.GetRandomValue(120, 130);
            phyAtk = 0;
            spdAtk = GameHelper.GetRandomValue(5, 7);
            magicAtk = GameHelper.GetRandomValue(30,50);
        }
    }
}
