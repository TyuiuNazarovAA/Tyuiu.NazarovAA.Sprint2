using Tyuiu.NazarovAA.Sprint2.Task2.V27.Lib;

namespace Tyuiu.NazarovAA.Sprint2.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Назаров А. А. | РППб 25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if - полная и краткая форма записи                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Назаров Артём Александрович | СППб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной        *");
            Console.WriteLine("* области                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
        }
    }
}
