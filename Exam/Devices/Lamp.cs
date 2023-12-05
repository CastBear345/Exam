using System;
using System.Collections.Generic;

public class Lamp : Device
{
    public static int Brightness { get; set; }

    public Lamp(string name) : base(name)
    {
        Brightness = 50; // Начальная яркость
    }

    public static void SetBrightness()
    {
        ConsoleColors.SetOrangeConsoleColor();
        Console.Write("Введите новую яркость (0-100%): ");
        if (int.TryParse(Console.ReadLine(), out int brightness))
        {
            AdjustBrightness(brightness);
        }
        else
        {
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("Неверный ввод. Яркость должна быть числом от 0 до 100.");
        }
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} яркость: {Brightness}%");
    }

    public static void AdjustBrightness(int newBrightness)
    {
        Brightness = Math.Max(0, Math.Min(100, newBrightness));
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} яркость установлена на {Brightness}%");
    }

    public static void MoodLighting()
    {
        if (!IsOn)
        {
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine($"{Name} включает режим подсветки для создания уюта.");
            TurnOn();
        }
        else
        {
            ConsoleColors.SetYellowConsoleColor();
            Console.WriteLine($"{Name} выключен, невозможно включить режим подсветки.");
            TurnOff();
        }
    }
}