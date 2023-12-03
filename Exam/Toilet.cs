using System;
using System.Collections.Generic;

public class Toilet : Device
{
    public Toilet(string name) : base(name)
    {
    }

    public void Flush()
    {
        Console.WriteLine($"{Name} - Спуск воды.");
    }

    public void WashBottom()
    {
        Console.WriteLine($"{Name} - Мойка 5 точек.");
    }

    public void UseToilet()
    {
        Flush();
        WashBottom();
    }
}