﻿using System;
using System.Collections.Generic;

public class Room
{
    public string Name { get; set; }
    public List<Device> Devices { get; set; }

    public Room(string name)
    {
        Name = name;
        Devices = new List<Device>();
    }

    public void AddDevice(Device device)
    {
        Devices.Add(device);
    }
}