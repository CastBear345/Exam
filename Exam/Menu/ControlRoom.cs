using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

public class ControlRooms
{
    // Метод для управления комнатой
    public static void ControlRoom(Room room)
    {
        while (true)
        {
            Console.Clear();
            ConsoleColors.SetBlueConsoleColor();
            Console.WriteLine($"\nУправление комнатой {room.Name}");
            ControlRoomsImages.ControlRoomImage(room);// Создает рисунок комнаты
            Console.WriteLine("");
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("Выберите устройство для управления:");

            for (int i = 0; i < room.Devices.Count; i++)// Выводится список доступных устройств в этой комнате
            {
                ConsoleColors.SetYellowConsoleColor();
                Console.WriteLine($"{i + 1}. {room.Devices[i].Name}");
            }
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine($"{room.Devices.Count + 1}. Назад");
            ConsoleColors.SetYellowConsoleColor();

            if (int.TryParse(Console.ReadLine(), out int deviceChoice) && deviceChoice >= 1 && deviceChoice <= room.Devices.Count)// Выбор комнаты
            {
                ControlDevices.ControlDevice(room.Devices[deviceChoice - 1]);
            }
            else if (deviceChoice == room.Devices.Count + 1)
            {
                ConsoleColors.SetOrangeConsoleColor();
                Console.WriteLine("Возврат к выбору комнаты.");
                break;
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.WriteLine("Неверный выбор. Введите корректное число.");
            }
        }
    }
}
