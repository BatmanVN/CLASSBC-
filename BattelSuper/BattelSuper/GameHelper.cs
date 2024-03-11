using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class GameHelper
    {
        public static int GetRandomValue(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
