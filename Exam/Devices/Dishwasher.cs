using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class Dishwasher : Device
{
    public Dishwasher(string name) : base(name){}

    public void Start()
    {
        Console.WriteLine($"{Name} - Запуск посудомоечной машины.");
        Thread.Sleep(6000);
        Stop();
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} - Остановка посудомоечной машины.");
    }
}