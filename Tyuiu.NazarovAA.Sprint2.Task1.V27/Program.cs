using Tyuiu.NazarovAA.Sprint2.Task1.V27.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Назаров А. А. | РППб 25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Назаров Артём Александрович | СППб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
            Console.WriteLine("* которая вернет логическую последовательность                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение C:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение D:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            foreach (bool item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
