using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class WashingMachine : Device
{
    public WashingMachine(string name) : base(name){}

    public void Start()
    {
        Console.WriteLine($"{Name} - Запуск стиральной машины.");
        Thread.Sleep(10000);
        Stop();
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} - Остановка стиральной машины.");
    }
}