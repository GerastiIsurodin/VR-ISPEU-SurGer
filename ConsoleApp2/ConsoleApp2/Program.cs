using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 1-ое число:");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите оператор (+, -, *, /):");
        char operation = Console.ReadLine()[0];

        Console.WriteLine("Введите 2-ое число:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (operation)
        {
            case '+':
                result = n1 + n2;
                Console.WriteLine($"{n1} + {n2} = {result}");
                break;

            case '-':
                result = n1 - n2;
                Console.WriteLine($"{n1} - {n2} = {result}");
                break;

            case '*':
                result = n1 * n2;
                Console.WriteLine($"{n1} * {n2} = {result}");
                break;

            case '/':
                if (n2 != 0)
                {
                    result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result}");
                }
                else
                {
                    Console.WriteLine("Деление на ноль");
                }
                break;

            default:
                Console.WriteLine("Неизвестный оператор");
                break;
        }
    }
}
