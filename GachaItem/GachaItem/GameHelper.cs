using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaItem
{
    public class GameHelper
    {
        public static float Getrandom(int min, int max)
        {
            Random r= new Random();
            return r.Next(min, max);
        }
    }
}
