using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentalSystem;

namespace VideoRentalSystemTests5
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Record obj = new Record();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Rental obj = new Rental(1,1,1,"30/09/2019","booked");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Customer obj = new Customer(1,"testing","64123456","nz");
        }

    }
}
