using System;
using System.Collections.Generic;

public class WashingMachine : Device
{
    public WashingMachine(string name) : base(name)
    {
    }

    public void Start()
    {
        Console.WriteLine($"{Name} - Запуск стиральной машины.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} - Остановка стиральной машины.");
    }

    public void TogglePower()
    {
        if (IsOn)
        {
            Stop();
        }
        else
        {
            Start();
        }
    }
}