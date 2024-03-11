using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate void ShowBooksDlg(Action<Book> callback);


    internal class Program
    {
        public static ShowBooksDlg ShowBooks;

        static void Main(string[] args)
        {
            UIManager.AccountUI();

            Console.ReadKey();
        }
    }
}
