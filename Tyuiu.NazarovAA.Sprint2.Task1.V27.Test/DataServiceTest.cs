using Tyuiu.NazarovAA.Sprint2.Task1.V27.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetLogicOperationsValid()
        {
            DataService ds = new DataService();
            bool[] res = ds.GetLogicOperations(654, 325, 154, 333);
            bool[] wait = { false, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
