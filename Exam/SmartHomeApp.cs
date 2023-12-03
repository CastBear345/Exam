using System;
using System.Collections.Generic;

internal class SmartHomeApp
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
                if (rooms[roomChoice - 1].Devices[3 - 1] is SmartLock) {
                    if (rooms[roomChoice - 1].Devices[3 - 1].IsLocked == false)
                    {
                        ControlRoom(rooms[roomChoice - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Замок в этой комнате закрыт.");
                        Console.WriteLine("Введите пароль чтобы войти: ");
                        EditDeviceParameters(rooms[roomChoice - 1].Devices[3 - 1]);
                    }
                }
                else
                {
                    ControlRoom(rooms[roomChoice - 1]);
                }
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

            if (int.TryParse(Console.ReadLine(), out int deviceChoice) && deviceChoice >= 1 && deviceChoice <= room.Devices.Count)
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
            Console.WriteLine("2. Подсветка Вкл/Выкл");
            Console.WriteLine("3. Назад");

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
                        ((Lamp)device).MoodLighting();
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
        else if (device is AlarmClock)
        {
            Console.WriteLine("\nВыберите параметр для изменения:");
            Console.WriteLine("1. Будильник");
            Console.WriteLine("2. Назад");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                int newHours, newMinute;
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите сначала часы: ");
                        if (int.TryParse(Console.ReadLine(), out newHours))
                        {
                            if (newHours >= 0 && 24 <= newHours)
                            {
                                Console.Write("Теперь введите минуты: ");
                                if (int.TryParse(Console.ReadLine(), out newMinute))
                                {
                                    if (newMinute >= 0 && 59 <= newMinute)
                                    {
                                        string newTime = newHours.ToString() + ":" + newMinute.ToString();
                                        ((AlarmClock)device).ChangeAlarmTime(newTime);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный ввод. Введите корректно минуты.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Неверный ввод. Минуты должны быть числом.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Неверный ввод. Введите корректно часы.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод. Время должно быть числом.");
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
        else if (device is Television)
        {
            Console.WriteLine("\nВыберите параметр для изменения:");
            Console.WriteLine("1. Смотреть фильм");
            Console.WriteLine("2. Запустить игру");
            Console.WriteLine("3. Назад");

            int choice;
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
                            Console.WriteLine(movies[j]);
                        }
                        ch = Console.ReadLine();
                        if (ch is int)
                        {
                            i = int.Parse(ch);
                            if (i > movies.Count)
                            {
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
                            Console.WriteLine(games[j]);
                        }
                        ch = Console.ReadLine();
                        if (ch is int)
                        {
                            i = int.Parse(ch);
                            if (i > games.Count)
                            {
                                Console.WriteLine("Вы выбрали игру за списком, попробуйте снова. К сожалению больше игр нет.");
                            }
                            else
                            {
                                ((Television)device).VideoGame(games[i - 1]);
                            }
                        }
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
        else if (device is SmartLock)
        {
            Console.WriteLine("\nВыберите параметр для изменения:");
            Console.WriteLine("1. Изменить пароль");
            Console.WriteLine("2. Открыть замок");
            Console.WriteLine("3. Назад");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                int password;
                switch (choice)
                {
                    case 1:
                        if (((SmartLock)device).IsLocked == false)
                        {
                            Console.Write("Введите измененный пароль: ");
                            if (int.TryParse(Console.ReadLine(), out password))
                            {
                                ((SmartLock)device).SetPassword(password.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Неверный ввод. Пароль должен быть числом.");
                            }
                        }
                        else
                        {
                            Console.Write("Введите пароль: ");
                            if (int.TryParse(Console.ReadLine(), out password))
                            {
                                ((SmartLock)device).UnlockWithPassword(password.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Неверный ввод. Пароль должен быть числом.");
                            }
                        }
                        break;
                    case 2:
                        Console.Write("Введите пароль: ");
                        if (int.TryParse(Console.ReadLine(), out password))
                        {
                            ((SmartLock)device).UnlockWithPassword(password.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод. Пароль должен быть числом.");
                        }
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
        else if (device is Dishwasher)
        {
            Console.WriteLine("\nВыберите параметр для изменения:");
            Console.WriteLine("1. Включить посудомоечную машины.");
            Console.WriteLine("2. Назад");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ((Dishwasher)device).Start();
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
        else if (device is WashingMachine)
        {
            Console.WriteLine("\nВыберите параметр для изменения:");
            Console.WriteLine("1. Включить стиральную машину.");
            Console.WriteLine("2. Назад");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ((WashingMachine)device).Start();
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
        else if (device is Kettle)
        {
            Console.WriteLine("\nВыберите параметр для изменения:");
            Console.WriteLine("1. Включить чайник.");
            Console.WriteLine("2. Назад");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ((Kettle)device).StartBoilingWater();
                        break;
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