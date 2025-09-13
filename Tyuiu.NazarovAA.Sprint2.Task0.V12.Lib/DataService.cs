using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarovAA.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res =
            {
                x == y + 620,
                x != y + 620,
                x < y + 1000,
                x > y + 1000,
                x <= y + 1000,
                x >= y + 1000,
            };
            return res;
        }
    }
}
