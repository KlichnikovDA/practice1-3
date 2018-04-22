using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Координаты точки
            double X, Y;
            // Флаг правильности ввода
            bool ok;
            Console.WriteLine("Введите координаты точки: ");

            // Ввод координаты Х
            do
            {
                ok = Double.TryParse(Console.ReadLine(), out X);
                if (!ok)
                    Console.WriteLine("Координата должна быть вещественным числом.");
            } while (!ok);

            // Ввод координаты Y
            do
            {
                ok = Double.TryParse(Console.ReadLine(), out Y);
                if (!ok)
                    Console.WriteLine("Координата должна быть вещественным числом.");
            } while (!ok);

            // Флаг вхождения точки в заданную область
            bool Contained = (Math.Abs(X) <= 1) && (((Y >= -2) && (Y < 0)) || ((Y >= 0) && (Y <= Math.Abs(X))));
            Console.WriteLine("Точка с заданными координатами принадлежит заданной области: {0}", Contained);

            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
