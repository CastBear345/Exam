using System;
using System.Collections.Generic;

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
        Brightness = Math.Max(0, Math.Min(100, newBrightness));
        Console.WriteLine($"{Name} яркость установлена на {Brightness}%");
    }

    public void MoodLighting()
    {
        if (!IsOn)
        {
            Console.WriteLine($"{Name} включает режим подсветки для создания уюта.");
            TurnOn();
        }
        else
        {
            Console.WriteLine($"{Name} выключен, невозможно включить режим подсветки.");
            TurnOff();
        }
    }
}