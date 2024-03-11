using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class Knight : Character
    {
        public Knight() :base() 
        {
            health = GameHelper.GetRandomValue(150, 170);
            phyAtk = GameHelper.GetRandomValue(25, 35);
            spdAtk = GameHelper.GetRandomValue(4, 6);
            magicAtk = 0;
        }
    }
}
