using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryBook
{
    public class User
    {
        public DateTime birthDay { get; private set; }
        public string userName { get; private set; }
        public string passWord { get; private set; }
        public int cardNumber { get; private set; }
        public int baLance { get; private set; }
        public List<Libary> borrowedbooks;
        public User(string username, string password, DateTime dateTime, int balance, int cardNumber)
        {

            this.userName = username;
            this.passWord = password;
            this.birthDay = dateTime;
            this.baLance = balance;
            this.cardNumber = cardNumber;
        }
        public User()
        {
            borrowedbooks = new List<Libary>(5);
        }
    }
}
