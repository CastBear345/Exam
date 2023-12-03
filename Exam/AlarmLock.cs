using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class AlarmClock : Device
{
    public string AlarmTime { get; set; }

    public AlarmClock(string name) : base(name)
    {
        AlarmTime = "08:00"; // Начальное время будильника
    }

    public void SetAlarmTime(string newTime)
    {
        AlarmTime = newTime;
        Console.WriteLine($"{Name} время будильника установлено на {AlarmTime}");
    }

    public void ChangeAlarmTime(string newTime)
    {
        if (AlarmTime != newTime)
        {
            SetAlarmTime(newTime);
        }
        else
        {
            Console.WriteLine($"{Name} время будильника уже установлено на {AlarmTime}");
        }
    }

    public void Snooze()
    {
        Console.WriteLine($"{Name} прерывает звонок будильника на 10 минут (режим сна).");
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} время будильника: {AlarmTime}");
    }
}