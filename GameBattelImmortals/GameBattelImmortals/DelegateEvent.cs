using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBattelImmortals
{
    public class DelegateEvent
    {
        public delegate void CreateCharacter();
        public delegate void ShowInfomationCharacter(Character character);

        public static CreateCharacter createCharacter;
        public static ShowInfomationCharacter showInfomationCharacter;
    }
}
