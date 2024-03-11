using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class BooksManager
    {

        public List<Book> books = new List<Book>();



        public BooksManager()
        {
            Program.ShowBooks = ShowBooks;
        }

        private void ShowBooks(Action<Book> callback)
        {
            foreach (var book in books)
            {
                callback?.Invoke(book);
            }
        }
    }
}
