using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class Kettle : Device
{
    public Kettle(string name) : base(name){}

    public void BoilWater()
    {
        Console.WriteLine($"{Name} - Кипячение воды.");
        Thread.Sleep(6000);
        StartBoilingWater();
    }

    public void StartBoilingWater()
    {
        if (!IsOn)
        {
            TurnOn();
            BoilWater();
        }
        else
        {
            Console.WriteLine($"{Name} вода уже кипит.");
            Thread.Sleep(2000);
            Console.WriteLine($"{Name} чайник выключен.");
            IsOn = true;
        }
    }
}
