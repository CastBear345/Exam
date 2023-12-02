using System;
using System.Collections.Generic;

public class Menu
{
    public static int ShowRoomMenu(List<Room> rooms)
    {
        Console.WriteLine("\nВыберите комнату для управления:");
        for (int i = 0; i < rooms.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {rooms[i].Name}");
        }

        Console.WriteLine($"{rooms.Count + 1}. Выход");

        int roomChoice;
        while (!(int.TryParse(Console.ReadLine(), out roomChoice) && roomChoice >= 1 && roomChoice <= rooms.Count + 1))
        {
            Console.WriteLine("Неверный выбор. Введите корректное число.");
        }

        return roomChoice;
    }

    public static int ShowDeviceMenu(Room room)
    {
        Console.WriteLine($"\nУправление комнатой {room.Name}");
        Console.WriteLine("Выберите устройство для управления:");

        for (int i = 0; i < room.Devices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {room.Devices[i].Name}");
        }

        Console.WriteLine($"{room.Devices.Count + 1}. Назад");

        int deviceChoice;
        while (!(int.TryParse(Console.ReadLine(), out deviceChoice) && deviceChoice >= 1 && deviceChoice <= room.Devices.Count + 1))
        {
            Console.WriteLine("Неверный выбор. Введите корректное число.");
        }

        return deviceChoice;
    }

    public static void ShowDeviceControlMenu()
    {
        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("1. Включить");
        Console.WriteLine("2. Выключить");
        Console.WriteLine("3. Показать статус");
        Console.WriteLine("4. Изменить параметры");
        Console.WriteLine("5. Дополнительные функции");
        Console.WriteLine("4. Назад");
                               //я тута изменил
        //int choice;
        //while (!(int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4))
        //{
        //    Console.WriteLine("Неверный выбор. Введите корректное число.");
        //}

        //return choice;
    }
}