using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibaryBook
{
    public class ListUiManager
    {
        public Action<int, List<Libary>> action;
        public List<Action> listUiManager = null;
        private int index;
        private List<Libary> borrowList;
        public ListUiManager() 
        {

            listUiManager = new List<Action>()
            {
                SignUp,
                SignIn,
                LibaryBook,
                () =>{BorrowBook(index,borrowList); },
                Exit
            };
        }
        public void SignUp()
        {
            Console.Clear();
            Program.createUser();
            Console.ReadKey();
        }
        public void SignIn() 
        {
            Console.Clear();
            Program.loginUser();
            Console.ReadKey();
        }
        public void LibaryBook()
        {
            Console.Clear();
            Program.allBook();
            Console.ReadKey();
        }
        public void BorrowBook(int index, List<Libary> borrowlist)
        {
            Console.Clear();
            Program.borrowBooks(index,borrowlist);
        }
        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Goodbye! Exiting program......");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
