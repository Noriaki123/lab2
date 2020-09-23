using System;
using System.Numerics;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check;
            do
            {
                check = false;
                Console.WriteLine("Введите начальные и конечные координаты через пробел");
                int x1 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                int y1 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                int x2 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                x2 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                int y2 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                if (IsCoordinatesCorrect(x1, y1, x2, y2))
                {
                    IsHorseCorrect(x1, y1, x2, y2);
                }
                else
                {
                    check = true;
                }
                //Console.WriteLine($"{x1} {y1} {x2} {y2}");
            } while (check);
        }
        static void IsHorseCorrect(int x1, int y1, int x2, int y2)
        {
            if ((((x2 == x1--) || (x2 == x1++)) && ((y2 == y1 + 2) || (y2 == y1 - 2)))
            || (((y2 == y1--) || (y2 == y1++)) && ((x2 == x1 + 2) || (x2 == x1 - 2))))
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
        }
        static bool IsCoordinatesCorrect(int x1, int y1, int x2, int y2)
        {
            if (!(x1 > 64 && x1 < 73 && x2 > 64 && x2 < 73 && y1 > 48 && y1 < 57 && y2 > 48 && y2 < 57))
            {
                Console.WriteLine("Выбранные вами координаты не являются частью поля");
                Console.WriteLine("Попробуйте ещё раз");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
