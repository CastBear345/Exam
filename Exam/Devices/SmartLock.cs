using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class SmartLock : Device
{
    public string Password { get; set; }

    public SmartLock(string name, string passcode) : base(name)
    {
        IsLocked = true; // Изначально замок закрыт
        Password = "12345";
        SetPassword(passcode);
    }

    public void Lock()
    {
        IsLocked = true;
        Console.WriteLine($"{Name} закрыт");
    }

    public void Unlock()
    {
        IsLocked = false;
        Console.WriteLine($"{Name} открыт");
    }

    public void SetPassword(string newPassword)
    {
        if (ValidatePassword(newPassword) == true)
        {
            Password = newPassword;
            Console.WriteLine($"{Name} пароль установлен");
        }
    }

    public void UnlockWithPassword(string enteredPassword)
    {
        if (ValidatePassword(enteredPassword) == true)
        {
            Unlock();
        }
        else
        {
            Console.WriteLine("Неверный пароль. Доступ запрещен.");
        }
    }

    private bool ValidatePassword(string inputPassword)
    {
        bool isPasswordValid = Password.Equals(inputPassword) && inputPassword.Length >= 5;

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