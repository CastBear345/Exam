using System;
using System.Collections.Generic;

public class Toilet : Device // туелет  юбхщл 
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
        Console.WriteLine($"{Name} - Мойка 5 точки.");
    }

}
