namespace Demo.MSTest.UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumresultsareEqual()
        {
            //arrange
            var expected = 3;
            //act 
            var actual = MathsHelper.add(1, 2);

            //assert
            Assert.AreEqual(expected, actual, "Values are not matching..");
        }

        [TestMethod]
        public void TestSumresultsareNotEqual()
        {
            //arrange
            var expected = 4;
            //act 
            var actual = MathsHelper.add(1, 2);

            //assert
            Assert.AreNotEqual(expected, actual, "Values are not matching..");
        }

        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 3, 6)]
        [DataRow(3, 4, 7)]

        public void TestSumresultsareEqualwithInputParams(int firstNumber, int secondNumber, int expectedresult)
        {

            var actual = MathsHelper.add(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expectedresult, actual, "Values are not matching..");
        }

        [TestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(2, 3, 6)]
        [DataRow(3, 8, 7)]
        public void TestSumresultsareNotEqualwithInputParams(int firstNumber, int secondNumber, int expectedresult)
        {

            var actual = MathsHelper.add(firstNumber, secondNumber);

            //assert
            Assert.AreNotEqual(expectedresult, actual, "Values are not matching..");
        }

    }
}