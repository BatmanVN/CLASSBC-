using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GachaLunar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> qualityItem = new List<int>();
            ShowMenu();
            Console.ReadKey();
        }
        public static int ShowMenu()
        {
            Console.WriteLine("1.Tao Item");
            Console.WriteLine("2.Hien thi tat ca Item");
            Console.WriteLine("3.Hien thi Info Item");
            Console.WriteLine("4.Thoat");
            int key = int.Parse(Console.ReadLine());
            Console.ReadKey();
            return key; 
        }

        public static void GameUI()
        {
            int key = ShowMenu();
            switch(key)
            {
                case 1:
                    ShowMenu();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        public static void CreatItem()
        {

        }
        public static void Gacha(Item[] items) 
        {
            Console.Clear();
            Console.WriteLine("1.Quay 1 lan\t\t\t 2.Quay 10 lan");
            int key = int.Parse(Console.ReadLine());
            if (key == 1)
            {
                
            }
            
        }
        public static void ShowAllItem(Item[] items)
        {
            Console.Clear();
            for (int i = 0;i<items.Length;i++)
            {
                for (int j = 0;j<items.Length;j++)
                {
                    int temp = i;
                    i = j;
                    j = temp;
                    Console.WriteLine($"{temp + 1}. {items[i].itemtype}");
                }
            }
        }

        public static void ShowAllItem()
        {

        }
        public static void AddtoArray(Item[] items, Item itemtoAdd)
        {
            for(int i = 0; i<items.Length;i++)
            {
                if (items[i] == null)
                {
                    items[i] = itemtoAdd;
                    break;
                }
            }
        }
    }
}
