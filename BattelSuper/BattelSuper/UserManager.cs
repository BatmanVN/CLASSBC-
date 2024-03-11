using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class UserManager
    {
        public UserManager() 
        {
            Delegate.signUp = SignUp;
            Delegate.signIn = SignIn;
        }
        public void SignUp()
        {
            Console.Clear();
            Console.WriteLine("====Battel Super====");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Dang Ky Tai Khoan:");
            string userName = InputStr("ID: ");
            string password = InputStr("Password: ");
            User user = new User(userName,password);
            
            string json = File.ReadAllText("GameData.json");
            GameData gameData = JsonConvert.DeserializeObject<GameData>(json);
            gameData.users.Add(userName, user);
            string newJson = JsonConvert.SerializeObject(gameData);
            File.WriteAllText("GameData.json", newJson);
            Console.Write("Dang ky tai khoan thanh cong, nhan phim bat ky de tiep tuc: ");
            Console.ReadKey();
            ListUserManagerUi();
        }
        public void SignIn()
        {
            Console.Clear();
            Console.WriteLine("=========Dang Nhap==========");
            string userName = InputStr("ID: ");
            string password = InputStr("Password: ");

            string json = File.ReadAllText("GameData.json");
            GameData gameData = JsonConvert.DeserializeObject<GameData>(json);
            if(gameData.users.Any(u => u.Value.userName.Equals(userName) && u.Value.passWord.Equals(password)))
            {
                ListUserManagerUi();
            }
            else
            {
                Console.WriteLine("Khong ton tai tai khoan, vui long nhap lai hoac dang ky tai khoan");
                Console.WriteLine("Nhan 'Y' de tao tai khoan, Nhan 'N' de quay lai menu");
                string result = InputStr("Nhap lua chon: ");
                if(result.Equals("y") || result.Equals("N"))
                {
                    User newUser = new User(userName,password);
                    gameData.users.Add(userName,newUser);

                    string newJson = JsonConvert.SerializeObject(gameData);
                    File.WriteAllText("GameData.json", newJson);
                    Console.Write("Dang ky tai khoan thanh cong, nhan phim bat ky de tiep tuc: ");
                    Console.ReadKey();
                    ListUserManagerUi();
                }
                else if(result.Equals("n") || result.Equals("N"))
                {
                    Console.Clear();
                    Program.Start();
                }
            }
        }
        public void ListUserManagerUi()
        {
            Console.Clear();
            Console.WriteLine("===========Thong tin tai khoan===========");
            Console.WriteLine("1.Thong tin nguoi dung");
            Console.WriteLine("2.Menu");
            Console.WriteLine("=========================================");
            //int key;
            while (true)
            {
                int key = int.Parse(Console.ReadLine());
                if (key == 1)
                {
                    Console.Clear();
                    ShowInforUser();
                    break;
                }
                else if (key == 2)
                {
                    Console.Clear();
                    Program.Start();
                    break;
                }
            }
        }
        public void ShowInforUser()
        {

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
