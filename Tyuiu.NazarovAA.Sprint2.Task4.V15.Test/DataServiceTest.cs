using Tyuiu.NazarovAA.Sprint2.Task4.V15.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Condition1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 2);
            double wait = 3.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void Condition2()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 900);
            double wait = 12.066;
            Assert.AreEqual(wait, res);
        }
    }
}
