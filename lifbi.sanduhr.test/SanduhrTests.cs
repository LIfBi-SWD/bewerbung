using Microsoft.VisualStudio.TestTools.UnitTesting;
using lifbi.sanduhr.logic;
using System;

namespace lifbi.sanduhr.test
{
    [TestClass]
    public class SanduhrTests
    {
        [TestMethod]
        public void TestSanduhrWidth3()
        {
            //Arrange
            Sanduhr sanduhr = new Sanduhr();
            
            //Act
            var print = sanduhr.Print(3);
            Console.Write(print);
            
            //Assert
            Assert.AreEqual("***"+Environment.NewLine+" *"+ Environment.NewLine + "***", print);    
        }

        [TestMethod]
        public void TestSanduhrWidth4()
        {
            //Arrange
            Sanduhr sanduhr = new Sanduhr();
            
            //Act
            var print = sanduhr.Print(4);
            Console.Write(print);

            //Assert
            Assert.AreEqual("****"+Environment.NewLine+" **"+ Environment.NewLine + "****", print);    
        }

        [TestMethod]
        public void TestSanduhrWidth5()
        {
            //Arrange
            Sanduhr sanduhr = new Sanduhr();
            
            //Act
            var print = sanduhr.Print(5);
            Console.Write(print);

            //Assert
            Assert.AreEqual("*****"+Environment.NewLine+" ***"+ Environment.NewLine + "  *"+ Environment.NewLine+" ***" + Environment.NewLine + "*****", print);    
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSanduhrException()
        {
            //Arrange
            Sanduhr sanduhr = new Sanduhr();
            
            //Act (throws Exception)
            var print = sanduhr.Print(1);  
        }
        
    }
}
