using System;
using System.Collections.Generic;

public class Thermostat : Device
{
    public static int Temperature { get; set; }

    public Thermostat(string name) : base(name)
    {
        Temperature = 22; // Начальная температура
    }

    public static void GetTemperature()
    {
        ConsoleColors.SetOrangeConsoleColor();
        Console.Write("Введите новую температуру: ");
        if (int.TryParse(Console.ReadLine(), out int temperature))
        {
            SetTemperature(temperature);
        }
        else
        {
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("Неверный ввод. Температура должна быть числом.");
        }
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} температура: {Temperature} градусов Цельсия");
    }

    public static void SetTemperature(int newTemperature)
    {
        Temperature = newTemperature;
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} температура установлена на {Temperature} градусов Цельсия");
    }

    public static void VacationMode()
    {
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} включен режим отпуска для энергосбережения.");
    }
}