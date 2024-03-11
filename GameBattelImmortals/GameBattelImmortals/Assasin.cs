using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class Assasin : Character
    {
        public Assasin() : base()
        {
            health = GameHelper.GetGameValue(100, 120);
            speedAtk = GameHelper.GetGameValue(6, 8);
            physicalAtk = GameHelper.GetGameValue(65, 75);
            magicAtk = 0;
        }    
    }
}
