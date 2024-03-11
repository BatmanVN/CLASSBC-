using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerItem
{
    public delegate void Gacha();
    public class UIManager
    {
        public static Gacha gachadelegate;

        public static int Showmenu()

        {
            Console.Clear();
            Console.WriteLine("1.Quay vat pham");
            Console.WriteLine("2.Hien thi danh sach vat pham");
            Console.WriteLine("3.Nang cap level vat pham");
            Console.WriteLine("4.Nang cap pham chat vat pham");
            Console.WriteLine("---------------------------------");
            Console.Write("Nhap lua chon:");
            int key = 0;
            try
            {
                key = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
            }
            Console.Clear();
            return key;
        }
        public static int Choice()
        {
            Console.Clear();
            int key = Showmenu();
            switch (key)
            {
                case 1:
                    gachadelegate?.Invoke();
                    break;
                case 2:
                    ItemManeger.ShowAllItem();
                    break;
                case 3:
                    ItemManeger.Upgrade();
                    break;
                case 4:
                    break;
                //default:
                //    Showmenu();
                //    break;
            }
            return key;
        }
    }
}
