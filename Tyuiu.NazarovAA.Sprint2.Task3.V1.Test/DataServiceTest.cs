using Tyuiu.NazarovAA.Sprint2.Task3.V1.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Condision1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 9.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void Condision2()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = -8.741;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void Condision3()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-1);
            double wait = -10;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void Condision4()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-6);
            double wait = -65.995;
            Assert.AreEqual(wait, res);
        }
    }
}
