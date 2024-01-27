using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaItem
{
    internal class Program
    {
        public static Item[] items = null;
        static void Main(string[] args)
        {

        }

        public static int ShowMenu()
        {
            Console.WriteLine("===Thong Tin Vat Pham===");
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            int key = int.Parse(Console.ReadLine());
            Console.ReadKey();
            return key;
        }
    }
}
