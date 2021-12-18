using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryLab4;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double result = 0;
                Console.WriteLine("Введите первое число: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Выберите операцию");
                char ch = char.Parse(Console.ReadLine());

                switch (ch)
                {
                    case '-':
                        result = MyLibrary.Subtract(a,b);
                        break;
                    case '+':
                        result = MyLibrary.Add(a, b);
                        break;
                    case '*':
                        result = MyLibrary.Multiply(a, b);
                        break;
                    case '/':
                        result = MyLibrary.Divide(a, b);
                        break;
                    default:
                        Console.WriteLine("Введена некорректная операция");                       

                        break;

                }
                Console.WriteLine("Результат:");
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}
