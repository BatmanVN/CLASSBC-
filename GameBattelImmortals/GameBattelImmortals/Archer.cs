using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class Archer : Character
    {
        public Archer() : base ()
        {
            health = GameHelper.GetGameValue(100, 120);
            speedAtk = GameHelper.GetGameValue(8, 10);
            physicalAtk = GameHelper.GetGameValue(30, 35);
            magicAtk = 0;
        }
    }
}
