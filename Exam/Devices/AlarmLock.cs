using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class AlarmClock : Device
{
    public static string AlarmTime { get; set; }

    public AlarmClock(string name) : base(name)
    {
        AlarmTime = "08:00"; // Начальное время будильника
    }

    public static void GetAlarmTime()
    {
        ConsoleColors.SetOrangeConsoleColor();
        Console.Write("Введите сначала часы: ");
        if (int.TryParse(Console.ReadLine(), out int newHours))
        {
            if (newHours > -1 && 25 > newHours)
            {
                ConsoleColors.SetOrangeConsoleColor();
                Console.Write("Теперь введите минуты: ");
                if (int.TryParse(Console.ReadLine(), out int newMinute))
                {
                    if (newMinute > -1 && 59 > newMinute)
                    {
                        string newTime = newHours.ToString() + ":" + newMinute.ToString();
                        ChangeAlarmTime(newTime);
                    }
                    else
                    {
                        ConsoleColors.SetRedConsoleColor();
                        Console.WriteLine("Неверный ввод. Введите корректно минуты.");
                    }
                }
                else
                {
                    ConsoleColors.SetRedConsoleColor();
                    Console.WriteLine("Неверный ввод. Минуты должны быть числом.");
                }
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.WriteLine("Неверный ввод. Введите корректно часы.");
            }
        }
        else
        {
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("Неверный ввод. Время должно быть числом.");
        }
    }

    public static void SetAlarmTime(string newTime)
    {
        AlarmTime = newTime;
        Console.WriteLine($"{Name} время будильника установлено на {AlarmTime}");
    }

    public static void ChangeAlarmTime(string newTime)
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

    public static void Snooze()
    {
        Console.WriteLine($"{Name} прерывает звонок будильника на 10 минут (режим сна).");
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} время будильника: {AlarmTime}");
    }
}