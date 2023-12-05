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
        /*while (true)
        {
            Console.Clear();
            List<string> options = new List<string>()
            {
                "Включить",
                "Выключить",
                "Изменить параметры",
                "Дополнительные функции",
                "Назад"
            };

            ConsoleKeyInfo keyInfo;
            int number = 0;

            do
            {
                Console.Clear();
                device.DisplayStatus();
                Menu.PrintFirst("Выберите действие:");

                for (int i = 0; i < options.Count; i++)
                {
                    if (i == number)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Menu.PrintFirst($"{options[i]}");
                }

                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + options.Count()) % options.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % options.Count(); }
                int choice = number;

                if (keyInfo.Key == ConsoleKey.Enter)
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
                            Menu.PrintFirst("Возврат к выбору устройства.");
                            // Используйте break для выхода из обоих циклов
                            return;
                    }
                }

                // Вернуть цветовую схему к стандартной после вывода списка
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                // Проверка клавиши Escape для выхода из обоих циклов
            } while (keyInfo.Key != ConsoleKey.Escape);

            break; // Выход из внешнего цикла
        }*/
    }
}
