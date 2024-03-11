using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class CharacterManager
    {
        public List<Character> CharacterList;
        public CharacterManager()
        {
            CharacterList = new List<Character>();
            DelegateEvent.createCharacter = CreatCharacter;
            DelegateEvent.showInfomationCharacter = ShowInfomationCharacter;
        }
        private void CreatCharacter()
        {
            Console.Clear();
            Console.WriteLine("Nhap ten Nhan vat:");
            string name = InputStr("Ten:");
            ChoiceClass();
            int key = 0;
            try
            {
                key = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                ChoiceClass();
            }
            switch (key)
            {
                case 1:
                    Console.Clear();
                    Archer archer = new Archer();
                    archer.characterName = name;
                    CharacterList.Add(archer);
                    Console.WriteLine("Da tao nhan vat thanh cong");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                case 2:
                    Console.Clear();
                    Assasin assasin = new Assasin();
                    assasin.characterName = name;
                    CharacterList.Add(assasin);
                    Console.WriteLine("Da tao nhan vat thanh cong");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                case 3:
                    Console.Clear();
                    Magician magician = new Magician();
                    magician.characterName = name;
                    CharacterList.Add(magician);
                    Console.WriteLine("Da tao nhan vat thanh cong");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                case 4:
                    Console.Clear();
                    Gunner gunner = new Gunner();
                    gunner.characterName = name;
                    CharacterList.Add(gunner);
                    Console.WriteLine("Da tao nhan vat thanh cong");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                case 5:
                    Console.Clear();
                    Tanker tanker = new Tanker();
                    tanker.characterName = name;
                    CharacterList.Add(tanker);
                    Console.WriteLine("Da tao nhan vat thanh cong");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                default:
                    Console.WriteLine("Vui Long Nhap Dung!");
                    CreatCharacter();
                    break;
            }
        }
        public int ShowAllCharacter()
        {
            Console.Clear();
            Console.WriteLine("====Danh Sach Nhan Vat====");
            foreach (Character character in CharacterList)
            {
                Console.WriteLine($"Nhan vat: {character.characterName}");
            }
            Console.WriteLine("---------------------------------------");
            int key = InputInt("Chon nhan vat de xem thong tin chi tiet:\n0.De quay lai Menu") -1;
            if( key == -1 )
            {
                Program.StartGame();
            }
            return key;
        }
        public void ShowInfomationCharacter(Character character)
        {
            Console.Clear();
            Console.WriteLine($"Nhan vat: {character.characterName}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"-Ten: {character.characterName} \n-Nghe Nghiep: {character.characterType}");
            Console.WriteLine($"-Chi so Nhan Vat: \n\t+Health: {character.Health}\n\t+SpeedAtk: " +
                $"{character.SpeedAtk}\n\t+PhysicalAtk: {character.PhysicalAtk}\n\t+MagicAtk: {character.MagicAtk}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Nhan bat ky de quay lai Danh sach Nhan vat");
            Console.ReadKey();
            Console.Clear();
            ShowInfomationCharacter(character);
        }
        //public void ShowInfomationCharacter()
        //{
        //    //int i = 0;
        //        int select = ShowAllCharacter();
        //        Console.Clear();
        //        Console.WriteLine($"Nhan vat: {CharacterList[select].characterName}");
        //        Console.WriteLine("---------------------------------------------------------");
        //        Console.WriteLine($"-Ten: {CharacterList[select].characterName} \n-Nghe Nghiep: {CharacterList[select].characterType}");
        //        Console.WriteLine($"-Chi so Nhan Vat: \n\t+Health: {CharacterList[select].Health}\n\t+SpeedAtk: " +
        //            $"{CharacterList[select].SpeedAtk}\n\t+PhysicalAtk: {CharacterList[select].PhysicalAtk}\n\t+MagicAtk: {CharacterList[select].MagicAtk}");
        //        Console.WriteLine("---------------------------------------------------------");
        //        Console.WriteLine("Nhan bat ky de quay lai Danh sach Nhan vat");
        //        Console.ReadKey();
        //        Console.Clear();
        //    ShowInfomationCharacter();
        //}
        public void ChoiceClass()
        {
            Console.WriteLine("1.Archer\n2.Assasin\n3.Magician\n4.Gunner\n5.Tanker");
        }
        public string InputStr(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        public int InputInt(string message)
        {
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
