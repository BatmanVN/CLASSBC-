using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Program
    {
        public static User user = null;
        public static UIManager uimanager = new UIManager();
        static void Main(string[] args)
        {
            uimanager.LoginMenu();
        }
    }
}
