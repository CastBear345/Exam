using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

public class ControlDevices
{
    // Метод для управления устройством
    public static void ControlDevice(Device device)
    {
        while (true)
        {
            Console.Clear();
            device.DisplayStatus();

            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nВыберите действие:");
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine("1. Включить");
            Console.WriteLine("2. Выключить");
            Console.WriteLine("3. Изменить параметры");
            Console.WriteLine("4. Дополнительные функции");
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("5. Назад");
            ConsoleColors.SetYellowConsoleColor();

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        device.TurnOn();
                        break;
                    case 2:
                        device.TurnOff();
                        break;
                    case 3:
                        EditDevicesParameters.EditDeviceParameters(device);
                        break;
                    case 4:
                        PerformAdditionalFunctionss.PerformAdditionalFunctions(device);
                        break;
                    case 5:
                        ConsoleColors.SetOrangeConsoleColor();
                        Console.Clear();
                        Console.WriteLine("Возврат к выбору устройства.");
                        return;
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
    }
}
