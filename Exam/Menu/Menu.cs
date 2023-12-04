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
        // Создаем список комнат
        List<Room> rooms = new List<Room>
        {
            new Room("Гостиная"),
            new Room("Спальня"),
            new Room("Ванная"),
            new Room("Кухня"),
            new Room("Детская")
        };

        // Добавляем устройства (лампы, термостаты) в каждую комнату
        rooms[0].AddDevice(new Lamp("Лампа в гостиной"));
        rooms[0].AddDevice(new Thermostat("Термостат в гостиной"));
        rooms[0].AddDevice(new Television("Телевизор в гостиной"));

        rooms[1].AddDevice(new Lamp("Лампа в спальне"));
        rooms[1].AddDevice(new Thermostat("Термостат в спальне"));
        rooms[1].AddDevice(new SmartLock("Замок в спальне", "12345"));
        rooms[1].AddDevice(new AlarmClock("Будильник в спальне"));

        rooms[2].AddDevice(new Lamp("Лампа в ванной"));
        rooms[2].AddDevice(new Thermostat("Термостат в ванной"));
        rooms[2].AddDevice(new Toilet("Унитаз в ванной")); //Унитаз
        rooms[2].AddDevice(new WashingMachine("Стиральная машина в ванной"));// стиралка

        rooms[3].AddDevice(new Lamp("Лампа в Кухне"));
        rooms[3].AddDevice(new Thermostat("Термостат в Кухне"));
        rooms[3].AddDevice(new Dishwasher("Посудомойка в Кухне"));//Посудамойка
        rooms[3].AddDevice(new Kettle("Чайник в Кухне")); // Добавление чайника

        rooms[4].AddDevice(new Lamp("Лампа в Детской"));
        rooms[4].AddDevice(new Thermostat("Термостат в Детской"));
        rooms[4].AddDevice(new SmartLock("Замок в Детской", "12345"));

        Console.Clear();

        // Главный цикл управления
        for (int i = 0; i < rooms.Count; i++)
        {
            // Выводим приветствие
            ConsoleColors.SetBlueConsoleColor();
            ShowMenu(rooms[i]);

            int roomChoice;
            if (int.TryParse(Console.ReadLine(), out roomChoice) && roomChoice >= 1 && roomChoice <= rooms.Count)// Проверка существует ли введенная комната
            {

            }
            else if (roomChoice == rooms.Count + 1)
            {
                ConsoleColors.SetOrangeConsoleColor();
                Console.WriteLine("Выход из Панели управления Умным Домом. До свидания!");
                break;
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.Clear();
                Console.WriteLine("Неверный выбор. Введите корректное число.");
            }
        }
    }

    public static void ShowMenu(Room rooms)
    {
        ConsoleKeyInfo keyInfo;
        List<MenuHelpers> options = MenuHelpers.options;
        int number = 0;


        do
        {
            PrintFirst("Панель управления");



            for (int NumberCinema = 0; NumberCinema < options.Count; NumberCinema++)
            {

                if (NumberCinema == number)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine(options[NumberCinema].Title);

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.UpArrow) { number = (number - 1 + options.Count()) % options.Count(); }
            if (keyInfo.Key == ConsoleKey.DownArrow) { number = (number + 1) % options.Count(); }

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (rooms.Devices[3] is SmartLock)
                {// Проверка на существование зомка в комнате
                    if (rooms.Devices[3].IsLocked == false) // Проверка открыт ли замок к комнате
                    {
                        ControlRooms.ControlRoom(rooms);
                    }
                    else
                    {
                        ConsoleColors.SetRedConsoleColor();
                        ConsoleColors.SetYellowConsoleColor();
                        Console.WriteLine("Замок в этой комнате закрыт.");
                        Console.WriteLine("Введите пароль чтобы войти: ");
                        EditDevicesParameters.EditDeviceParameters(rooms.Devices[3 - 1]);
                    }
                }
                else
                {
                    ControlRooms.ControlRoom(rooms);
                }
            }

        } while (keyInfo.Key != ConsoleKey.Escape);



    }





    public static void PrintFirst(string? name)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔════════════════════╗");
        Console.WriteLine($"║       {name}      ║");
        Console.WriteLine("╚════════════════════╝");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;

        Console.WriteLine();
    }
}