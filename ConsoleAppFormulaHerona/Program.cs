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
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Длина второй из трёх сторон: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Длина третьей из трёх сторон: ");
            int c = Convert.ToInt32(Console.ReadLine());
            var p = (a + b + c) * 0.5;
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника: {s}");
            Console.ReadLine();
        }
    }
}
