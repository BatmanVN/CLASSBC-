using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class GameHelper
    {
         public static int GetGameValue(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
