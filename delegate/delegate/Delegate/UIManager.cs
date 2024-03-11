using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class UIManager
    {


        public int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Khoi tao kho do");
            Console.WriteLine("2. Hien thi tat ca vat pham trong kho do");
            Console.WriteLine("------------------------------------------");
            int input = InputInt("Nhap lua chon: ");
            return input;
        }

        public void Gacha()
        {
            int count = InputInt("Nhap so luong vat pham muon khoi tao: ");
            Program.GachaDelegate(count);
            InputStr("Khoi tao vat pham thanh cong, nhan phim bat ky de quay lai: ");
            Program.StartGame();
        }

        public void ShowItems(List<Item> items)
        {
            Console.Clear();
            Console.WriteLine("============ Danh sach vat pham ============");
            for (int i = 0; i < items.Count; i++)
            {
                Console.Write($"{i + 1}: ");
                ShowItem(items[i]);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("0. Quay ve Main menu");
            Console.WriteLine("1. Nang cap level vat pham");
            Console.WriteLine("2. Nang cap pham chat vat pham");
            Console.WriteLine("---------------------------------------------");
            int input = InputInt("Nhap lua chon: ");

            if (input == 0)
                Program.StartGame();
            else if (input == 1)
            {
                int index = InputInt("Nhap vat pham muon nang cap: ") - 1;
                string select = UpgradeItemLevel(items, index);
                if (select.Equals("Y") || select.Equals("y"))
                {
                    Program.UpgradeItemDelegate(index);
                    Console.Write("Nang cap thanh cong, nhan phim bat ky de quay lai: ");
                    Console.ReadKey();
                    ShowItems(items);
                }
                else
                {
                    ShowItems(items);
                }
            }
            else if (input == 2)
            {
                int index1 = InputInt("Nhap vat pham thu nhat: ") - 1;
                int index2 = InputInt("Nhap vat pham thu hai: ") - 1;
                string select = MergeItems(items, index1, index2);
                if (select.Equals("Y") || select.Equals("y"))
                {
                    Program.MergeItemsDelegate(index1, index2);
                    Console.Write("Merge thanh cong, nhan phim bat ky de quay lai: ");
                    Console.ReadKey();
                    ShowItems(items);
                }
            }
        }

        public string MergeItems(List<Item> items, int index1, int index2)
        {
            Console.Clear();
            Console.WriteLine("Thong tin vat pham moi sau khi gop 2 vat pham: ");
            Console.WriteLine($"Type: {items[index1].type} \t Rarity: {(ItemRarity)((int)items[index1].rarity + 1)} " +
                $"\t Level: {items[index1].level}");
            string key = InputStr("Nhan Y/y de xac nhan Merge, N/n de quay lai: ");
            return key;
        }

        public string UpgradeItemLevel(List<Item> items, int index)
        {
            Console.Clear();
            Console.WriteLine("Thong tin vat pham sau khi nang cap: ");
            Console.WriteLine($"Type: {items[index].type} \t Rarity: {items[index].rarity} \t Level: {items[index].level + 1}");
            string key = InputStr("Nhan Y/y de xac nhan nang cap, N/n de quay lai: ");
            return key;
        }

        
        public void ShowItem(Item item)
        {
            Console.WriteLine($"Type: {item.type} \t Rarity: {item.rarity} \t Level: {item.level}");
        }

        public int InputInt(string message)
        {
            Console.Write(message);
            int key = int.Parse(Console.ReadLine());
            return key;
        }

        public string InputStr(string message)
        {
            Console.Write(message);
            string key = Console.ReadLine();
            return key;
        }
    }
}
