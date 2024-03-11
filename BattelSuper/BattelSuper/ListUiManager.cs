using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class ListUiManager
    {
        public List<Action> accountUiFeatures = null;
        public List<Action> listUiManager = null;
        public ListUiManager() 
        {
            accountUiFeatures = new List<Action>()
            {
                SignUp,
                SignIn
            };
            listUiManager = new List<Action>()
            {
                ShowInfoUser,
                GachaItem,
                CreateCharacter,
                ShowAllItem,
                ShowAllCharacter,
                BattelRoyal
            };
        }
        public void AccountUi()
        {
            Console.WriteLine("====Battel Super====");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1.Dang Ky");
            Console.WriteLine("2.Dang Nhap");
            Console.WriteLine("--------------------------");
            int key = InputInt("Chon Chuc Nang: ");

            accountUiFeatures[key -1]?.Invoke();
        }
        public void SignUp()
        {
            Console.Clear();
            Delegate.signUp();
            Console.ReadKey();
        }
        public void SignIn()
        {
            Console.Clear();
            Delegate.signIn();
            Console.ReadKey();
        }
        public void ShowInfoUser()
        {

        }
        public void GachaItem()
        {

        }
        public void CreateCharacter()
        {
            Console.Clear();
            Delegate.createCharacter();
            Console.ReadKey();
        }
        public void ShowAllItem()
        {

        }
        public void ShowAllCharacter()
        {
            Console.Clear();
            Delegate.showAllCharacter();  
            Console.ReadKey();
        }
        public void BattelRoyal()
        {

        }
        public int InputInt(string message)
        {
            Console.Write(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
