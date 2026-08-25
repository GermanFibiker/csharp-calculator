using System;

while (true)
{
    Console.WriteLine("\n=== C# Calculator ===");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Выход");
    Console.Write("Выберите операцию: ");

    string? choice = Console.ReadLine();

    if (choice == "5")
        break;

    Console.Write("Введите первое число: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите второе число: ");
    double b = Convert.ToDouble(Console.ReadLine());

    switch (choice)
    {
        case "1":
            Console.WriteLine($"Результат: {a + b}");
            break;

        case "2":
            Console.WriteLine($"Результат: {a - b}");
            break;

        case "3":
            Console.WriteLine($"Результат: {a * b}");
            break;

        case "4":
            if (b == 0)
                Console.WriteLine("Ошибка: деление на ноль невозможно.");
            else
                Console.WriteLine($"Результат: {a / b}");
            break;

        default:
            Console.WriteLine("Неверный выбор.");
            break;
    }
}