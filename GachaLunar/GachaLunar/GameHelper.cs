using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaLunar
{
    public class GameHelper
    {
        public static int GetrandomValue(int min, int max)
        {
            {
                Random r = new Random();
                return r.Next(min,max);
            }
        }
    }
}
