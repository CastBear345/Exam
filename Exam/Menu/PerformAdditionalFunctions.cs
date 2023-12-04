using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

public class PerformAdditionalFunctionss
{
    // Метод для выполнения дополнительных функций (например, спуск воды в унитазе)
    public static void PerformAdditionalFunctions(Device device)
    {
        int choice;
        if (device is Toilet)
        {
            Console.Clear();
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nДополнительные функции:");
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine("1. Спустить воду");
            Console.WriteLine("2. Помыть 5 точку");
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("3. Назад");
            ConsoleColors.SetYellowConsoleColor();

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ((Toilet)device).Flush();
                        break;
                    case 2:
                        ((Toilet)device).WashBottom();
                        break;
                    case 3:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Clear();
                        Console.WriteLine("Возврат к выбору действия.");
                        break;
                    default:
                        ConsoleColors.SetRedConsoleColor();
                        Console.WriteLine("Неверный выбор. Введите корректное число.");
                        break;
                }
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
        else if (device is Television)
        {
            Console.Clear();
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nВыберите параметр для изменения:");
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine("1. Смотреть фильм");
            Console.WriteLine("2. Запустить игру");
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("3. Назад");
            ConsoleColors.SetYellowConsoleColor();

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                int i;
                string ch;
                switch (choice)
                {
                    case 1:
                        List<string> movies = new List<string>() { "Годзилла против Конга", "Миссия Невыполнима", "Барби", "Индиана Джонс", "Мстители" };
                        for (int j = 0; j < movies.Count(); j++)
                        {
                            ConsoleColors.SetYellowConsoleColor();
                            Console.WriteLine(movies[j]);
                        }
                        ch = Console.ReadLine();
                        if (int.TryParse(ch, out i))
                        {
                            if (i > movies.Count)
                            {
                                ConsoleColors.SetYellowConsoleColor();
                                Console.WriteLine("Вы выбрали фильм за списком, попробуйте снова. К сожалению больше фильмов нет.");
                            }
                            else
                            {
                                ((Television)device).Movie(movies[i - 1]);
                            }
                        }
                        break;
                    case 2:
                        List<string> games = new List<string>() { "Assasin's Creed", "Resident Evil", "Fallout", "GTA V", "Fortnite" };
                        for (int j = 0; j < games.Count(); j++)
                        {
                            ConsoleColors.SetYellowConsoleColor();
                            Console.WriteLine(games[j]);
                        }
                        ch = Console.ReadLine();
                        if (int.TryParse(ch, out i))
                        {
                            if (i > games.Count)
                            {
                                ConsoleColors.SetYellowConsoleColor();
                                Console.WriteLine("Вы выбрали игру за списком, попробуйте снова. К сожалению больше игр нет.");
                            }
                            else
                            {
                                ((Television)device).VideoGame(games[i - 1]);
                            }
                        }
                        break;
                    case 3:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Clear();
                        Console.WriteLine("Возврат к выбору действия.");
                        break;
                    default:
                        ConsoleColors.SetRedConsoleColor();
                        Console.WriteLine("Неверный выбор. Введите корректное число.");
                        break;
                }
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
        else if (device is Dishwasher)
        {
            Console.Clear();
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nВыберите параметр для изменения:");
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine("1. Включить посудомоечную машины.");
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("2. Назад");
            ConsoleColors.SetYellowConsoleColor();
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ((Dishwasher)device).Start();
                        break;
                    case 2:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Clear();
                        Console.WriteLine("Возврат к выбору действия.");
                        break;
                    default:
                        ConsoleColors.SetRedConsoleColor();
                        Console.WriteLine("Неверный выбор. Введите корректное число.");
                        break;
                }
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
        else if (device is WashingMachine)
        {
            Console.Clear();
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nВыберите параметр для изменения:");
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine("1. Включить стиральную машину.");
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("2. Назад");
            ConsoleColors.SetYellowConsoleColor();
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ((WashingMachine)device).Start();
                        break;
                    case 2:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Clear();
                        Console.WriteLine("Возврат к выбору действия.");
                        break;
                    default:
                        ConsoleColors.SetRedConsoleColor();
                        Console.WriteLine("Неверный выбор. Введите корректное число.");
                        break;
                }
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
        else if (device is Kettle)
        {
            Console.Clear();
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nВыберите параметр для изменения:");
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine("1. Включить чайник.");
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("2. Назад");
            ConsoleColors.SetYellowConsoleColor();
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ((Kettle)device).StartBoilingWater();
                        break;
                        break;
                    case 2:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Clear();
                        Console.WriteLine("Возврат к выбору действия.");
                        break;
                    default:
                        ConsoleColors.SetRedConsoleColor();
                        Console.WriteLine("Неверный выбор. Введите корректное число.");
                        break;
                }
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
        else
        {
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("Дополнительные функции не поддерживаются для этого устройства.");
        }

        // Ждем, чтобы пользователь мог увидеть результат выполнения дополнительных функций
        ConsoleColors.SetOrangeConsoleColor();
        Console.WriteLine("\nНажмите Enter, чтобы продолжить...");
        Console.ReadLine();
    }
}