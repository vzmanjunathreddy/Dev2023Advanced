using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtitlityLibrary;

namespace Demo.MSTest.UnitTesting
{
    [TestClass]
    public class WordLibraryTest
    {
        [TestMethod]
        public void TestIsWordStartsWithUpper()
        {
            string fruit = "Mango";

            bool result = fruit.StartswithUpperchar();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAreWordStartsWithUpper()
        {
            string[] fruits = { "Mango", "Apple", "Papaya" };

            foreach(var fruit in fruits)
            {
                bool result = fruit.StartswithUpperchar();

                Assert.IsTrue(result);

            }
 
        }

        [TestMethod]
        public void TestAreWordNOTStartsWithUpper()
        {
            string[] fruits = { "Mango", "apple", "papaya" };

            foreach (var fruit in fruits)
            {
                bool result = fruit.StartswithUpperchar();

                Assert.IsFalse(result);

            }

        }
    }
}
