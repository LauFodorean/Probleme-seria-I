using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProductBasket
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TotalPriceOfProductsInBasket()
        {
            Assert.AreEqual(300, CalculateBasketTotalPrice(new double[] {150, 100, 50}));
        }

        //struct product
        //{
        //    public string name;
        //    public double price;
        //}

        

        public double CalculateBasketTotalPrice(double[] p)
        {
            double totalPrice = 0;
            for (int i = 0; i < p.Length; i++)
                totalPrice = totalPrice + (double)p[i];
            return totalPrice;
        }
    }
}
