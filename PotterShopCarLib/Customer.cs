using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShopCarLib
{
    public class Customer
    {
        public void Buy(Book book)
        {
            if (this.BuyingBook == null)
            {
                this.BuyingBook = new List<Book>();
            }
            this.BuyingBook.Add(book);
        }

        public List<Book> BuyingBook { get; private set; }

        public void Buy(List<Book> books)
        {
            if (this.BuyingBook == null) {
                this.BuyingBook = new List<Book>();
            }
            this.BuyingBook.AddRange(books);
        }
    }
}
