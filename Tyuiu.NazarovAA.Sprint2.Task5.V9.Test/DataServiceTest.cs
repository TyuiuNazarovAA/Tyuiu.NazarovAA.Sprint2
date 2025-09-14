using Tyuiu.NazarovAA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFindDateOfNextDayValid()
        {
            DataService ds = new DataService();

            string res = ds.FindDateOfNextDay(3, 19);
            string wait = "20 Март (20.03.2025)";

            Assert.AreEqual(wait, res);
        }
    }
}
