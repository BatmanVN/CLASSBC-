using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GachaItem
{
    public class CharacterManager
    {

        public Character character = null;
        public CharacterManager()
        {
            character = new Character();
            Program.character = CreatCharacter;
            Program.fullSlot = fullslot;
            Program.equiqItem = EquiqItem;
            Program.unequiqItem = UnequipMent;
        }
        private void CreatCharacter()
        {
            Console.Clear();
            //Character character = new Character();
            //Character.Add(character);
            Console.WriteLine("Tao ten nhan vat");
            string name = InputStr("Name: ");
            Console.WriteLine("Nhan bat ky de tiep tuc tao nhan vat");
            Console.ReadKey();
            Console.Clear();
        label:
            Console.WriteLine("Chon Nghe Nghiep Nhan Vat");
            Console.WriteLine("1.Tank\n2.Fighter\n3.Assasin\n4.Range\n5.Support");
            Console.Write("Lua chon cua ban: ");
            int select = 0;
            try
            {
                select = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Vui long nhap dung ky tu");
                CreatCharacter();
            }
            switch (select)
            {
                case 1:
                    Console.Clear();
                    character.itemuse = new List<Item>(4);
                    character.characterType = (CharacterType)0;
                    character.characterName = name;
                    character.physicalAtk = GameHelper.GetRandomValue(30, 40);
                    character.magicAtk = 0;
                    character.health = GameHelper.GetRandomValue(180, 200);
                    character.atkSpeed = GameHelper.GetRandomValue(2, 5);
                    Console.WriteLine("Successful character creation");
                    Console.WriteLine("Nhan vat cua ban");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine($"-Ten: {character.characterName} \n-Nghe Nghiep: {character.characterType}");
                    Console.WriteLine($"-Chi so Nhan Vat: \n\t+Physical Atk: {character.PhysicalAtk}\n\t+Magic Atk: " +
                        $"{character.MagicAtk}\n\t+Health: {character.Health}\n\t+Atk Speed: {character.AtkSpeed}");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Nhan bat ky de quay lai menu");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                case 2:
                    Console.Clear();
                    character.itemuse = new List<Item>(4);
                    character.characterType = (CharacterType)1;
                    character.characterName = name;
                    character.physicalAtk = GameHelper.GetRandomValue(20, 45);
                    character.magicAtk = 0;
                    character.health = GameHelper.GetRandomValue(140, 150);
                    character.atkSpeed = GameHelper.GetRandomValue(4, 7);
                    Console.WriteLine("Successful character creation");
                    Console.WriteLine("-Nhan vat cua ban:");
                    Console.WriteLine($"-Ten: {character.characterName} \n-Nghe Nghiep: {character.characterType}");
                    Console.WriteLine($"-Chi so Nhan Vat: \n\t+Physical Atk: {character.PhysicalAtk}\n\t+Magic Atk: " +
                        $"{character.MagicAtk}\n\t+Health: {character.Health}\n\t+Atk Speed: {character.AtkSpeed}");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Nhan bat ky de quay lai menu");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                case 3:
                    Console.Clear();
                    character.itemuse = new List<Item>(4);
                    character.characterType = (CharacterType)2;
                    character.characterName = name;
                    character.physicalAtk = GameHelper.GetRandomValue(60, 70);
                    character.magicAtk = 0;
                    character.health = GameHelper.GetRandomValue(100, 110);
                    character.atkSpeed = GameHelper.GetRandomValue(3, 6);
                    Console.WriteLine("Successful character creation");
                    Console.WriteLine("-Nhan vat cua ban:");
                    Console.WriteLine($"-Ten: {character.characterName} \n-Nghe Nghiep: {character.characterType}");
                    Console.WriteLine($"-Chi so Nhan Vat: \n\t+Physical Atk: {character.PhysicalAtk}\n\t+Magic Atk: " +
                        $"{character.MagicAtk}\n\t+Health: {character.Health}\n\t+Atk Speed: {character.AtkSpeed}");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Nhan bat ky de quay lai menu");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                case 4:
                    Console.Clear();
                    character.itemuse = new List<Item>(4);
                    character.characterType = (CharacterType)3;
                    character.characterName = name;
                    character.physicalAtk = GameHelper.GetRandomValue(50, 60);
                    character.magicAtk = 0;
                    character.health = GameHelper.GetRandomValue(100, 120);
                    character.atkSpeed = GameHelper.GetRandomValue(8, 10);
                    Console.WriteLine("Successful character creation");
                    Console.WriteLine("-Nhan vat cua ban:");
                    Console.WriteLine($"-Ten: {character.characterName} \n-Nghe Nghiep: {character.characterType}");
                    Console.WriteLine($"-Chi so Nhan Vat: \n\t+Physical Atk: {character.PhysicalAtk}\n\t+Magic Atk: " +
                        $"{character.MagicAtk}\n\t+Health: {character.Health}\n\t+Atk Speed: {character.AtkSpeed}");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Nhan bat ky de quay lai menu");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                case 5:
                    Console.Clear();
                    character.itemuse = new List<Item>(4);
                    character.characterType = (CharacterType)4;
                    character.characterName = name;
                    character.physicalAtk = 0;
                    character.magicAtk = GameHelper.GetRandomValue(30, 50);
                    character.health = GameHelper.GetRandomValue(120, 140);
                    character.atkSpeed = GameHelper.GetRandomValue(2, 5);
                    Console.WriteLine("Successful character creation");
                    Console.WriteLine("-Nhan vat cua ban:");
                    Console.WriteLine($"-Ten: {character.characterName} \n-Nghe Nghiep: {character.characterType}");
                    Console.WriteLine($"-Chi so Nhan Vat: \n\t+Physical Atk: {character.PhysicalAtk}\n\t+Magic Atk: " +
                        $"{character.MagicAtk}\n\t+Health: {character.Health}\n\t+Atk Speed: {character.AtkSpeed}");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Nhan bat ky de quay lai menu");
                    Console.ReadKey();
                    Program.StartGame();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Vui long nhap dung");
                    goto label;
            }
        }
        private void EquiqItem(int index, List<Item> itemss, Character character)
        {
            bool fullslot = true;
            for(int i = 0; i < character.itemuse.Count; i++)
            {
                //Item newitem = new Item(character.itemuse[i].itemType, character.itemuse[i].rarity, character.itemuse[i].level);
                if (character.itemuse[i] != null)
                    continue;
                    character.itemuse[i] = itemss[index];
                    itemss.Remove(itemss[index]);
                    fullslot = false;
                    break;
            }
            if(fullslot)
            {
                Console.WriteLine("Da full slot!");
            }
        }
        private void UnequipMent(int index, List<Item> itemss, Character character)
        {
            for (int i = 0; i < character.itemuse.Count; i++)
            {
                if (character.itemuse[i] == null)
                {
                    itemss.Add(character.itemuse[index]);
                    character.itemuse.Remove(character.itemuse[index]);
                    break;
                }
            }
        }
        private bool fullslot(Character character)
        {
            if(character.itemuse.Count <= 4)
                return true;
            else
                return false;
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
