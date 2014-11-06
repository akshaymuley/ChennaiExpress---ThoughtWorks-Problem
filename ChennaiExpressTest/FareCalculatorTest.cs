using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chennai_Express;

namespace ChennaiExpressTest
{
    [TestClass]
    public class FareCalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Ticket ticket = new Ticket("Station 1", "Station 11", 24, 20);
            ITrain chennaiExpress = new ChennaiExpress();
            IFareCalculator fareCalculator = new FareCalculator(chennaiExpress);
            
            Assert.AreEqual(15, fareCalculator.GetFare(ticket));
        }
    }
}
