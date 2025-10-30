using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint2.Task7.V13.Lib;

namespace Tyuiu.Tidzhanin.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedAreaInside()
        {
            DataService ds = new DataService();

            // Точка внутри заштрихованной области
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, 0.5));   // Внутри области
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.5, 0.5));  // Внутри области
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.8));     // Внутри области
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaOnBoundary()
        {
            DataService ds = new DataService();

            // Точки на границах
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 0));       // На окружности
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 1));       // На окружности и линии y=1
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, -0.5));  // На прямой y=x-1
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaOutside()
        {
            DataService ds = new DataService();

            // Точки вне заштрихованной области
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 0));      // Внутри окружности
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 2));      // Выше линии y=1
            Assert.IsFalse(ds.CheckDotInShadedArea(1, -1));     // Ниже прямой y=x-1
            Assert.IsFalse(ds.CheckDotInShadedArea(-1, -1));    // Ниже прямой и внутри окружности
        }

        [TestMethod]
        public void ValidCheckDotInShadedAreaCornerCases()
        {
            DataService ds = new DataService();

            // Угловые случаи
            Assert.IsTrue(ds.CheckDotInShadedArea(0.7, 0.3));   // Пересечение условий
            Assert.IsFalse(ds.CheckDotInShadedArea(0.3, 0.3));  // Внутри окружности
            Assert.IsTrue(ds.CheckDotInShadedArea(-0.7, 0.3));  // В области слева
        }
    }
}