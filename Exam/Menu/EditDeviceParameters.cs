using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

public class EditDevicesParameters
{
    // Метод для изменения параметров устройства (например, яркости лампы или температуры термостата)
    public static void EditDeviceParameters(Device device)
    {
        if (device is Lamp)
        {
            Console.Clear();
            Console.WriteLine("\nВыберите параметр для изменения:");
            Console.WriteLine("1. Яркость");
            Console.WriteLine("2. Подсветка Вкл/Выкл");
            Console.WriteLine("3. Назад");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Write("Введите новую яркость (0-100%): ");
                        if (int.TryParse(Console.ReadLine(), out int brightness))
                        {
                            ((Lamp)device).AdjustBrightness(brightness);
                        }
                        else
                        {
                            ConsoleColors.SetRedConsoleColor();
                            Console.WriteLine("Неверный ввод. Яркость должна быть числом от 0 до 100.");
                        }
                        break;
                    case 2:
                        ((Lamp)device).MoodLighting();
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
        else if (device is Thermostat)
        {
            Console.Clear();
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nВыберите параметр для изменения:");
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine("1. Температура");
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("2. Назад");
            ConsoleColors.SetYellowConsoleColor();

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Write("Введите новую температуру: ");
                        if (int.TryParse(Console.ReadLine(), out int temperature))
                        {
                            ((Thermostat)device).SetTemperature(temperature);
                        }
                        else
                        {
                            ConsoleColors.SetRedConsoleColor();
                            Console.WriteLine("Неверный ввод. Температура должна быть числом.");
                        }
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
        else if (device is AlarmClock)
        {
            Console.Clear();
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nВыберите параметр для изменения:");
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine("1. Будильник");
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("2. Назад");
            ConsoleColors.SetYellowConsoleColor();

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                int newHours, newMinute;
                switch (choice)
                {
                    case 1:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Write("Введите сначала часы: ");
                        if (int.TryParse(Console.ReadLine(), out newHours))
                        {
                            if (newHours > -1 && 25 > newHours)
                            {
                                ConsoleColors.SetOrangeConsoleColor();
                                Console.Write("Теперь введите минуты: ");
                                if (int.TryParse(Console.ReadLine(), out newMinute))
                                {
                                    if (newMinute > -1 && 59 > newMinute)
                                    {
                                        string newTime = newHours.ToString() + ":" + newMinute.ToString();
                                        ((AlarmClock)device).ChangeAlarmTime(newTime);
                                    }
                                    else
                                    {
                                        ConsoleColors.SetRedConsoleColor();
                                        Console.WriteLine("Неверный ввод. Введите корректно минуты.");
                                    }
                                }
                                else
                                {
                                    ConsoleColors.SetRedConsoleColor();
                                    Console.WriteLine("Неверный ввод. Минуты должны быть числом.");
                                }
                            }
                            else
                            {
                                ConsoleColors.SetRedConsoleColor();
                                Console.WriteLine("Неверный ввод. Введите корректно часы.");
                            }
                        }
                        else
                        {
                            ConsoleColors.SetRedConsoleColor();
                            Console.WriteLine("Неверный ввод. Время должно быть числом.");
                        }
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
        else if (device is SmartLock)
        {
            Console.Clear();
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nВыберите параметр для изменения:");
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine("1. Изменить пароль");
            Console.WriteLine("2. Открыть замок");
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("3. Назад");
            ConsoleColors.SetYellowConsoleColor();

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                int password;
                switch (choice)
                {
                    case 1:
                        if (((SmartLock)device).IsLocked == false)
                        {
                            ConsoleColors.SetOrangeConsoleColor();
                            Console.Write("Введите измененный пароль: ");
                            if (int.TryParse(Console.ReadLine(), out password))
                            {
                                ((SmartLock)device).SetPassword(password.ToString());
                            }
                            else
                            {
                                ConsoleColors.SetRedConsoleColor();
                                Console.WriteLine("Неверный ввод. Пароль должен быть числом.");
                            }
                        }
                        else
                        {
                            ConsoleColors.SetOrangeConsoleColor();
                            Console.Write("Замок в комнате закрыт.");
                            Console.Write("Введите пароль: ");
                            if (int.TryParse(Console.ReadLine(), out password))
                            {
                                ((SmartLock)device).UnlockWithPassword(password.ToString());
                            }
                            else
                            {
                                ConsoleColors.SetRedConsoleColor();
                                Console.WriteLine("Неверный ввод. Пароль должен быть числом.");
                            }
                        }
                        break;
                    case 2:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Write("Введите пароль: ");
                        if (int.TryParse(Console.ReadLine(), out password))
                        {
                            ((SmartLock)device).UnlockWithPassword(password.ToString());
                        }
                        else
                        {
                            ConsoleColors.SetRedConsoleColor();
                            Console.WriteLine("Неверный ввод. Пароль должен быть числом.");
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
        else
        {
            ConsoleColors.SetOrangeConsoleColor();
            Console.WriteLine("Изменение параметров не поддерживается для этого устройства.");
        }

        // Ждем, чтобы пользователь мог увидеть результат изменения параметров
        ConsoleColors.SetOrangeConsoleColor();
        Console.Clear();
        Console.WriteLine("\nНажмите Enter для проделжения!");
        Console.ReadLine();
    }
}
