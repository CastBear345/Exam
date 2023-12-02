using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Room> rooms = new List<Room>{
            new Room("Гостиная"),
            new Room("Спальня"),
            new Room("Ванная"),
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
            int roomChoice = Menu.ShowRoomMenu(rooms);

            if (roomChoice == rooms.Count + 1)
            {
                Console.WriteLine("Выход из Панели управления Умным Домом. До свидания!");
                break;
            }

            Room selectedRoom = rooms[roomChoice - 1];
            ControlRoom(selectedRoom);
        }
    }

    static void ControlRoom(Room room)
    {
        while (true)
        {
            int deviceChoice = Menu.ShowDeviceMenu(room);

            if (deviceChoice == room.Devices.Count + 1)
            {
                Console.WriteLine("Возврат к выбору комнаты.");
                break;
            }

            Device selectedDevice = room.Devices[deviceChoice - 1];
            ControlDevice(selectedDevice);
        }
    }

    static void ControlDevice(Device device)
    {
        while (true)
        {
            Console.Clear();
            device.DisplayStatus();

            int choice = Menu.ShowDeviceControlMenu();

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
            }
        }
    }
}