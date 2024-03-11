using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class Tank : Character
    {
        public Tank() : base()
        {
            health = GameHelper.GetRandomValue(190, 200);
            phyAtk = GameHelper.GetRandomValue(20, 30);
            spdAtk = GameHelper.GetRandomValue(4, 5);
            magicAtk = 0;
        }
    }
}
