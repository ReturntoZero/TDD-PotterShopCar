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
            
        }

        public List<Book> BuyingBook { get; set; }

        public void Buy(List<Book> books)
        {
            throw new NotImplementedException();
        }
    }
}
