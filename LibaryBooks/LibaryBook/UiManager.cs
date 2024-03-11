using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryBook
{
    public class UiManager
    {
        public void ShowMenu()
        {
            Console.WriteLine("======Be.Be Libary======");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1.Sign Up");
            Console.WriteLine("2.Sign In");
            Console.WriteLine("3.Libary Book");
            Console.WriteLine("4.Borrow Book");
            Console.WriteLine("5.Exit");
            Console.WriteLine("-----------------------------");
        }
        public Action Select()
        {
            int key = 0;
            try
            {
                key = int.Parse(Console.ReadLine())-1;
            }
            catch
            {
                Console.Clear();
                Program.Start();
            }
            //do
            //{
            //    string input = Console.ReadLine();
            //    if (key < 0 || key > 4 || !int.TryParse(input, out key))
            //    {
            //        Program.Start();
            //    }
            //} while (key<0 || key>4);
            return Program.listUiManager.listUiManager[key];
        }
    }
}
