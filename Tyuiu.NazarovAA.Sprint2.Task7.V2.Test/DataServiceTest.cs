using Tyuiu.NazarovAA.Sprint2.Task7.V2.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(0.5, -0.5);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
