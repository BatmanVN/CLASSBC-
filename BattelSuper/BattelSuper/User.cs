using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelSuper
{
    public class User
    {
        public string userName;
        public string passWord;
        public User() 
        {

        }
        public User(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }
    }
}
