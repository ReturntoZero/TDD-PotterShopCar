using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShopCarLib
{
    public class Employee
    {

        int discountStatus = 0;

        public double GetPrice(List<Book> list)
        {

            double total = 0;
            for (int bookIndex = 0; bookIndex < list.Count; bookIndex++)
            {
                if (bookIndex > 0) {
                    if (list[bookIndex].episode != list[bookIndex - 1].episode) {
                        discountStatus = 1;
                    } 
                }
                total += list[bookIndex].price;
            }

            if (discountStatus == 1) {
                total = total - (total * 0.05);
            }
            return total;
        }
    }
}
