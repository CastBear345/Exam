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

        // Выводим приветствие
        ConsoleColors.SetBlueConsoleColor();
        Console.WriteLine("Панель управления Умным Домом");

        // Главный цикл управления
        while (true)
        {
            ConsoleColors.SetGreenConsoleColor();
            Console.WriteLine("\nВыберите комнату для управления:");
            for (int i = 0; i < rooms.Count; i++)// Выводится список комнат
            {
                ConsoleColors.SetYellowConsoleColor();
                Console.WriteLine($"{i + 1}. {rooms[i].Name}");
            }
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine($"{rooms.Count + 1}. Выход");
            ConsoleColors.SetYellowConsoleColor();

            int roomChoice;
            if (int.TryParse(Console.ReadLine(), out roomChoice) && roomChoice >= 1 && roomChoice <= rooms.Count)// Проверка существует ли введенная комната
            {
                if (rooms[roomChoice - 1].Devices[3 - 1] is SmartLock)
                {// Проверка на существование зомка в комнате
                    if (rooms[roomChoice - 1].Devices[3 - 1].IsLocked == false) // Проверка открыт ли замок к комнате
                    {
                        ControlRooms.ControlRoom(rooms[roomChoice - 1]);
                    }
                    else
                    {
                        ConsoleColors.SetRedConsoleColor();
                        ConsoleColors.SetYellowConsoleColor();
                        Console.WriteLine("Замок в этой комнате закрыт.");
                        Console.WriteLine("Введите пароль чтобы войти: ");
                        EditDevicesParameters.EditDeviceParameters(rooms[roomChoice - 1].Devices[3 - 1]);
                    }
                }
                else
                {
                    ControlRooms.ControlRoom(rooms[roomChoice - 1]);
                }
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
                Console.WriteLine("Неверный выбор. Введите корректное число.");
            }
        }
    }
}