using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public delegate void CreateCharacter(); 
    public delegate void DeleteCharacter();
    public delegate void ShowAllCharacter();
    public delegate void SignUp();
    public delegate void SignIn();
    public class Delegate
    {
        public static CreateCharacter createCharacter;
        public static ShowAllCharacter showAllCharacter;
        public static SignUp signUp;
        public static SignIn signIn;
    }
}
