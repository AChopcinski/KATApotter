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
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book1");
            //ACT
            Assert.AreEqual(2, sc.Cart.Count());
        }
        [TestMethod()]
        public void PriceOneBookEquals_Ten()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();

            //Act
            sc.AddItemsToCart("Book1");
            
            //assert
            Assert.AreEqual("$10.00", sc.TotalCost(sc.Cart));

        }
        [TestMethod()]
        public void PriceTwoSameBookEquals_Twenty()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();

            //Act
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book1");

            //assert
            Assert.AreEqual("$20.00", sc.TotalCost(sc.Cart));

        }
        [TestMethod()]
        public void PriceTwoDiffBookEquals_19()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();

            //Act
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book2");

            //assert
            Assert.AreEqual("$19.00", sc.TotalCost(sc.Cart));

        }
        [TestMethod()]
        public void PriceThreeBooksEquals_27()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();

            //Act
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book2");
            sc.AddItemsToCart("Book3");
            //assert
            Assert.AreEqual("$27.00", sc.TotalCost(sc.Cart));

        }
        [TestMethod()]
        public void PriceTwoDiffBooksThreeTotalEquals_29()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();
            //Act
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book2");
            sc.AddItemsToCart("Book1");
            //assert
            Assert.AreEqual("$29.00", sc.TotalCost(sc.Cart));
        }
        [TestMethod()]
        public void PriceFourDiffBooksEquals_32()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();
            //Act
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book2");
            sc.AddItemsToCart("Book3");
            sc.AddItemsToCart("Book4");
            //assert
            Assert.AreEqual("$32.00", sc.TotalCost(sc.Cart));
        }
        [TestMethod()]
        public void PriceTwoDiffBooks4TotalEquals_38()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();
            //Act
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book2");
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book2");
            //assert
            Assert.AreEqual("$38.00", sc.TotalCost(sc.Cart));
        }
        [TestMethod()]
        public void Price2DiffBooks5TotalEquals_48()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();
            //Act
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book2");
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book2");
            sc.AddItemsToCart("Book1");
            //assert
            Assert.AreEqual("$48.00", sc.TotalCost(sc.Cart));
        }
        [TestMethod()]
        public void Price5DiffBooks5TotalEquals_3750()
        {
            //Arrange
            ShoppingCart sc = new ShoppingCart();
            //Act
            sc.AddItemsToCart("Book1");
            sc.AddItemsToCart("Book2");
            sc.AddItemsToCart("Book3");
            sc.AddItemsToCart("Book4");
            sc.AddItemsToCart("Book5");
            //assert
            Assert.AreEqual("$37.50", sc.TotalCost(sc.Cart));
        }

    }
}