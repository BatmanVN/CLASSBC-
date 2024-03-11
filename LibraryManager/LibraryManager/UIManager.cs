using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class UIManager
    {
        public void LoginMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            int select = InputInt("lua chon cua ban: ");
            if (select == 1)
            {
                Login();
            }
            else if (select == 2)
            {
                Register();
            }
        }

        public void Register()
        {
            Console.Clear();
            string username = InputStr("Ho ten: ");
            string userid = InputStr("Userid: ");
            string birthdate = InputStr("Ngay thang nam sinh: ");
            int balance = InputInt("So du: ");

            Program.user = new User(username,DateTime.Parse(birthdate),userid,balance);
            Console.WriteLine("Tao tai khoan thanh cong");
            Console.ReadKey();
            LoginMenu();
        }

        public bool CanLogin(string username)
        {
            if (Program.user.username != username)
            {
                return false;
            }
            return true;
        }

        public void Login()
        {
            Console.Clear();
            if (Program.user == null)
            {
                Console.WriteLine("Ban chua tao tai khoan vui long dang ky");
                LoginMenu();
            }
            string username = InputStr("Username: ");
            if (CanLogin(username))
            {
                Console.WriteLine("Chao mung ban den voi chuong trinh quan ly");
            }
            else
            {
                Console.WriteLine("Sai username vui long nhap lai");
                LoginMenu();
            }
        }

        public string InputStr(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }

        public int InputInt(string input)
        {
            Console.Write(input);
            return int.Parse(Console.ReadLine());
        }
    }
}
