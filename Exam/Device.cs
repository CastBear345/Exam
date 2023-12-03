using System;
using System.Collections.Generic;

public class Device
{
    public string Name { get; set; }
    private bool isOn;

    public bool IsOn
    {
        get { return isOn; }
        private set
        {
            isOn = value;
            TogglePower(); // Вызываем TogglePower при изменении состояния
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

    public virtual void TogglePower()
    {
        Console.WriteLine($"{Name} включено: {IsOn}");
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"{Name} включено: {IsOn}");
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

    public void IncreaseVolume(int increment)
    {
        AdjustVolume(Volume + increment);
    }

    public void DecreaseVolume(int decrement)
    {
        AdjustVolume(Volume - decrement);
    }

    public void WatchMovie(string movieTitle)
    {
        if (IsOn)
        {
            Console.WriteLine($"{Name} начинает просмотр фильма: {movieTitle}.");
        }
        else
        {
            Console.WriteLine($"{Name} выключен, невозможно начать просмотр фильма.");
        }
    }

    public void PlayVideoGame(string gameTitle)
    {
        if (IsOn)
        {
            Console.WriteLine($"{Name} начинает игру: {gameTitle}.");
        }
        else
        {
            Console.WriteLine($"{Name} выключен, невозможно начать игру.");
        }
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
    public string Password { get; set; }

    public SmartLock(string name, string passcode) : base(name)
    {
        IsLocked = true; // Изначально замок закрыт
        SetPassword(passcode);
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

    public void ToggleLock()
    {
        if (!IsLocked)
        {
            Unlock();
        }
        else
        {
            Lock();
        }
    }

    public void SetPassword(string newPassword)
    {
        if (ValidatePassword(newPassword) == true)
        {
            Password = newPassword;
            Console.WriteLine($"{Name} пароль установлен");
            ToggleLock();
        }
    }

    public void UnlockWithPassword(string enteredPassword)
    {
        Console.Write($"Введите пароль для открытия {Name}: ");

        if (ValidatePassword(enteredPassword) == true)
        {
            ToggleLock();
        }
        else
        {
            Console.WriteLine("Неверный пароль. Доступ запрещен.");
        }
    }

    private bool ValidatePassword(string inputPassword)
    {
        bool isPasswordValid = Password.Equals(inputPassword) && inputPassword.Length >= 8;

        if (!isPasswordValid)
        {
            Console.WriteLine("Неверный формат пароля. Пароль должен быть не менее 8 символов.");
        }

        return isPasswordValid;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} замок: {(IsLocked ? "закрыт" : "открыт")}");
    }
}