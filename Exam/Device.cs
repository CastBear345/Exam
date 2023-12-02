using System;
using System.Collections.Generic;

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