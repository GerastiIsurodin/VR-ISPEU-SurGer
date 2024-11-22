using System;

class ProgramV2
{

    static void Calc(double n1, char operation, double n2)
    {

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
                Console.WriteLine("Неизвестный оператор(ы)");
                break;
        }
    }
    static void Main()
    {
        double[] n1Mas = { 0, 1.2, 3.33333 };
        char[] operationMas = {'-', '/', '*' };
        double[] n2Mas = { -23, 777, 666 };
        //Big O(infinity)
        for (int i = 0; i < n1Mas.Length; i++)
        {
            for (int j = 0; j < operationMas.Length; j++)
            {
                for(int k = 0; k < n2Mas.Length; k++)
                {
                    Calc(n1Mas[i], operationMas[j],n2Mas[k]);
                }
            }
        }

        bool cond = true;
        while (cond)
        {
            Console.WriteLine("Введите 1-ое число:");
            double n1 = Convert.ToDouble(Console.ReadLine());
    
            Console.WriteLine("Введите оператор (+, -, *, /):");
            char operation = Console.ReadLine()[0];

            Console.WriteLine("Введите 2-ое число:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Calc(n1, operation, n2);
            Console.WriteLine("Выйти?(yes, anyway*)");
            string query = Console.ReadLine();
            if (query == "yes") { cond = false; }
        }
    }
}
