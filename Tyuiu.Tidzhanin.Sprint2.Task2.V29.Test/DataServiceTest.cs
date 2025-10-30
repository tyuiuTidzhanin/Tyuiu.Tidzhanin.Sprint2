using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint2.Task2.V29.Lib;

namespace Tyuiu.Tidzhanin.Sprint2.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точки в заштрихованной области
            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));
            Assert.IsTrue(ds.CheckDotInShadedArea(4, 1));
            Assert.IsTrue(ds.CheckDotInShadedArea(6, 5));
            Assert.IsTrue(ds.CheckDotInShadedArea(8, 10));
            Assert.IsTrue(ds.CheckDotInShadedArea(11, 4));
            Assert.IsTrue(ds.CheckDotInShadedArea(12, 10));

            // Точки вне заштрихованной области
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(5, 5));
            Assert.IsFalse(ds.CheckDotInShadedArea(8, 8));
            Assert.IsFalse(ds.CheckDotInShadedArea(13, 13));
            Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));
        }
    }
}