using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATApotter.Classes
{
    public class ShoppingCart
    {
        private const double TWENTYFIVEPERCENTDISCOUNT = 37.50; //number of unique books * $10 (Price of Book) * (75%, because they get a 25% discount)
        private const double TWENTYPERCENTDISCOUNT = 32.00; //4 unique books, 20% off (40*.8)
        private const double TENPERCENTDISCOUNT = 27.00; // 3 unique books, 10% off each (30*.9)
        private const double FIVEPERCENTDISCOUNT = 19.00; // 2 unique books, 5% off each (20*.95)
        private const double NODISCOUNT = 10.00; // Full retail price per book
        int b1Count = 0;
        int b2Count = 0;
        int b3Count = 0;
        int b4Count = 0;
        int b5Count = 0;

        public int[] books = new int[5] { 0, 0, 0, 0, 0 };

        public Dictionary<string, int> bookDictionary = new Dictionary<string, int>(5);



        public List<string> Cart { get; set; } = new List<string>();

        public void AddItemsToCart(string item)
        {
            Cart.Add(item);
        }
        int uniqueBook;
        double totalCost;

        public string TotalCost(List<string> Cart)
        {
            BookSorter(Cart);
            while (books[0] > 0 || books[1] > 0 || books[2] > 0 || books[3] > 0 || books[4] > 0)
            {
                uniqueBook = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (books[i] >= 1)
                    {
                        uniqueBook++;
                        books[i]--;
                    }
                }
                if (uniqueBook == 5)
                {
                    totalCost += TWENTYFIVEPERCENTDISCOUNT;
                }
                else if (uniqueBook == 4)
                {
                    totalCost += TWENTYPERCENTDISCOUNT;
                }
                else if (uniqueBook == 3)
                {
                    totalCost += TENPERCENTDISCOUNT;
                }
                else if (uniqueBook == 2)
                {
                    totalCost += FIVEPERCENTDISCOUNT;
                }
                else
                {
                    totalCost += NODISCOUNT;
                }
            }
            return totalCost.ToString("C");
        }
        private void IncreaseCounters(bool increase)
        {
            if (increase)
            {
                b1Count++;
                b2Count++;
                b3Count++;
                b4Count++;
                b5Count++;
            }
            else
            {
                b1Count--;
                b2Count--;
                b3Count--;
                b4Count--;
                b5Count--;
            }
        }
        private bool AllCountersAreZero(bool test)
        {
            if (books[0] > 0 || books[1]>0 || books[2]>0 || books[3]>0 || books[4]>0) 
                {
                return true;
            }
            else
            { return false; }
        }
        private void BookSorter(List<string> Cart)
        {
            foreach (string item in Cart)
            {
                if (item == "Book1")
                {
                    b1Count++;
                    books[0]++;
                }
                if (item == "Book2")
                {
                    b2Count++;
                    books[1]++;
                }
                if (item == "Book3")
                {
                    b3Count++;
                    books[2]++;
                }
                if (item == "Book4")
                {
                    b4Count++;
                    books[3]++;
                }
                if (item == "Book5")
                {
                    b5Count++;
                    books[4]++;
                }
               
            }
        }
        //if (Cart.Count == 1)
        //{
        //    totalCost = 10;

        //}
        //else if (Cart.Count == 2 && Cart[0] != Cart[1])
        //{

        //    totalCost = 19;

        //}
        //else
        //{
        //    totalCost = 20;
        //}






    }

}
