using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint2.Task5.V2.Lib;

namespace Tyuiu.Tidzhanin.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeasonWinter()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Зима", ds.FindMonthSeason(12));
            Assert.AreEqual("Зима", ds.FindMonthSeason(1));
            Assert.AreEqual("Зима", ds.FindMonthSeason(2));
        }

        [TestMethod]
        public void ValidFindMonthSeasonSpring()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Весна", ds.FindMonthSeason(3));
            Assert.AreEqual("Весна", ds.FindMonthSeason(4));
            Assert.AreEqual("Весна", ds.FindMonthSeason(5));
        }

        [TestMethod]
        public void ValidFindMonthSeasonSummer()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Лето", ds.FindMonthSeason(6));
            Assert.AreEqual("Лето", ds.FindMonthSeason(7));
            Assert.AreEqual("Лето", ds.FindMonthSeason(8));
        }

        [TestMethod]
        public void ValidFindMonthSeasonAutumn()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Осень", ds.FindMonthSeason(9));
            Assert.AreEqual("Осень", ds.FindMonthSeason(10));
            Assert.AreEqual("Осень", ds.FindMonthSeason(11));
        }

        [TestMethod]
        public void ValidFindMonthSeasonInvalid()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Введено неверное значение месяца", ds.FindMonthSeason(0));
            Assert.AreEqual("Введено неверное значение месяца", ds.FindMonthSeason(13));
            Assert.AreEqual("Введено неверное значение месяца", ds.FindMonthSeason(-1));
        }
    }
}