using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunTurnBase
{
       public enum WeaponType
    {
        sniper,
        rifle
    }
    public class Weapon
    {
        public WeaponType weaponType;
        public float value { get; protected set; }

        public Weapon(float value, WeaponType weaponType)
        {
            this.value = value;
            this.weaponType = weaponType;
        }

        public virtual void Equip(Character targetEquip)
        {

        }

        public virtual void UnEquip(Character targetUnEquip)
        {

        }

        public void ShowInformation(Weapon weapon)
        {
            Console.Clear();
            Console.WriteLine("====Thong tin WEAPON====");
            Console.WriteLine($"Loai Weapon: {weaponType.ToString()}");
            Console.WriteLine($"Gia tri: {value.ToString()}");
            Console.WriteLine("========================");
            Console.WriteLine("1.Gan trang bi!");
            Console.WriteLine("2.Quay lai!");
            int key = int.Parse(Console.ReadLine());
            if(key == 1)
            {
                ShowEquipUI();
            }
            else
            {
               Program.ShowInformationWeapon();
            }
        }

        public void ShowEquipUI()
        {

        }

    }
}
