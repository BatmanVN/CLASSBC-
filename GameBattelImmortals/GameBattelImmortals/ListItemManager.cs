using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class ListItemManager
    {
        public List<Action> listItemManager = null;
        public ListItemManager() 
        {
            listItemManager = new List<Action>()
            {
                RollX1
            };
        }
        public void RollX1()
        {
            Console.Clear();

            Console.ReadKey();
            Program.StartGame();
        }
    }
}
