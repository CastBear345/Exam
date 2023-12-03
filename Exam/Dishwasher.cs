using System;
using System.Collections.Generic;

public class Dishwasher : Device
{
    public Dishwasher(string name) : base(name)
    {
    }

    public void Start()
    {
        Console.WriteLine($"{Name} - Запуск посудомоечной машины.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} - Остановка посудомоечной машины.");
    }
}
