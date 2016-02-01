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

        [TestMethod]
        public void MostExpensiveProductInBasket()
        {
            Assert.AreEqual(150, IndicateMostExpensiveProductInBasket(new double[] { 150, 1, 100, 50 }));
        }

        [TestMethod]
        public void EliminateMosteExpensiveProductThatApeearsInTwoPositionsInBasket()
        {
            CollectionAssert.AreEqual(new double[] { 1, 100, 50 }, EliminateMostExpensiveProduct(new double[] { 1, 150, 150, 100, 50 }));
        }

        [TestMethod]
        public void EliminateMosteExpensiveProductFromFirstPositionInBasket()
        {
            CollectionAssert.AreEqual(new double[] { 1, 100, 50 }, EliminateMostExpensiveProduct(new double[] { 150, 1, 100, 50 }));
        }

        [TestMethod]
        public void EliminateMosteExpensiveProductFromLastPositionInBasket()
        {
            CollectionAssert.AreEqual(new double[] { 3, 1, 100 }, EliminateMostExpensiveProduct(new double[] { 3, 1, 100, 150 }));
        }

        [TestMethod]
        public void AddNewProductPriceInBasket()
        {
            CollectionAssert.AreEqual(new double[] { 3, 1, 100, 100 }, AddNewProductPrice(new double[] { 3, 1, 100 },100));
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

        public double IndicateMostExpensiveProductInBasket(double[] p)
        {
            double mostExpensivePrice = p[0];
            for (int i = 1; i < p.Length; i++)
                if (p[i] > mostExpensivePrice)
                    mostExpensivePrice = p[i];
            return mostExpensivePrice;
            
        }

        public double[] EliminateMostExpensiveProduct(double[] p)
        {
            double highestPrice;
            int counter = 0, index = 0;
            double[] newValuesArray = new double[p.Length];
            highestPrice = IndicateMostExpensiveProductInBasket(p);
                    
            for (int i = 0; i < p.Length; i++ )
                if (p[i] == highestPrice)
                    counter = counter + 1;
            Array.Resize<double>( ref newValuesArray, newValuesArray.Length - counter );
            
            for (int i = 0; i < p.Length; i++)
                if (p[i] != highestPrice)
                    newValuesArray[i - index] = p[i];
                else
                    index = index + 1;
            return newValuesArray;
        }

        public double[] AddNewProductPrice(double[] listOfPrices, double p)
        {
            double[] newListOfPrices = new double[listOfPrices.Length+1];
            for (int i = 0; i < newListOfPrices.Length; i++)
            {
                if (i == newListOfPrices.Length - 1)
                    newListOfPrices[i] = p;
                else
                newListOfPrices[i] = listOfPrices[i];
                
            }
            return newListOfPrices;
        }
    }
}
