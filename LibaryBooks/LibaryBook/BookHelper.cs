using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryBook
{
    public class BookHelper
    {
        public static int GetValueRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
