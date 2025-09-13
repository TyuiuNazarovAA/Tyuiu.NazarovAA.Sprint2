using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarovAA.Sprint2.Task1.V27.Lib
{
    public class DataService : ISprint2Task1V27
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res =
            {
                (a < b) | (c > d),
                (a > b) & (c == d),
                (a > b) || (c >= d),
                (a == b) && (c != d),
                !(c == d),
                (a != b) ^ (c != d)
            };
            return res;
        }
    }
}
