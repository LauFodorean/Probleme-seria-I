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

        [TestMethod]
        public void CheapestProductInBasket()
        {
            Assert.AreEqual(1, IndicateCheapestProductInBasket(new double[] { 150, 1, 100, 50 }));
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

        public double IndicateCheapestProductInBasket(double[] p)
        {
            double lowestPrice = p[0];
            for (int i = 1; i < p.Length; i++)
                if (p[i] < lowestPrice)
                    lowestPrice = p[i];
            return lowestPrice;
        }

    }
}
