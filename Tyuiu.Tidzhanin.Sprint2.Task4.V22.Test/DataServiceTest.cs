using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint2.Task4.V22.Lib;

namespace Tyuiu.Tidzhanin.Sprint2.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateConditionTrue()
        {
            DataService ds = new DataService();

            // x - 3 > y * 2 - 21
            // 10 - 3 > 5 * 2 - 21 → 7 > 10 - 21 → 7 > -11 → True
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);

            // z = x^2 + 12y - (2/x) = 100 + 60 - 0.2 = 159.8
            double wait = 100 + 60 - 0.2;

            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateConditionFalse()
        {
            DataService ds = new DataService();

            // x - 3 > y * 2 - 21
            // 5 - 3 > 10 * 2 - 21 → 2 > 20 - 21 → 2 > -1 → True
            // Нужно найти значения, где условие ложно
            // x - 3 <= y * 2 - 21
            double x = 1;
            double y = 10;
            double res = ds.Calculate(x, y);

            // z = (x^2 + cos(y)^2 + 17) / (y^2 - sin(y)^2 + 3)
            double numerator = 1 + Math.Pow(Math.Cos(10), 2) + 17;
            double denominator = 100 - Math.Pow(Math.Sin(10), 2) + 3;
            double wait = numerator / denominator;

            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateEdgeCase()
        {
            DataService ds = new DataService();

            // Граничный случай: x - 3 = y * 2 - 21
            // x - 3 = 2y - 21 → x = 2y - 18
            // При y = 10: x = 20 - 18 = 2
            // 2 - 3 > 10 * 2 - 21 → -1 > -1 → False
            double x = 2;
            double y = 10;
            double res = ds.Calculate(x, y);

            double numerator = 4 + Math.Pow(Math.Cos(10), 2) + 17;
            double denominator = 100 - Math.Pow(Math.Sin(10), 2) + 3;
            double wait = numerator / denominator;

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}