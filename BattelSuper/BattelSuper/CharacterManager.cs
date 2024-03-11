using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class CharacterManager
    {
        public List<Character> characterList;
        public CharacterManager()
        {
            characterList = new List<Character>();
            Delegate.createCharacter = CreateCharacter;
            Delegate.showAllCharacter = ShowAllCharacter;
        }
        private void CreateCharacter()
        {
            Console.Clear();
            Console.WriteLine("====Battel Super====");
            Console.WriteLine("--------------------------");
            string name = InputStr("Nhap ten nhan vat: ");
            int input = InputInt("Chon Class: ");
            ChoiceClass();
            switch (input)
            {
                case 1:
                    Console.Clear();
                    Tank tank = new Tank();
                    tank.itemused = new List<Item>(5);
                    Console.WriteLine("Ban da chon class Tank");
                    tank.Name = name;
                    characterList.Add(tank);
                    Console.WriteLine("Da tao nhan vat thanh cong\nAn bat ky de quay lai Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Program.Start();
                    break;
                case 2:
                    Console.Clear();
                    Assasin assasin = new Assasin();
                    assasin.itemused = new List<Item>(5);
                    Console.WriteLine("Ban da chon class Assasin");
                    assasin.Name = name;
                    characterList.Add(assasin);
                    Console.WriteLine("Da tao nhan vat thanh cong\nAn bat ky de quay lai Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Program.Start();
                    break;
                case 3:
                    Console.Clear();
                    Archer archer = new Archer();
                    archer.itemused = new List<Item>(5);
                    Console.WriteLine("Ban da chon class Archer");
                    archer.Name = name;
                    characterList.Add(archer);
                    Console.WriteLine("Da tao nhan vat thanh cong\nAn bat ky de quay lai Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Program.Start();
                    break;
                case 4:
                    Console.Clear();
                    StrongMan strongMan = new StrongMan();
                    strongMan.itemused = new List<Item>(5);
                    Console.WriteLine("Ban da chon class Strong Man");
                    strongMan.Name = name;
                    characterList.Add(strongMan);
                    Console.WriteLine("Da tao nhan vat thanh cong\nAn bat ky de quay lai Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Program.Start();
                    break;
                case 5:
                    Console.Clear();
                    Magican magican = new Magican();
                    magican.itemused = new List<Item>(5);
                    Console.WriteLine("Ban da chon class Magican");
                    magican.Name = name;
                    characterList.Add(magican);
                    Console.WriteLine("Da tao nhan vat thanh cong\nAn bat ky de quay lai Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Program.Start();
                    break;
                case 6:
                    Console.Clear();
                    Knight knight = new Knight();
                    knight.itemused = new List<Item>(5);
                    Console.WriteLine("Ban da chon class Knight");
                    knight.Name = name;
                    characterList.Add(knight);
                    Console.WriteLine("Da tao nhan vat thanh cong\nAn bat ky de quay lai Menu");
                    Console.ReadKey();
                    Console.Clear();
                    Program.Start();
                    break;
                default:
                    Console.WriteLine("Vui Long chon dung thu tu!");
                    CreateCharacter();
                    break;
            }
        }
        public void ShowAllCharacter()
        {
            Console.Clear();
            Console.WriteLine("====Battel Super====");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Danh sach nhan vat:");
            for (int i = 0; i < characterList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.Ten: {characterList[i].Name} \t Class: {characterList[i].characterType}");
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("0.Quay lai menu");
            int key = InputInt("Chon Nhan vat de xem chi tiet: ");
            if (key == 0)
                Program.Start();
            ShowInforCharacter(characterList[key - 1]);
        }
        public void ShowInforCharacter(Character character)
        {
            Console.Clear();
            Console.WriteLine("====Battel Super====");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"-Nhan vat: {character.Name}");
            Console.WriteLine($"-Class: {character.characterType}\n-Health: {character.Health}\n-PhyAtk: {character.PhyAtk}\n-SpdAtk: {character.SpdAtk}\n-MagicAtk: {character.magicAtk}");
            Console.WriteLine("--------------------------");
            Console.WriteLine("0.De quay lai Menu\n1.De quay lai All Character");
            int key;
            while(true)
            {
                string input = Console.ReadLine();
                if(!int.TryParse(input, out key) || key <0 || key>1)
                {
                    Console.WriteLine("Vui long nhap dung!");
                    ShowInforCharacter(character);
                    break;
                }
                else if(int.TryParse(input,out key) && key ==0)
                {
                    Program.Start();
                    break;
                }
                else if(int.TryParse(input, out key) && key == 1)
                {
                    ShowAllCharacter();
                    break;
                }
            }
        }
        public void ChoiceClass()
        {
            Console.WriteLine("1.Tank\n2.Assasin\n3.Archer\n4.StrongMan\n5.Magican\n6.Knight");
        }
        public int InputInt(string message)
        {
            Console.Write(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
        public string InputStr(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return input;
        }
    }
}
