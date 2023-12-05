using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Menu
{
    public static void Start()
    {

        /*List<Room> rooms = MenuHelper.CreateRoom();
        ShowMenu(rooms);*/

    }

    public static void ShowMenu(List<Room> rooms)
    {

        ConsoleKeyInfo keyInfo;
        int number = 0;

        do
        {
            Console.Clear();
            PrintFirst("Панель управления");

            for (int NumberCinema = 0; NumberCinema < rooms.Count; NumberCinema++)
            {

                if (NumberCinema == number)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                PrintFirst(rooms[NumberCinema].Name);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + rooms.Count()) % rooms.Count(); }
            if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % rooms.Count(); }

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (rooms[number].Devices[2] is SmartLock)
                {// Проверка на существование зомка в комнате
                    if (rooms[number].Devices[2].IsLocked == false) // Проверка открыт ли замок к комнате
                    {
                        ControlRooms.ControlRoom(rooms[number]);
                    }
                    else
                    {
                        Console.Clear();
                        ConsoleColors.SetRedConsoleColor();
                        ConsoleColors.SetYellowConsoleColor();
                        EditDevicesParameters.EditDeviceParameters(rooms[number].Devices[2]);
                    }
                }
                else
                {
                    ControlRooms.ControlRoom(rooms[number]);
                }
            }

        } while (keyInfo.Key != ConsoleKey.Escape);

    }

    public static void PrintFirst(string? name)
    {

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔════════════════════╗");
        Console.WriteLine($"{name} ");
        Console.WriteLine("╚════════════════════╝");
        Console.BackgroundColor = ConsoleColor.Black;

        Console.WriteLine();
    }
}