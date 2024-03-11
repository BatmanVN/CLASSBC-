using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class User
    {
        public string username {  get;protected set; }
        public DateTime birthdate { get;protected set; }
        public string userid { get;protected set; }
        public int balance { get;protected set; }
        public List<Book> books; 

        public User(string username, DateTime birthdate, string userid, int balance)
        {
            this.username = username;
            this.birthdate = birthdate;
            this.userid = userid;
            this.balance = balance;
            this.books = new List<Book>();
        }
    }
}
