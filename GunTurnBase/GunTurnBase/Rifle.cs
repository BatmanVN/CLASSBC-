using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunTurnBase
{
    public class Rifle : Weapon
    {
        public float SpeedBullet;
        public Rifle(float value , WeaponType weaponType) : base (value , weaponType)
        {

        }

        public override void Equip(Character targetEquip)
        {
            
        }

        public override void UnEquip(Character targetUnEquip)
        {
            
        }
    }
}
