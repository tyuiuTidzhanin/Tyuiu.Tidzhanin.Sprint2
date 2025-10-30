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

            // Расчет по формуле: x * ((10 + sin√(x+1)) / x)^x
            double sinValue = Math.Sin(Math.Sqrt(5 + 1)); // sin(√6) ≈ sin(2.449) ≈ 0.640
            double numerator = 10 + sinValue; // ≈ 10.640
            double fraction = numerator / x; // ≈ 2.128
            double power = Math.Pow(fraction, x); // ≈ 2.128^5 ≈ 41.6
            double wait = x * power; // 5 * 41.6 ≈ 208

            double res = ds.Calculate(x);
            Assert.AreEqual(217.998, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateXEqualToZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(double.MaxValue, res);
        }

        [TestMethod]
        public void ValidCalculateXBetweenMinus28AndZero()
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = Math.Pow(1 + 1 / (x * x), x);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }

        [TestMethod]
        public void ValidCalculateXLessThanMinus28()
        {
            DataService ds = new DataService();
            double x = -30;
            double wait = (x * x) + (10 * x) - (1 / x);
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}