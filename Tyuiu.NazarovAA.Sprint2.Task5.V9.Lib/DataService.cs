using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarovAA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string result = "Некоректная дата";
            switch (m)
            {
                case 1:
                    if (n == 31)
                        result = "01.02";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.01";
                    break;
                case 2:
                    if (n == 28)
                        result = "01.03";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.02)";
                    break;
                case 3:
                    if (n == 31)
                        result = "01.04";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.03)";
                    break;
                case 4:
                    if (n == 30)
                        result = "01.05";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.04)";
                    break;
                case 5:
                    if (n == 31)
                        result = "01.06";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.05)";
                    break;
                case 6:
                    if (n == 30)
                        result = "01.07";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.06";
                    break;
                case 7:
                    if (n == 31)
                        result = "01.08";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.07";
                    break;
                case 8:
                    if (n == 31)
                        result = "01.09";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.08";
                    break;
                case 9:
                    if (n == 30)
                        result = "01.10";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.09";
                    break;
                case 10:
                    if (n == 31)
                        result = "01.11";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.10";
                    break;
                case 11:
                    if (n == 30)
                        result = "01.12";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.11";
                    break;
                case 12:
                    if (n == 31)
                        result = "01.01";
                    else
                        result = $"{(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.12";
                    break;
                default:
                    throw new ArgumentException("Номер месяца должен быть от 1 до 12!");
            }
            return result;
        }
    }
}
