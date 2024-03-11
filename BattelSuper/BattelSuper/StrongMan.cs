using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class StrongMan : Character
    {
        public StrongMan() : base()
        {
            health = GameHelper.GetRandomValue(150, 160);
            phyAtk = GameHelper.GetRandomValue(35, 45);
            spdAtk = GameHelper.GetRandomValue(4, 5);
            magicAtk = 0;
        }
    }
}
