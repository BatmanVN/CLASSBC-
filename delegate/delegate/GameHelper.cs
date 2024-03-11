using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public static class GameHelper
    {


        public static int GetRandomInt(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
