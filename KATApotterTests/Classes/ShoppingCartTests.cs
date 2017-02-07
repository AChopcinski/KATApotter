using Microsoft.VisualStudio.TestTools.UnitTesting;
using KATApotter.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATApotter.Classes.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void AddItemTest()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart(); 
            
            //Assert
            sc.AddItemsToCart("book1");
            sc.AddItemsToCart("book1");
            //ACT
            Assert.AreEqual(2, sc.Cart.Count());
        }
        [TestMethod()]
        public void PriceOneBookEquals_Ten()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();

            //Act
            sc.AddItemsToCart("book1");
            
            //assert
            Assert.AreEqual("$10.00", sc.TotalCost(sc.Cart));

        }
        [TestMethod()]
        public void PriceTwoSameBookEquals_Twenty()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();

            //Act
            sc.AddItemsToCart("book1");
            sc.AddItemsToCart("book1");

            //assert
            Assert.AreEqual("$20.00", sc.TotalCost(sc.Cart));

        }
        [TestMethod()]
        public void PriceTwoDiffBookEquals_19()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();

            //Act
            sc.AddItemsToCart("book1");
            sc.AddItemsToCart("book2");

            //assert
            Assert.AreEqual("$19.00", sc.TotalCost(sc.Cart));

        }
        [TestMethod()]
        public void PriceThreeBooksEquals_30()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();

            //Act
            sc.AddItemsToCart("book1");
            sc.AddItemsToCart("book2");

            //assert
            Assert.AreEqual("$19.00", sc.TotalCost(sc.Cart));

        }
    }
}