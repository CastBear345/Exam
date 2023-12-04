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
        ConsoleKeyInfo keyInfo;
        int number = 0;
        while (true)
        {
            do
            {
                Console.Clear();
                Menu.PrintFirst($"Управление комнатой {room.Name}");
                ControlRoomsImages.ControlRoomImage(room);// Создает рисунок комнаты
                Menu.PrintFirst("Выберите устройство для управления:");
                for (int i = 0; i < room.Devices.Count; i++)// Выводится список доступных устройств в этой комнате
                {
                    if (i == number)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    ConsoleColors.SetYellowConsoleColor();
                    Menu.PrintFirst($"{room.Devices[i].Name}");
                }
                Menu.PrintFirst("Назад");
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + room.Devices.Count()) % room.Devices.Count(); }
                if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % room.Devices.Count(); }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    ControlDevices.ControlDevice(room.Devices[number]);
                }

            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
