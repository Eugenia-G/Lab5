using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'д';
            while(again == 'д')
            {
                double a;
                double b;
                double total;
                char oper;

                Console.Write("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите оператор: ");
                oper = Convert.ToChar(Console.ReadLine());

                Console.Write("Введите второе число: ");
                b = Convert.ToDouble(Console.ReadLine());

                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("Результат равен " + total);
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Результат равен " + total);
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Результат равен " + total);
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("Результат равен " + total);
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
