using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryBook
{
    public class Libary
    {
        public List<Libary> listBook;
        public int iD {  get; private set; }
        public int price { get; private set; }
        public string bookName { get; private set; }
        public Libary(string bookName, int Price) 
        {
           listBook = new List<Libary>();
           this.bookName = bookName;
           this.price = Price;
        }

    }
}
