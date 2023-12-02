using System;
using System.Collections.Generic;

public class Room
{
    public string Name { get; set; }
    public List<Device> Devices { get; set; }

    public Room(string name)
    {
        Name = name;
        Devices = new List<Device>();
    }

    public void AddDevice(Device device)
    {
        Devices.Add(device);
    }
}

public class Device
{
    public string Name { get; set; }
    public bool IsOn { get; set; }

    public Device(string name)
    {
        Name = name;
        IsOn = false;
    }

    public virtual void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Name} включено");
    }

    public virtual void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Name} выключено");
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"{Name} включено: {IsOn}");
    }
}

public class Lamp : Device
{
    public int Brightness { get; set; }

    public Lamp(string name) : base(name)
    {
        Brightness = 50; // Начальная яркость
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} яркость: {Brightness}%");
    }

    public void AdjustBrightness(int newBrightness)
    {
        // Убеждаемся, что яркость находится в пределах от 0 до 100
        Brightness = Math.Max(0, Math.Min(100, newBrightness));
        Console.WriteLine($"{Name} яркость установлена на {Brightness}%");
    }
}

public class Thermostat : Device
{
    public int Temperature { get; set; }

    public Thermostat(string name) : base(name)
    {
        Temperature = 22; // Начальная температура
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} температура: {Temperature} градусов Цельсия");
    }

    public void SetTemperature(int newTemperature)
    {
        Temperature = newTemperature;
        Console.WriteLine($"{Name} температура установлена на {Temperature} градусов Цельсия");
    }
}

public class SmartHomeApp
{
    public static void Main()
    {
        List<Room> rooms = new List<Room>
        {
            new Room("Гостиная"),
            new Room("Спальня"),
            new Room("Ванная"),
            // Можно добавить больше комнат
        };

        rooms[0].AddDevice(new Lamp("Лампа в гостиной"));
        rooms[0].AddDevice(new Thermostat("Термостат в гостиной"));
        rooms[1].AddDevice(new Lamp("Лампа в спальне"));
        rooms[1].AddDevice(new Thermostat("Термостат в спальне"));
        rooms[2].AddDevice(new Lamp("Лампа в ванной"));
        rooms[2].AddDevice(new Thermostat("Термостат в ванной"));

        Console.WriteLine("Панель управления Умным Домом");

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
            Console.WriteLine("4. Назад");

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
}