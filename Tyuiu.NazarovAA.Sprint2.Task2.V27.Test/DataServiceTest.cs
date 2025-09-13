using Tyuiu.NazarovAA.Sprint2.Task2.V27.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(7, 5);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
