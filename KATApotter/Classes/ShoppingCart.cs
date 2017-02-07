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
            for (int i = 0; i < 4; i++)
            {
                if (books[i] >= 1)
                {
                    uniqueBook++;
                    books[i]--;
                }
            }
            //if (
            //    b1Count >= 1
            //    && b2Count >= 1
            //    && b3Count >= 1
            //    && b4Count >= 1
            //    && b5Count >= 1
            //    )
            //{
            //    IncreaseCounters(false);
            //    totalCost += TWENTYFIVEPERCENTDISCOUNT;
            //}
            if (

                )
            return totalCost.ToString("C");

        }
        private void IncreaseCounters(bool increase )
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

        private void BookSorter(List<string> Cart)
        {
            foreach (string item in Cart)
            {
                if (item == "Book1")
                {
                    books[0]++;
                }
                if (item == "Book2")
                {
                    books[1]++;
                }
                if (item == "Book3")
                {
                    books[2]++;
                }
                if (item == "Book4")
                {
                    books[3]++;
                }
                else
                {
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
