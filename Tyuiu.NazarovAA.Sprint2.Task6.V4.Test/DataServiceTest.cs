using Tyuiu.NazarovAA.Sprint2.Task6.V4.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = ds.FindCardSuit(1);
            string wait = "пики";

            Assert.AreEqual(wait, res);
        }
    }
}
