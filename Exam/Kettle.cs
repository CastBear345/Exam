﻿using System;
using System.Collections.Generic;

public class Kettle : Device
{
    public Kettle(string name) : base(name)
    {
    }

    public void BoilWater()
    {
        Console.WriteLine($"{Name} - Кипячение воды.");
    }
}
