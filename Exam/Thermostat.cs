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
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} температура: {Temperature} градусов Цельсия");
    }

    public void SetTemperature(int newTemperature)
    {
        Temperature = newTemperature;
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} температура установлена на {Temperature} градусов Цельсия");
    }

    public void VacationMode()
    {
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} включен режим отпуска для энергосбережения.");
    }
}