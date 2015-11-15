using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditBancar
{
    [TestClass]
    public class Credit
    {
        [TestMethod]
        public void Rate()
        {
            decimal BankRate = FirstBankRate(40000.00m,20.00m,7.57m);
            Assert.AreEqual(40000.00m / (20.00m *12)*(1+(7.57m/100)), BankRate);

        }

        public decimal FirstBankRate(decimal amount, decimal period, decimal percent)
        {
            decimal FirstRate;
            FirstRate = amount / (period * 12) * (1 + (percent / 100));
            return FirstRate;
                        
        }

        [TestMethod]
        public void AssignedMonth()
        {
            int Month = TheAssignedMonth(4, 3);
            Assert.AreEqual(39,Month);

        }

        public int TheAssignedMonth(int year, int month)
        {
            int TheMonth = (year-1) * 12 + month;
            return TheMonth;
        }

        [TestMethod]
        public void RateAssignedMonth()
        {
            decimal Rate = TheAssignedMonthRate(40000.00m,20,7.57m,1);
            Assert.AreEqual(178.4797m, Rate);

        }

        public decimal TheAssignedMonthRate(decimal credit, int period, decimal percent, int month)
        {
            decimal ExpectedRate=0.00m;
            for (int i = 1; i <= month; i++)
            {
                decimal rate = credit / (period * 12) * (1 + (percent / 100));
                credit = credit - rate;
                if (i == month)
                    ExpectedRate = rate;
            }
            return ExpectedRate;
        }

        //[TestMethod]
        //public void RandomRate()
        //{
        //    decimal BankRate = RandomBankRate(40000.00m, 20.00m,1.00m,3.00m, 7.57m);
        //    Assert.AreEqual(177.67m, BankRate);
        
        //}
                      
        //public decimal RandomBankRate(decimal amount, decimal period, decimal year, decimal month, decimal percent)
        //{
        //    decimal RandomRate=0.00m;
        //    if (year == 1)
        //        for (int i = 1; i <= month; i++)
        //        {
        //            decimal rate = amount / (period * 12) * (1 + (percent / 100));
        //            amount =amount - rate;
                                        
        //            if (i == month)
        //                RandomRate = rate;
                    
        //        }
        //    else
        //    {
        //        decimal RequestedMonth = (year*12)+month;
        //        for (int i = 1; i <= RequestedMonth; i++)
        //        {
        //            decimal rate = amount / (period * 12) * (1 + (percent / 100));
        //            amount = amount - rate;
                                        
        //            if (i == RequestedMonth)
        //                RandomRate = rate;
        //        }
        //    }
        //    return RandomRate;
            
        //}


    }
}
