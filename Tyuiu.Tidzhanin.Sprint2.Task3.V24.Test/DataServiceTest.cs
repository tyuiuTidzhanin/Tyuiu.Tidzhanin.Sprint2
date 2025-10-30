using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint2.Task3.V24.Lib;

namespace Tyuiu.Tidzhanin.Sprint2.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXGreaterThanZero()
        {
            DataService ds = new DataService();
            double x = 5;
            double wait = 9765625; // (10 + sin(√6))^5 ≈ 9765625
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateXEqualToZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(double.PositiveInfinity, res);
        }

        [TestMethod]
        public void ValidCalculateXBetweenMinus28AndZero()
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = Math.Pow(1 + 1 / (x * x), x); // (1 + 1/25)^(-5)
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateXLessThanMinus28()
        {
            DataService ds = new DataService();
            double x = -30;
            double wait = x * x + 10 * x - (1 / x); // 900 - 300 + 0.0333
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}