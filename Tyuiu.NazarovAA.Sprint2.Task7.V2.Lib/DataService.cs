
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarovAA.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return y <= x / 2 && x * x + y * y <= 1; 
        }
    }
}
