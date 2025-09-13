﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarovAA.Sprint2.Task2.V27.Lib
{
    public class DataService : ISprint2Task2V27
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && y >= 3 && x <= 5 && y <= 5) ||
                (x >= 6 && x <= 9 && y >= 5 && y <= 8) ||
                (x >= 9 && x <= 12 && x >= 8 && x <= 12 && x != 9 && y != 13) ||
                (y == 11 && x >= 3 && x <= 6) ||
                (x == 3 && y == 6) ||
                (x == 9 && (y == 3 || y == 4)) ||
                (x == 13 && (y == 6 || y == 7 || y == 8)) ||
                (x == 6 && (y == 9 || y == 10)))
            {
                return true;
            }
            return false;
        }
    }
}
