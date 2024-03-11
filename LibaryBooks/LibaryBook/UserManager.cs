using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryBook
{
    public class UserManager
    {
        public List<Libary> borrowedbooks;
        public User user = null;

        public UserManager()
        {
            borrowedbooks = new List<Libary>(5);
            Program.createUser = CreateUser;
            Program.loginUser = LoginUser;
        }
        public void CreateUser()
        {
            Console.Clear();
            Console.WriteLine("Sign Up");
            string users = InputStr("User Name: ");
            string pass = InputStr("PassWord: ");
            Console.Clear();
            Console.WriteLine("----User Information Need for Sign Up----");
            string date = InputStr("Month/d/Year: ");
            int balance = 0;
            int card = InputInt("Card Number: ");
            Console.WriteLine("Sign Up Success\nPress any key to back Menu");
            Program.user = new User(users, pass, DateTime.Parse(date), balance, card);
            user.borrowedbooks = new List<Libary>(5);
            Console.ReadKey();
            Program.Start();
        }
        public void UserInfor()
        {
            Console.Clear();
            Console.WriteLine("------Information User------");
            Console.WriteLine($"-User Name: {Program.user.userName}\n-BirthDay: {Program.user.birthDay}\n-Balance: {Program.user.baLance}\n-Card Number: {Program.user.cardNumber}");
            Console.WriteLine("Press any key to back Menu");
            Console.ReadKey();
            Program.Start();
        }
        public void LoginUser()
        {
            Console.Clear();
            Console.WriteLine("Sign In");
            Console.WriteLine("--------------");
            string users = InputStr("User Name: ");
            string pass = InputStr("PassWord: ");
            if (users != Program.user.userName || pass != Program.user.passWord)
            {
                Console.WriteLine("!!!Login failed!!!");
                Console.WriteLine("Wrong account or password,Please Sign In Again");
                Console.Clear();
                LoginUser();
            }
            else if (users == Program.user.userName || pass == Program.user.passWord)
            {
                Console.WriteLine("\r\nLogged in successfully");
                Program.Start();
            }
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
