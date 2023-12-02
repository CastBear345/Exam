using System;
using System.Collections.Generic;
internal class SmartHomeApp
{
    public static void Main()
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

        rooms[1].AddDevice(new Lamp("Лампа в спальне"));
        rooms[1].AddDevice(new Thermostat("Термостат в спальне"));

        rooms[2].AddDevice(new Lamp("Лампа в ванной"));
        rooms[2].AddDevice(new Thermostat("Термостат в ванной"));
        rooms[2].AddDevice(new Toilet("Унитаз в ванной")); //Унитас
        rooms[2].AddDevice(new WashingMachine("Стиральная машина в ванной"));// стиралка

        rooms[3].AddDevice(new Lamp("Лампа в Кухне"));
        rooms[3].AddDevice(new Thermostat("Термостат в Кухне"));
        rooms[3].AddDevice(new Dishwasher("Посудомойка в Кухне"));//Посудамойка
        rooms[3].AddDevice(new Kettle("Чайник в Кухне")); // Добавление чайника

        rooms[4].AddDevice(new Lamp("Лампа в Детской"));
        rooms[4].AddDevice(new Thermostat("Термостат в Детской"));

        // Выводим приветствие
        Console.WriteLine("Панель управления Умным Домом");

        // Главный цикл управления
        while (true)
        {
            Console.WriteLine("\nВыберите комнату для управления:");
            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {rooms[i].Name}");
            }

            Console.WriteLine($"{rooms.Count + 1}. Выход");

            int roomChoice;
            if (int.TryParse(Console.ReadLine(), out roomChoice) && roomChoice >= 1 && roomChoice <= rooms.Count)
            {
                ControlRoom(rooms[roomChoice - 1]);
            }
            else if (roomChoice == rooms.Count + 1)
            {
                Console.WriteLine("Выход из Панели управления Умным Домом. До свидания!");
                break;
            }
            else
            {
                Console.WriteLine("Неверный выбор. Введите корректное число.");
            }
        }
    }

    // Метод для управления комнатой
    static void ControlRoom(Room room)
    {
        while (true)
        {
            Console.WriteLine($"\nУправление комнатой {room.Name}");
            Console.WriteLine("Выберите устройство для управления:");

            for (int i = 0; i < room.Devices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {room.Devices[i].Name}");
            }

            Console.WriteLine($"{room.Devices.Count + 1}. Назад");

            int deviceChoice;
            if (int.TryParse(Console.ReadLine(), out deviceChoice) && deviceChoice >= 1 && deviceChoice <= room.Devices.Count)
            {
                ControlDevice(room.Devices[deviceChoice - 1]);
            }
            else if (deviceChoice == room.Devices.Count + 1)
            {
                Console.WriteLine("Возврат к выбору комнаты.");
                break;
            }
            else
            {
                Console.WriteLine("Неверный выбор. Введите корректное число.");
            }
        }
    }

    // Метод для управления устройством
    static void ControlDevice(Device device)
    {
        while (true)
        {
            Console.Clear();
            device.DisplayStatus();

            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Включить");
            Console.WriteLine("2. Выключить");
            Console.WriteLine("3. Показать статус");
            Console.WriteLine("4. Изменить параметры");
            Console.WriteLine("5. Дополнительные функции");
            Console.WriteLine("6. Назад");

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
                        device.DisplayStatus();
                        break;
                    case 4:
                        EditDeviceParameters(device);
                        break;
                    case 5:
                        PerformAdditionalFunctions(device);
                        break;
                    case 6:
                        Console.WriteLine("Возврат к выбору устройства.");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Введите корректное число.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
    }

    // Метод для изменения параметров устройства (например, яркости лампы или температуры термостата)
    static void EditDeviceParameters(Device device)
    {
        if (device is Lamp)
        {
            Console.WriteLine("\nВыберите параметр для изменения:");
            Console.WriteLine("1. Яркость");
            Console.WriteLine("2. Назад");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите новую яркость (0-100%): ");
                        if (int.TryParse(Console.ReadLine(), out int brightness))
                        {
                            ((Lamp)device).AdjustBrightness(brightness);
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод. Яркость должна быть числом от 0 до 100.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Возврат к выбору действия.");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Введите корректное число.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
        else if (device is Thermostat)
        {
            Console.WriteLine("\nВыберите параметр для изменения:");
            Console.WriteLine("1. Температура");
            Console.WriteLine("2. Назад");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите новую температуру: ");
                        if (int.TryParse(Console.ReadLine(), out int temperature))
                        {
                            ((Thermostat)device).SetTemperature(temperature);
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод. Температура должна быть числом.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Возврат к выбору действия.");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Введите корректное число.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
        else
        {
            Console.WriteLine("Изменение параметров не поддерживается для этого устройства.");
        }

        // Ждем, чтобы пользователь мог увидеть результат изменения параметров
        Console.WriteLine("\nНажмите Enter, чтобы продолжить...");
        Console.ReadLine();
    }

    // Метод для выполнения дополнительных функций (например, спуск воды в унитазе)
    static void PerformAdditionalFunctions(Device device)
    {
        if (device is Toilet)
        {
            Console.WriteLine("\nДополнительные функции:");
            Console.WriteLine("1. Спустить воду");
            Console.WriteLine("2. Помыть 5 точку");
            Console.WriteLine("3. Назад");

            int choice;
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
                        Console.WriteLine("Возврат к выбору действия.");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Введите корректное число.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
        else
        {
            Console.WriteLine("Дополнительные функции не поддерживаются для этого устройства.");
        }

        // Ждем, чтобы пользователь мог увидеть результат выполнения дополнительных функций
        Console.WriteLine("\nНажмите Enter, чтобы продолжить...");
        Console.ReadLine();
    }
}