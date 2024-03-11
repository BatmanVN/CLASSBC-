using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class User
    {
        public string userName;

        public string password;

        public List<Book> bookBorrow { get; private set; }



        public User()
        {
            
        }

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            bookBorrow = new List<Book>();
        }
    }
}
