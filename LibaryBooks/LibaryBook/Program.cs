using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryBook
{
    public delegate void AllBook();
    public delegate void CreateUser();
    public delegate void LoginUser();
    public delegate void BorrowBooks(int index, List<Libary> borrowlist);
    internal class Program
    {
        public static User user = null;
        public static AllBook allBook;
        public static CreateUser createUser;
        public static LoginUser loginUser;
        public static BorrowBooks borrowBooks;

        public static UiManager uiManager = null;
        public static LibaryManager libaryManager = null;
        public static ListUiManager listUiManager = null;
        public static UserManager userManager = null;

        static void Main(string[] args)
        {
            uiManager = new UiManager();
            listUiManager = new ListUiManager();
            userManager = new UserManager();
            libaryManager = new LibaryManager();
            //libaryManager.Borrowbook = userManager.Borrowbook;
            Start();
            Console.ReadKey();
        }
        public static void Start()
        {
            Console.Clear();
            uiManager.ShowMenu();
            uiManager.Select()?.Invoke();
            Console.ReadKey();
        }
    }
}
