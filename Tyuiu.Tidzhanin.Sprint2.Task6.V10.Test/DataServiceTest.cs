using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Tidzhanin.Sprint2.Task6.V10.Lib;

namespace Tyuiu.Tidzhanin.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDayRegular()
        {
            DataService ds = new DataService();

            // Обычный день (не первое число)
            string result = ds.FindDateOfPreviousDay(2023, 5, 15);
            Assert.AreEqual("14.5.2023", result);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDayFirstOfMonth()
        {
            DataService ds = new DataService();

            // Первое число месяца (переход на предыдущий месяц)
            string result = ds.FindDateOfPreviousDay(2023, 6, 1);
            Assert.AreEqual("31.5.2023", result);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDayFirstOfYear()
        {
            DataService ds = new DataService();

            // Первое число года (переход на предыдущий год)
            string result = ds.FindDateOfPreviousDay(2023, 1, 1);
            Assert.AreEqual("31.12.2022", result);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDayFebruary()
        {
            DataService ds = new DataService();

            // Первое марта (переход с февраля)
            string result = ds.FindDateOfPreviousDay(2023, 3, 1);
            Assert.AreEqual("28.2.2023", result);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDayApril()
        {
            DataService ds = new DataService();

            // Первое мая (переход с апреля - 30 дней)
            string result = ds.FindDateOfPreviousDay(2023, 5, 1);
            Assert.AreEqual("30.4.2023", result);
        }
    }
}