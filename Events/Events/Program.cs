using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void handleDisplay();
    public class Program
    {
        public event handleDisplay display;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.display += new handleDisplay(p.Show);
            p.display();
            Console.ReadKey();
        }
        public void Show()
        {
            Console.WriteLine("Hello Sir!");
        }
    }
}
