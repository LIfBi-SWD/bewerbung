using Microsoft.VisualStudio.TestTools.UnitTesting;
using lifbi.sanduhr.logic;

namespace lifbi.sanduhr.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSanduhr()
        {
            Sanduhr sanduhr = new Sanduhr();
            var print = sanduhr.Print(1);

            Assert.AreEqual("*", print);    
        }
    }
}
