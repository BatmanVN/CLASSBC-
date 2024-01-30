using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunTurnBase
{
    public static class GameHelper
    {
        public static void CharacterInfomation(Character character)
        {
            Console.WriteLine("====Thong tin Nhan Vat====");
            Console.WriteLine($"1.Character Name: " +character.Charactername);
            Console.WriteLine($"2.Health: "+character.Health);
            Console.WriteLine($"3.Attck Dame:"+character.atk);
        }
        public static int GetRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
