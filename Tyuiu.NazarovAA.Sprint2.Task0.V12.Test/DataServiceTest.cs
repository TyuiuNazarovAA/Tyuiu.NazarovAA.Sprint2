using Tyuiu.NazarovAA.Sprint2.Task0.V12.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetCompareOperationsValid()
        {
            DataService ds = new DataService();
            bool[] res = ds.GetCompareOperations(1095, 475);
            bool[] wait = { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
