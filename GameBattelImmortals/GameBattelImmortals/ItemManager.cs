using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class ItemManager
    {
        public List<Item> items = null;
       public ItemManager() 
        {
            items = new List<Item>();
        }
        public void CreateItem()
        {
            Console.Clear();
            Roll();
            int key = 0;
            try
            { key = int.Parse(Console.ReadLine()); }
            catch
            {
                Console.Clear();
                CreateItem(); 
            }
        }

        public void Roll()
        {
            Console.WriteLine("1.Roll X1");
            Console.WriteLine("2.Roll X10");
        }
        public string InputStr(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        public int InputInt(string message)
        {
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
