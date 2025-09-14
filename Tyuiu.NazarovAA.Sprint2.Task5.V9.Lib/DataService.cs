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
                        result = "1 Февраль (01.02.2025)";
                    else
                        result = $"{n + 1} Январь ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.01.2025)";
                    break;
                case 2:
                    if (n == 28)
                        result = "1 Март (01.03.2025)";
                    else
                        result = $"{n + 1} Февраль ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.02.2025)";
                    break;
                case 3:
                    if (n == 31)
                        result = "1 Апрель (01.04.2025)";
                    else
                        result = $"{n + 1} Март ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.03.2025)";
                    break;
                case 4:
                    if (n == 30)
                        result = "1 Май (01.05.2025)";
                    else
                        result = $"{n + 1} Апрель ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.04.2025)";
                    break;
                case 5:
                    if (n == 31)
                        result = "1 Июнь (01.06.2025)";
                    else
                        result = $"{n + 1} Май ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.05.2025)";
                    break;
                case 6:
                    if (n == 30)
                        result = "1 Июль (01.07.2025)";
                    else
                        result = $"{n + 1} Июнь ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.06.2025)";
                    break;
                case 7:
                    if (n == 31)
                        result = "1 Август (01.08.2025)";
                    else
                        result = $"{n + 1} Июль ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.07.2025)";
                    break;
                case 8:
                    if (n == 31)
                        result = "1 Сентябрь (01.09.2025)";
                    else
                        result = $"{n + 1} Август ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.08.2025)";
                    break;
                case 9:
                    if (n == 30)
                        result = "1 Октябрь (01.10.2025)";
                    else
                        result = $"{n + 1} Сентябрь ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.09.2025)";
                    break;
                case 10:
                    if (n == 31)
                        result = "1 Ноябрь (01.11.2025)";
                    else
                        result = $"{n + 1} Октябрь ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.10.2025)";
                    break;
                case 11:
                    if (n == 30)
                        result = "1 Декабрь (01.12.2025)";
                    else
                        result = $"{n + 1} Ноябрь ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.11.2025)";
                    break;
                case 12:
                    if (n == 31)
                        result = "1 Январь (01.01.2026)";
                    else
                        result = $"{n + 1} Декабрь ({(n + 1 > 9 ? n + 1 : "0" + (n + 1))}.12.2025)";
                    break;
                default:
                    throw new ArgumentException("Номер месяца должен быть от 1 до 12!");
            }
            return result;
        }
    }
}
