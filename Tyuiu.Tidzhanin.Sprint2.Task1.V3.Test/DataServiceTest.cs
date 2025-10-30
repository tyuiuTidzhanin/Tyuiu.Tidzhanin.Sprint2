using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint2.Task1.V3.Lib;

namespace Tyuiu.Tidzhanin.Sprint2.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { true, false, false, false, false, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}