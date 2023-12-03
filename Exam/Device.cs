using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class Device
{

    public string Name { get; set; }
    public bool IsLocked { get; set; }
    private bool isOn;

    public bool IsOn
    {
        get { return isOn; }
        set
        {
            isOn = value;
        }
    }

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
        ConsoleColors.SetBlueConsoleColor();
        Console.WriteLine($"{Name} включено: {IsOn}");
    }
}