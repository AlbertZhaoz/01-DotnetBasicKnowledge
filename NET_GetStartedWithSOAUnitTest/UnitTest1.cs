using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NET_GetStartedWithSOAUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public WebReference_AlbertCalculate.AlbertCalculateWebServices webCalculate { get; set; } = null;
        [TestInitialize]
        public void InitAlbertWebService()
        {
            try
            {
                webCalculate = new WebReference_AlbertCalculate.AlbertCalculateWebServices();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void TestHelloWorld()
        {
            Assert.AreEqual(webCalculate.HelloWorld(),"Hello World");
        }

        [TestMethod]
        public void TestPrintAdd()
        {
            Assert.AreEqual(webCalculate.PrintAdd(1,2),3);
        }
    }
}
