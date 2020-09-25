using System;
using System.Numerics;

namespace lab2
{
    class Program
    {
        static bool check;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите название фигуры");
                string figure = Console.ReadLine();
                check = false;
                Console.WriteLine("Введите начальные и конечные координаты через пробел");
                int x1 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                int y1 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                int x2 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                x2 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                int y2 = Convert.ToInt32(Convert.ToChar(Console.Read()));
                if (IsCoordinatesCorrect(x1, y1, x2, y2))
                {
                    if (SelectFigure(figure, x1, y1, x2, y2))
                    {
                        Console.WriteLine("Верно");
                    }
                    else
                    {
                        check = true;
                        Console.WriteLine("Неверно");
                    }
                }
                else
                {
                    Console.WriteLine("Выбранные вами координаты не соответствуют игровому полю");
                    check = true;
                }
                //Console.WriteLine($"{x1} {y1} {x2} {y2}");
            } while (check);
        }
        static bool IsHorseCorrect(int x1, int y1, int x2, int y2)
        {
            return ((((x2 == x1--) || (x2 == x1++)) && ((y2 == y1 + 2) || (y2 == y1 - 2)))
            || (((y2 == y1--) || (y2 == y1++)) && ((x2 == x1 + 2) || (x2 == x1 - 2))));
        }
        static bool IsCoordinatesCorrect(int x1, int y1, int x2, int y2)
        {
            return (x1 > 64 && x1 < 73 && x2 > 64 && x2 < 73 && y1 > 48 && y1 < 57 && y2 > 48 && y2 < 57);
        }
        static bool IsKingCorrect(int x1, int y1, int x2, int y2)
        {
            return (((x2 == x1++) || (x2 == x1--)) && ((y2 == y1) || (y2 == y1--) || (y2 == y1++)))
            || (((x2 == x1++) || (x2 == x1--) || (x2 == x1)) && ((y2 == y1--) || (y2 == y1++)));
        }
        static bool IsQueenCorrect(int x1, int y1, int x2, int y2)
        {
            return ((x2 == x1) && (y2 != y1)) || ((y2 == y1) && (x2 != x1)) || (Math.Abs(x2 - x1) == Math.Abs(y2 - y1));
        }
        static bool IsBishopCorrect(int x1, int y1, int x2, int y2)
        {
            return ((Math.Abs(x2 - x1) == Math.Abs(y2 - y1)) && x2 != x1 && y2 != y1);
        }
        static bool IsRockCorrect(int x1, int y1, int x2, int y2)
        {
            return ((x2 == x1) && (y2 != y1)) || ((y2 == y1) && (x2 != x1));
        }
        static bool IsPawnCorrect(int x1, int y1, int x2, int y2)
        {
            return (x2 == x1) && ((y2 == y1++) || (y2 == y1--));
        }
        static bool SelectFigure(string figure, int x1, int y1, int x2, int y2)
        {
            if (figure == "Король")
            {
                return IsKingCorrect(x1, y1, x2, y2);
            }
            else if (figure == "Ферзь")
            {
                return IsQueenCorrect(x1, y1, x2, y2);
            }
            else if (figure == "Слон")
            {
                return IsBishopCorrect(x1, y1, x2, y2);
            }
            else if (figure == "Конь")
            {
                return IsHorseCorrect(x1, y1, x2, y2);
            }
            else if (figure == "Ладья")
            {
                return IsRockCorrect(x1, y1, x2, y2);
            }
            else if (figure == "Пешка")
            {
                return IsPawnCorrect(x1, y1, x2, y2);
            }
            else
            {
                Console.WriteLine("Вы ввели несуществующую фигуру");
                return false;
            }
        }
    }
}
