using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GachaItem
{
    public class UIManager
    {
        public UIManager() 
        {
            Program.showmenu = ShowMenu;
        }
        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=====Be.Be Game=====");
            Console.WriteLine("--------------------");
            Console.WriteLine("1.Tao Nhan Vat");
            Console.WriteLine("2.Hien Thi Nhan vat");   
            Console.WriteLine("3.Gacha");
            Console.WriteLine("4.Hien Thi Kho Do");
            Console.WriteLine("5.Nang cap level");
            Console.WriteLine("6.Merge Vat Pham");
            Console.WriteLine("--------------------");
            int select = InputInt("Nhap lua chon:");
            return select;
        }
        public void CreatHero()
        {
            Program.character();
        }
        public void ShowInfoHero(Character characters)
        {
            Console.Clear();
            Console.WriteLine("====Thong tin nhan vat====");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Ten: {characters.characterName}\t Type: {characters.characterType}\tPhysicalATK: {characters.PhysicalAtk}\tMagicAtk: {characters.MagicAtk}" +
                        $"\tHealth: {characters.Health}\tAtkSpeed: {characters.AtkSpeed}");
            foreach (var itemuse in characters.itemuse)
            {
                Console.WriteLine($"Da lap trang bi: {itemuse}");
            }
            Console.WriteLine("Nhan bat ky de quay lai menu");
            Console.ReadKey();
            Program.StartGame();
        }
        //public void EquipItem(List<Item> items)
        //{
        //    Console.Clear();
        //    int index = InputInt("Nhap vat pham muon trang bi: ") - 1;
        //    string key = AfterEquip(items, index);
        //    Program.equiqItem(index,items);
        //    Console.WriteLine("Lap vat pham thanh cong, nhan bat ky de quay lai: ");
        //    ShowAllItem(items);
        //}
        //public void UnEquiqItem(List<Item> items)
        //{
        //    Console.Clear();
        //    int index = InputInt("Nhap vat pham muon trang bi: ") - 1;
        //    string key = AfterUnequip(items, index);
        //    Program.unequiqItem(index, items);
        //    Console.WriteLine("Lap vat pham thanh cong, nhan bat ky de quay lai: ");
        //    ShowAllItem(items);
        //}
        public void Roll()
        {
            Program.gacha();
        }
        //public void ShowItem(List<Item> items)
        //{
        //    Console.Clear();
        //    Console.WriteLine("====Kho Do====");
        //    Console.WriteLine("--------------------------");
        //    for (int i = 0; i < items.Count; i++)
        //    {
        //        if (items[i] != null)
        //        {
        //            Console.WriteLine($"{i + 1}.{items[i].itemType} \t {items[i].rarity} \t {items[i].level}");
        //        }
        //    }
        //}
        public void ShowUiItem()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("0.Quay lai Menu");
            Console.WriteLine("1.Nang cap Level");
            Console.WriteLine("2.Nang cap pham chat");
            Console.WriteLine("3.Xoa vat pham");
            Console.WriteLine("4.Trang bi vat pham");
        }
        public void ShowAllItem(List<Item> items, Character character)
        {
            Console.Clear();
            Console.WriteLine("====Kho Do====");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] != null)
                {
                    Console.WriteLine($"{i + 1}.{items[i].itemType} \t {items[i].rarity} \t {items[i].level}");
                }
            }
            ShowUiItem();
            Console.WriteLine("----------------------------");
            int key = InputInt("Nhap lua chon:");
            if (key == 0)
            {
                Program.StartGame();
            }
            else if (key == 1)
            {
                int index = InputInt("Nhap vat pham ban muon nang LV:") - 1;
                string select = AfterUpgrade(items, index);
                if (select == "y" || select == "Y")
                {
                    Program.upgradeLV(index, character);
                    Console.WriteLine("Nang cap thanh cong, nhan bat ky de quay lai");
                    Console.ReadKey();
                    ShowAllItem(items, character);
                }
                else
                {
                    ShowAllItem(items,character);
                }
            }
            else if (key == 2)
            {
                int index1 = InputInt("Nhap vat pham 1 ban muon Merge:") - 1;
                int index2 = InputInt("Nhap vat pham 2 ban muon Merge:") - 1;
                string select = AfterMerger(items, index1, index2);
                if (select == "y" || select == "Y")
                {
                    Program.mergerItem(index1, index2, character);
                    Console.WriteLine("Nang cap thanh cong, nhan bat ky de quay lai");
                    Console.ReadKey();
                    ShowAllItem(items,character);
                }
                else
                {
                    ShowAllItem(items, character);
                }
            }
            else if (key == 3)
            {
                int select = InputInt("Nhap vat pham muon xoa: ") - 1;
                string choice = InputStr("Nhan Y/y de xac nhan, Nhan N/n de quay lai:");
                if (choice == "y" || choice == "Y")
                {
                    Program.deleteitem(select);
                    Console.WriteLine("Da xoa vat pham thanh cong\nNhan bat ky de quay lai");
                    Console.ReadKey();
                    ShowAllItem(items,character);
                }
                else
                {
                    ShowAllItem(items, character);
                }
            }
            else if (key == 4)
            {
                int index = InputInt("Nhap vat pham muon trang bi: ") - 1;
                string index3 = AfterEquip(items, index);
                if (index3 == "Y" || index3 == "y")
                {
                    Console.WriteLine($"Gan len Character: {character.characterName}");
                    if(character == null)
                    {
                        return;
                    }
                    Program.equiqItem(index, items, character);
                    Console.WriteLine($"Lap vat pham thanh cong: {items[index].itemType}.{items[index].rarity}");
                    Console.WriteLine("Nhan bat ky de quay lai");
                    Console.ReadKey();
                    ShowAllItem(items, character);
                }
                else
                {
                    ShowAllItem(items,character);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Vui Long Nhap Dung");
                ShowAllItem(items, character);
            }
        }
        public string AfterEquip(List<Item> items, int index3)
        {
            Console.Clear();
            Console.WriteLine($"Ban muon lap vat pham: {items[index3].itemType}");
            string key = InputStr("Nhan Y/y de xac nhan, N/n de quay lai:");
            return key;
        }
        public string AfterUnequip(List<Item> items, int index)
        {
            Console.Clear();
            Console.WriteLine($"Ban muon thao Item: {items[index].itemType}");
            string key = InputStr("Nhan Y/y de xac nhan, N/n de quay lai:");
            return key;
        }
        public void UpLevel(List<Item> items, Character character)
        {
            Console.Clear();
            Console.WriteLine("\t====Kho Do====");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] != null)
                {
                    Console.WriteLine($"{i + 1}.{items[i].itemType} \t {items[i].rarity} \t {items[i].level}");
                }
            }
            Console.WriteLine("------------------------------------------");
            int index = InputInt("Nhap vat pham ban muon nang LV:") - 1;
            string select = AfterUpgrade(items, index);
            Program.upgradeLV(index,character);
            Console.WriteLine("Nang cap thanh cong, nhan bat ky de quay lai");
            Console.ReadKey();
            ShowAllItem(items, character);
        }
        public void UpRarity(List<Item> items, Character character)
        {
            Console.Clear();
            Console.WriteLine("\t\t====Kho Do====");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] != null)
                {
                    Console.WriteLine($"{i + 1}.{items[i].itemType} \t {items[i].rarity} \t {items[i].level}");
                }
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Lua chon vat pham muon Merge");
            int index1 = InputInt("Nhap vat pham 1:") - 1;
            int index2 = InputInt("Nhap vat pham 2:") - 1;
            string select = AfterMerger(items, index1, index2);
            Program.mergerItem(index1, index2,character);
            Console.WriteLine("Nang cap thanh cong, nhan bat ky de quay lai");
            Console.ReadKey();
            ShowAllItem(items,character);
        }
        public string AfterUpgrade(List<Item>items, int index)
        {
            Console.Clear();
            Console.WriteLine($"Vat pham sau khi nang cap:\n{items[index].itemType} \t {items[index].rarity} \t {items[index].level + 1}");
            string key = InputStr("Nhan Y/y de xac nhan, Nhan N/n de quay lai:");
            return key;
        }
        public string AfterMerger(List<Item>items, int index1, int index2) 
        {
            Console.Clear();
            Console.WriteLine($"Vat pham sau khi Merger:\n {items[index1].itemType} \t {(Rarity)((int)items[index1].rarity + 1)} \t {items[index1].level}");
            string key = InputStr("Nhan Y/y de xac nhan, Nhan N/n de quay lai:");
            return key;
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
