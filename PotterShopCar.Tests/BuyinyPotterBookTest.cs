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
        public void Test_Customer_Buy_First_Episode_of_Potter_Book_The_Price_Should_be_100()
        {
            //Arrange
            double expect = 100;
            Customer customer = new Customer();
            Book book = GetSingleEpisode();
            customer.Buy(book);

            //Act
            Employee employee = new Employee();
            double actual = employee.GetPrice(customer.BuyingBook);

            //Assert
            Assert.AreEqual(expect, actual);
        }

        private static Book GetSingleEpisode()
        {
            Book book = new Book();
            book.price = 100;
            book.Name = "Potter 1";
            book.episode = 1;
            return book;
        }

        [TestMethod]
        public void Test_Customer_Buy_First_and_Second_Episode_of_Potter_Price_Should_be_190()
        {
            //Arrange
            double expect = 190;
            Customer customer = new Customer();
            List<Book> books = GetTwoDifferentEpisode();
            customer.Buy(books);

            //Act
            Employee employee = new Employee();
            double actual = employee.GetPrice(customer.BuyingBook);

            //Assert
            Assert.AreEqual(expect, actual);
        }

        private static List<Book> GetTwoDifferentEpisode()
        {
            Book book = new Book();
            book.price = 100;
            book.Name = "Potter 1";
            book.episode = 1;
            Book book2 = new Book();
            book2.price = 100;
            book2.Name = "Potter 2";
            book2.episode = 2;
            List<Book> books = new List<Book>();
            books.Add(book);
            books.Add(book2);
            return books;
        }




    }

       
}
