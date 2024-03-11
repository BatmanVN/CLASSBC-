using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Assignment
{
    public static class UIManager
    {
        public static List<Action> accountUIFeatures = new List<Action>()
        {
            RegisterUI,
            LoginUI,
        };


        public static void ShowBooksUI()
        {
            Program.ShowBooks?.Invoke(ShowBookUI);
        }

        public static void ShowBookUI(Book book)
        {
            Console.Clear();
            Console.WriteLine("=========== Thong tin sach ===========");
            Console.WriteLine("Ten sach: ");
        }


        public static void AccountUI()
        {
            Console.Clear();
            Console.WriteLine("=========== Quan ly tai khoan ===========");
            Console.WriteLine("1. Dang ky");
            Console.WriteLine("2. Dang nhap");
            Console.WriteLine("=========================================");
            int key = InputInt("Chon chuc nang: ");

            accountUIFeatures[key - 1]?.Invoke();
        }

        public static void RegisterUI()
        {
            Console.Clear();
            Console.WriteLine("=========== Dang ky tai khoan ===========");
            string userName = InputStr("Nhap ten tai khoan: ");
            string password = InputStr("Nhap password: ");
            User user = new User(userName, password);

            string json = File.ReadAllText("AppData.json");
            AppData data = JsonConvert.DeserializeObject<AppData>(json);
            data.users.Add(userName, user);
            string newJson = JsonConvert.SerializeObject(data);
            File.WriteAllText("AppData.json", newJson);

            Console.Write("Dang ky tai khoan thanh cong, nhan phim bat ky de quay lai: ");
            Console.ReadKey();
            AccountUI();
        }

        public static void LoginUI()
        {
            Console.Clear();
            Console.WriteLine("=========== Dang nhap ===========");
            string userName = InputStr("Nhap ten tai khoan: ");
            string password = InputStr("Nhap password: ");

            string json = File.ReadAllText("AppData.json");
            AppData data = JsonConvert.DeserializeObject<AppData>(json);

            if (data.users.Any(u => u.Value.userName.Equals(userName) && u.Value.password.Equals(password)))
            {
                LibraryManagementUI();
            }
            else
            {
                Console.WriteLine("Khong ton tai tai khoan tren! Ban co muon dang ky tai khoan nay khong?");
                string result = InputStr("Nhap lua chon: ");
                if (result.Equals("y"))
                {
                    User newUser = new User(userName, password);
                    data.users.Add(userName, newUser);

                    string newJson = JsonConvert.SerializeObject(data);
                    File.WriteAllText("AppData.json", newJson);
                    Console.Write("Dang ky tai khoan thanh cong, nhan phim bat ky de tiep tuc: ");
                    Console.ReadKey();
                    LibraryManagementUI();
                }
            }
        }

        public static void LibraryManagementUI()
        {
            Console.Clear();
            Console.WriteLine("=========== Chuong trinh quan ly thu vien ===========");
            Console.WriteLine("1. Thong tin nguoi dung");
            Console.WriteLine("2. Danh sach books");
            Console.WriteLine("=========================================");
            int key = InputInt("Chon chuc nang: ");
        }


        public static string InputStr(string title)
        {
            Console.Write(title);
            return Console.ReadLine();
        }

        public static int InputInt(string title)
        {
            Console.Write(title);
            return int.Parse(Console.ReadLine());
        }
    }
}
