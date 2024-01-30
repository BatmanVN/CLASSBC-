using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunTurnBase
{
    internal class Program
    {
        public static int[] configEquipmentValue = null;
        public static Weapon[] weapons;
        public static Character[] characters;
        public static Player1 player1;
        public static Player2 player2;
        public static Sniper sniper;
        public static Rifle rifle;
        static void Main(string[] args)
        {
            weapons = new Weapon[2];
            configEquipmentValue = new int[2] { 15, 20 };
            Function();

            Console.ReadKey();
        }

        public static int ShowGameMenu()
        {
            Console.Clear();
            Console.WriteLine("====WELCOME TO GAME DC====");
            Console.WriteLine("1.Create Heroes.");
            Console.WriteLine("2.Show Information Of Heroes.");
            Console.WriteLine("3.Create Weapon.");
            Console.WriteLine("4.Show Information Of Weapon");
            Console.WriteLine("5.Battel/Fight");
            Console.WriteLine("6.!!! EXIT !!!");
            int key = int.Parse(Console.ReadLine());
            return key;
        }

        public static void Function()
        {
            int key = ShowGameMenu();
            switch (key)
            {
                case 1:
                    CreateCharacter();
                    break;
                case 2:
                    ShowInformationHeroes();
                    break;
                case 3:
                    CreaterWeapon();
                    break;
                case 4:
                    ShowInformationWeapon();
                    break;
                case 5:
                    Battel(player1, player2);
                    break;
                case 6:
                    Console.WriteLine("CHAO TAM BIET QUY KHACh!");
                    return;
            }
            Console.ReadKey();
        }

        public static void CreateCharacter()
        {
            Console.Clear();
            Console.WriteLine("Nhap ten nhan vat 1 muon tao:");
            player1 = new Player1();
            player1.Charactername = Console.ReadLine();
            GameHelper.CharacterInfomation(player1);

            Console.WriteLine();

            Console.WriteLine("Nhap ten nhan vat 2 muon tao:");
            player2 = new Player2();
            player2.Charactername = Console.ReadLine();
            GameHelper.CharacterInfomation(player2);
            characters = new Character[] {player1 , player2};

            Console.WriteLine("Press Any key to back Menu...");
            Console.ReadKey();
            ShowGameMenu();
        }

        public static void CreaterWeapon()
        {
            for(int i = 0; i < weapons.Length; i++)
            {
                WeaponType weaponType = (WeaponType)GameHelper.GetRandom(0,2);
                Weapon newWeapon = null;
                switch(weaponType)
                {
                    case WeaponType.sniper:
                        newWeapon = new Sniper(configEquipmentValue[(int)weaponType], weaponType);
                        break;
                    case WeaponType.rifle:
                        newWeapon = new Rifle(configEquipmentValue[(int)weaponType], weaponType);
                        break;
                }
                weapons[i] = newWeapon;
            }
            weapons = new Weapon[2] { sniper, rifle };
            Console.WriteLine("Success Create Weapon or Press any Key to back Menu...");
            Console.ReadKey();
            ShowGameMenu();
        }

        public static void ShowInformationHeroes()
        {
            for(int i=0; i<characters.Length;i++)
            {
                Console.Clear();
                if (characters[i] != null)
                {
                    Console.WriteLine($"{i + 1}.{characters[i].Charactername}");
                    GameHelper.CharacterInfomation(characters[i]);
                }
            }
            Console.WriteLine("Press Any Key to Back Menu...");
            Console.ReadKey();
            ShowGameMenu();
        }

        public static void ShowInformationWeapon()
        {
            for(int i=0; i<weapons.Length;i++)
            {
                if (weapons[i] != null)
                {
                    Console.WriteLine($"{i + 1}.{weapons[i].weaponType}");
                    
                }
            }
        }

        public static void Battel(Character player1, Character player2)
        {
            
        }
    }
}
