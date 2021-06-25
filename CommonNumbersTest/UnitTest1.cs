using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        CommonNumbers common = new CommonNumbers();
        string[] testArray1 = { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
        string[] testArray2 = { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" };

        [TestMethod]
        public void TestFindCommonMethod()
        {
            string expected = "1,4,13";

            Assert.AreEqual(expected, common.FindCommon(testArray1));

        }

        [TestMethod]
        public void TestFindCommonMethod2()
        {
            string expected = "1,9,10";

            Assert.AreEqual(expected, common.FindCommon(testArray2));

        }

        [TestMethod]
        public void TestCreateList()
        {           
            List<string> expected = new List<string> { "1,4,13", "1,9,10" };

            Assert.AreEqual(expected.ToString(), common.CreateList(testArray1, testArray2).ToString());

        }
    }
}
