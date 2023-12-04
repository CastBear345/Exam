using System;
using System.Collections.Generic;

public class Toilet : Device
{
    public Toilet(string name) : base(name)
    {
    }

    public void Flush()
    {
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} - Спуск воды.");
    }

    public void WashBottom()
    {
        ConsoleColors.SetYellowConsoleColor();
        Console.WriteLine($"{Name} - Мойка 5той точки.");
    }

    public void UseToilet()
    {
        Flush();
        WashBottom();
    }
}