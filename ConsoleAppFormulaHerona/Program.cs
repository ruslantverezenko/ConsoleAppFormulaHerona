using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFormulaHerona
{
    class Program
    {
        static void Main(string[] args)
        {
        /*     задание:
         *      Запросить у пользователя длины трёх сторон треугольника. Длины могут быть представлены дробными значениями.
                После получения длин сторон - использовать формулу Герона для вычисления площади треугольника.
                После вычисления площади - вывести результат на консоль.
        */

            Console.Write("Длина первой из трёх сторон: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Длина второй из трёх сторон: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Длина третьей из трёх сторон: ");
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника: {s}");
            Console.ReadLine();
        }
    }
}
