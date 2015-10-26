using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PotterShopCarLib;

namespace PotterShopCar.Tests
{
    [TestClass]
    public class BuyinyPotterBookTest
    {
        [TestMethod]
        public void Test_Customer_Buy_First_Episode_of_Potter_Book()
        {
            //Arrange
            int expect = 100;
            Customer customer = new Customer();
            Book book = new Book();
            customer.Buy(book);

            //Act
            Employee employee = new Employee();
            int actual = employee.GetPrice(customer.BuyingBook);

            //Assert
            Assert.AreEqual(expect, actual);
        }




    }

       
}
