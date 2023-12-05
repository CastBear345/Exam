using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class Device
{

    public static string Name { get; set; }
    public static bool IsLocked { get; set; }
    private static bool isOn;

    public static bool IsOn
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

    public static void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Name} включено");
    }

    public static void TurnOff()
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