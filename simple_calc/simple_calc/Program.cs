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
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели что-то кроме числа");
                    goto m1;
                }

                Console.Write("Введите оператор: ");
                oper = Convert.ToChar(Console.ReadLine());

                Console.Write("Введите второе число: ");
                try
                {
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы ввели что-то кроме числа");
                    goto m1;
                }

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
                    if (b != 0) {
                        total = a / b;
                        Console.WriteLine("Результат равен " + total);
                    }
                    else {
                        Console.WriteLine("Деление на 0 недопустимо");
                        goto m1; 
                    }
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
                m1: 
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Вы хотите завершить программу? (д/н)");
            }
        }
    }
}
