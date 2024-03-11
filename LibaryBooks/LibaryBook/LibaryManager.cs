using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryBook
{
    public class LibaryManager
    {
        public List<Libary> listBook;
        public List<Action> libaries = null;
        public User currentUser;
        public LibaryManager() 
        {
            listBook = new List<Libary>()
            {
                new Libary("EasyEnglishConversation",10),
                new Libary("SpeakingMatrix",10),
                new Libary("HackingEnglish",10),
                new Libary("EverydayConversations",10),
                new Libary("TacticsForListening",10),
            };
            currentUser = Program.user;
            libaries = new List<Action>()
            {
                EasyEnglishConversation,
                SpeakingMatrix,
                HackingEnglish,
                EverydayConversations,
                TacticsForListening
            };
            Program.allBook = ReadBook;
            Program.borrowBooks = BorrowBooks;
        }
        public void EasyEnglishConversation()
        {
            Console.Clear();
            Console.WriteLine("At the top of the list is an extremely famous book by Mcbook....");
            Console.WriteLine("Press 0 to back Libary");
            int select = int.Parse(Console.ReadLine());
            if (select == 0)
                ReadBook();

        }
        public void SpeakingMatrix()
        {
            Console.Clear();
            Console.WriteLine("At the top of the list is an extremely famous book by Mcbook....");
            Console.WriteLine("Press 0 to back Libary");
            int select = int.Parse(Console.ReadLine());
            if (select == 0)
                ReadBook();
        }
        public void HackingEnglish()
        {
            Console.Clear();
            Console.WriteLine("At the top of the list is an extremely famous book by Mcbook....");
            Console.WriteLine("Press 0 to back Libary");
            int select = int.Parse(Console.ReadLine());
            if (select == 0)
                ReadBook();
        }
        public void EverydayConversations()
        {
            Console.Clear();
            Console.WriteLine("At the top of the list is an extremely famous book by Mcbook....");
            Console.WriteLine("Press 0 to back Libary");
            int select = int.Parse(Console.ReadLine());
            if (select == 0)
                ReadBook();
        }
        public void TacticsForListening()
        {
            Console.Clear();
            Console.WriteLine("At the top of the list is an extremely famous book by Mcbook....");
            Console.WriteLine("Press 0 to back Libary");
            int select = int.Parse(Console.ReadLine());
            if (select == 0)
                ReadBook();
        }
        public void ReadBook()
        {
            //if (currentUser == null || currentUser != Program.user)
            //{
            //    Console.WriteLine("Need to log in to use this function");
            //    Program.Start();
            //}
            //else if (currentUser != null && currentUser == Program.user)
            //{
                Console.Clear();
                for (int i = 0; i < listBook.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.Book: {listBook[i].bookName} \n  -Gia: {listBook[i].price} USD");
                }
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Enter the order of the books you want to Read\nAn 0 de quay lai menu!");
                SelectBook()?.Invoke();
            //}
        }
        public void BorrowBooks(int index, List<Libary> borrowlist)
        {
            //if (currentUser == null || currentUser != Program.user)
            //{
            //    Console.WriteLine("Need to log in to use this function");
            //    Program.Start();
            //}
            //else if (currentUser != null && currentUser == Program.user)
            //{
            Console.Clear();
            for (int i = 0; i < listBook.Count; i++)
            {
                Console.WriteLine($"{i + 1}.Book: {listBook[i].bookName} \n  -Gia: {listBook[i].price} USD");
            }
            Console.WriteLine("---------------------------------------");
            int key = InputInt("Nhap sach ban muon muon \nAn 0 de quay lai menu!") -1;
            if (key == 0)
                Program.Start();
            if(Program.user == null)
            {
                return;
            }
            Console.WriteLine("Ban da muon thanh cong:");
            Console.WriteLine($"Book: {borrowlist[key].bookName} \n  -Gia: {borrowlist[key].price} USD");
            Borrowbook(key,borrowlist);
            Console.WriteLine("Press any key to back menu");
            Console.ReadKey();
            Program.Start();   
        }
        public Action SelectBook()
        {
            int select = int.Parse(Console.ReadLine()) - 1;
                if (select == -1)
                {
                    Program.Start();
                }
            return Program.libaryManager.libaries[select];
        }
        public void Borrowbook(int index, List<Libary> borrowlist)
        {
            if (FullSlot(Program.user) == true)
            {
                Console.WriteLine("You have reached your book borrowing limit!");
            }
            for(int i = 0; i<listBook.Count;i++)
            {
                Program.user.borrowedbooks = borrowlist[index];
                borrowlist.Remove(borrowlist[index]);
            }
        }
        public void ReturnBook(int index, List<Libary> borrowlist, User user)
        {
            user.borrowedbooks.Remove(borrowlist[index]);
            borrowlist.Add(borrowlist[index]);
            Console.WriteLine("You have returned the book!");
        }
        public bool FullSlot(User user)
        {
            if (user.borrowedbooks.Count <= 5)
                return false;
            else
                return true;
        }
        public string InputStr(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
        public int InputInt(string message)
        {
            Console.Write(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
