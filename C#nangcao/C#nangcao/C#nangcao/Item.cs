using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_nangcao
{
    public class Item
    {
        public int price;
        public int level;
        public Item()
        {
            Random r = new Random();
            this.price = r.Next(10,100);
        }
    }
}
