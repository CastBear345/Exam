using System;
using System.Collections.Generic;

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

