using System;
using System.Collections.Generic;

public class Device
{
    public string Name { get; set; }
    public bool IsOn { get; set; }

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
        Console.WriteLine($"{Name} включено: {IsOn}");
    }
}

public class Lamp : Device
{
    public int Brightness { get; set; }

    public Lamp(string name) : base(name)
    {
        Brightness = 50; // Начальная яркость
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} яркость: {Brightness}%");
    }

    public void AdjustBrightness(int newBrightness)
    {
        Brightness = Math.Max(0, Math.Min(100, newBrightness));
        Console.WriteLine($"{Name} яркость установлена на {Brightness}%");
    }
}

public class Thermostat : Device
{
    public int Temperature { get; set; }

    public Thermostat(string name) : base(name)
    {
        Temperature = 22; // Начальная температура
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} температура: {Temperature} градусов Цельсия");
    }

    public void SetTemperature(int newTemperature)
    {
        Temperature = newTemperature;
        Console.WriteLine($"{Name} температура установлена на {Temperature} градусов Цельсия");
    }
}

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

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} время будильника: {AlarmTime}");
    }
}

public class Television : Device
{
    public int Volume { get; set; }

    public Television(string name) : base(name)
    {
        Volume = 50; // Начальная громкость
    }

    public void AdjustVolume(int newVolume)
    {
        Volume = Math.Max(0, Math.Min(100, newVolume));
        Console.WriteLine($"{Name} громкость установлена на {Volume}");
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} громкость: {Volume}");
    }
}

public class SmartLock : Device
{
    public bool IsLocked { get; set; }

    public SmartLock(string name) : base(name)
    {
        IsLocked = true; // Изначально замок закрыт
    }

    public void Lock()
    {
        IsLocked = true;
        Console.WriteLine($"{Name} замок закрыт");
    }

    public void Unlock()
    {
        IsLocked = false;
        Console.WriteLine($"{Name} замок открыт");
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} замок: {(IsLocked ? "закрыт" : "открыт")}");
    }
}
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
public class Dishwasher : Device
{
    public Dishwasher(string name) : base(name)
    {
    }

    public void Start()
    {
        Console.WriteLine($"{Name} - Запуск посудомоечной машины.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} - Остановка посудомоечной машины.");
    }
}
// Класс для представления посудомоечной машины
public class WashingMachine : Device
{
    public WashingMachine(string name) : base(name)
    {
    }

    public void Start()
    {
        Console.WriteLine($"{Name} - Запуск стиральной машины.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} - Остановка стиральной машины.");
    }
}
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

