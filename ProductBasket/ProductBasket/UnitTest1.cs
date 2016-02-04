using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProductBasket
{
    [TestClass]
    public class UnitTest1
    {
        public struct product
        {
            public string name;
            public decimal price;

            public product(string name, decimal price)
            {
                this.name = name;
                this.price = price;
            }

        }

        [TestMethod]
        public void TotalPriceOfProductsInBasket()
        {
            product[] productList = {
                new product { name = "shoes", price = 150 },
                new product { name = "tshirt", price = 100 },
                new product { name = "shorts", price = 50 }
            };

            Assert.AreEqual(300, CalculateBasketTotalPrice(productList));
        }

        [TestMethod]
        public void CheapestProductInBasket()
        {
            product[] productList = { 
                new product { name = "shoes", price = 150},
                new product { name = "tshirt", price = 100},
                new product { name = "shorts", price = 50}
            };
            Assert.AreEqual("shorts", IndicateCheapestProductInBasket(productList));
        }

        [TestMethod]
        public void MostExpensiveProductInBasket()
        {
            product[] productList = 
            {
                new product { name = "shoes", price = 150},
                new product { name = "tshirt", price = 100},
                new product { name = "shorts", price = 50}

            };
            Assert.AreEqual(150, IndicateMostExpensiveProductInBasket(productList));
        }

        [TestMethod]
        public void EliminateMosteExpensiveProductThatApeearsInTwoPositionsInBasket()
        {
            product a = new product { name = "bag", price = 1};
            product b = new product { name = "shoes", price = 150 };
            product c = new product { name = "shoes", price = 150 };
            product d = new product { name = "tshirt", price = 100 };
            product e = new product { name = "shorts", price = 50 };
            product[] listProduct1 = new product[] { a, d, e };
            product[] listProduct2 = new product[] { a, b, c, d, e};
            CollectionAssert.AreEqual(listProduct1, EliminateMostExpensiveProduct(listProduct2));
        }

        [TestMethod]
        public void EliminateMosteExpensiveProductFromFirstPositionInBasket()
        {
            product a = new product { name = "shoes", price = 150 };
            product b = new product { name = "bag", price = 1 };
            product c = new product { name = "tshirt", price = 100 };
            product d = new product { name = "shorts", price = 50 };
            product[] listProduct1 = new product[] { b, c, d };
            product[] listProduct2 = new product[] { a, b, c, d };
            CollectionAssert.AreEqual(listProduct1, EliminateMostExpensiveProduct(listProduct2));
        }

        [TestMethod]
        public void EliminateMosteExpensiveProductFromLastPositionInBasket()
        {
            product a = new product { name = "shorts", price = 50 };
            product b = new product { name = "tshirt", price = 100 };
            product c = new product { name = "bag", price = 1 };
            product d = new product { name = "shoes", price = 150 };
            product[] listProduct1 = new product[] { a, b, c };
            product[] listProduct2 = new product[] { a, b, c, d };
            CollectionAssert.AreEqual(listProduct1, EliminateMostExpensiveProduct(listProduct2));
        }

        [TestMethod]
        public void AddNewProductPriceInBasket()
        {
            product a = new product { name = "shorts", price = 50 };
            product b = new product { name = "tshirt", price = 100 };
            product c = new product { name = "shoes", price = 150 };
            product d = new product { name = "bag", price = 1 };
            product[] productList1 = new product[] { a, b, c };
            product[] productList2 = new product[] { a, b, c, d };
            CollectionAssert.AreEqual(productList2, AddNewProductPrice(productList1, d));
        }

        [TestMethod]
        public void CalculateMediumProductPriceInBasket()
        {
            product a = new product { name = "shorts", price = 50 };
            product b = new product { name = "tshirt", price = 100 };
            product c = new product { name = "shoes", price = 150 };
            product[] productList1 = new product[] { a, b, c };
            Assert.AreEqual(100, CalculateMediumProductPrice(productList1));
        }

        public decimal CalculateBasketTotalPrice(product[] basket)
        {
            decimal totalPrice = 0;
            for (int i = 0; i < basket.Length; i++ )
                totalPrice = totalPrice + basket[i].price;
            return totalPrice;
        }

        public string IndicateCheapestProductInBasket(product[] basket)
        {
            product lowestPrice;
            lowestPrice.price = basket[0].price;
            lowestPrice.name = basket[0].name;
            for (int i = 1; i < basket.Length; i++)
                if (basket[i].price < lowestPrice.price)
                {
                    lowestPrice.price = basket[i].price;
                    lowestPrice.name = basket[i].name;
                }

            return lowestPrice.name;
        }

        public decimal IndicateMostExpensiveProductInBasket(product[] basket)
        {
            product mostExpensiveProduct = basket[0];
            for (int i = 1; i < basket.Length; i++)
                if (basket[i].price > mostExpensiveProduct.price)
                    mostExpensiveProduct = basket[i];
            return mostExpensiveProduct.price ;

        }

        public product[] EliminateMostExpensiveProduct(product[] basket)
        {
            decimal highestPrice; 
            int counter = 0, index = 0;
            product[] newBasketProducts = new product[basket.Length];
            highestPrice = IndicateMostExpensiveProductInBasket(basket);

            for (int i = 0; i < basket.Length; i++)
                if (basket[i].price == highestPrice)
                    counter = counter + 1;
            Array.Resize<product>(ref newBasketProducts, newBasketProducts.Length - counter);

            for (int i = 0; i < basket.Length; i++)
                if (basket[i].price != highestPrice)
                    newBasketProducts[i - index] = basket[i];
                else
                    index = index + 1;
            return newBasketProducts;
        }

        public product[] AddNewProductPrice(product[] basket, product p)
        {
            product[] newBasketProducts = new product[basket.Length + 1];
            for (int i = 0; i < newBasketProducts.Length; i++)
            {
                if (i == newBasketProducts.Length - 1)
                    newBasketProducts[i] = p;
                else
                    newBasketProducts[i] = basket[i];

            }
            return newBasketProducts;
        }

        public decimal CalculateMediumProductPrice(product[] basket)
        {
            decimal mediumPrice = 0;
            mediumPrice = CalculateBasketTotalPrice(basket) / basket.Length;
            return mediumPrice;
        }
    }
}
