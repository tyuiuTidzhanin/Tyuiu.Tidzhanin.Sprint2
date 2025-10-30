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

            Assert.AreEqual("зима", ds.FindMonthSeason(12));
            Assert.AreEqual("зима", ds.FindMonthSeason(1));
            Assert.AreEqual("зима", ds.FindMonthSeason(2));
        }

        [TestMethod]
        public void ValidFindMonthSeasonSpring()
        {
            DataService ds = new DataService();

            Assert.AreEqual("весна", ds.FindMonthSeason(3));
            Assert.AreEqual("весна", ds.FindMonthSeason(4));
            Assert.AreEqual("весна", ds.FindMonthSeason(5));
        }

        [TestMethod]
        public void ValidFindMonthSeasonSummer()
        {
            DataService ds = new DataService();

            Assert.AreEqual("лето", ds.FindMonthSeason(6));
            Assert.AreEqual("лето", ds.FindMonthSeason(7));
            Assert.AreEqual("лето", ds.FindMonthSeason(8));
        }

        [TestMethod]
        public void ValidFindMonthSeasonAutumn()
        {
            DataService ds = new DataService();

            Assert.AreEqual("осень", ds.FindMonthSeason(9));
            Assert.AreEqual("осень", ds.FindMonthSeason(10));
            Assert.AreEqual("осень", ds.FindMonthSeason(11));
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