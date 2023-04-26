using System;
using System.IO;

namespace ConsoleMenu
{
    class Program
    {
        static string filePath = "C:\\Users\\MaxPC\\Desktop\\LoremIpsum.txt"; // Поле, яке містить шлях до файлу з початковим текстом

        static void Main(string[] args)
        {
            Console.WriteLine("1. Порахувати кiлькiсть слiв у текстi \"Lorem ipsum\"");
            Console.WriteLine("2. Виконати математичну операцiю");
            Console.WriteLine("Введiть номер пункту меню:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CountWordsInLoremIpsum();
                    break;
                case 2:
                    PerformMathOperation();
                    break;
                default:
                    Console.WriteLine("Ви ввели некоректний номер пункту меню.");
                    break;
            }
        }

        static void CountWordsInLoremIpsum()
        {
            string text = File.ReadAllText(filePath);
            int wordCount = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Кiлькiсть слiв у текстi \"Lorem ipsum\": {wordCount}");
        }

        static void PerformMathOperation()
        {
            Console.WriteLine("Введiть математичний вираз:");
            string expression = Console.ReadLine();
            double result = Calculate(expression);
            Console.WriteLine($"Результат: {result}");
        }

        static double Calculate(string expression)
        {
            // Виконуємо обчислення математичного виразу за допомогою методу Evaluate класу DataTable.
            // Важливо: цей підхід не є найефективнішим та може бути небезпечним, якщо ви дозволяєте користувачеві вводити будь-який вираз.
            // Рекомендується додатково перевіряти та обмежувати введення користувача.
            System.Data.DataTable dataTable = new System.Data.DataTable();
            return Convert.ToDouble(dataTable.Compute(expression, ""));
        }
    }
}
