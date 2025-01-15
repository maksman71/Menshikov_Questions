using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 задание \n\n");

        Console.WriteLine("Введите своё имя: ");
        string name = Console.ReadLine();

        Console.WriteLine("Введите ваш возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите свой рост: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Ваше имя {name}, Ваш возраст {age} лет, ваш рост {height} см.");


        Console.WriteLine("2 задание \n\n");

        Console.WriteLine("Введите 2 числа");

        int number1, number2;
        Console.WriteLine("Введите первое число");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Сумма: {number1 + number2}; Разность: {number1 - number2}; Производное: {number1 * number2}; Частное: {number1 / number2}");


        Console.WriteLine("3 задание \n\n");

        int x;

        Console.WriteLine("Введите число");

        x = Console.Read();

        if ((x % 2) == 0)
        {
            Console.WriteLine("Чётное");
        }

        else
        {
            Console.WriteLine("Нечётное");
        }


        Console.WriteLine("5 задание \n\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

    }

}