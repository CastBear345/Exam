using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class SmartLock : Device
{
    public static string Password { get; set; }

    public SmartLock(string name, string passcode) : base(name)
    {
        IsLocked = true; // Изначально замок закрыт
        Password = "12345";
        SetPassword(passcode);
    }

    public static void GetChangeSmartLock()
    {
        if (IsLocked == false)
        {
            ConsoleColors.SetOrangeConsoleColor();
            Console.Write("Введите измененный пароль: ");
            if (int.TryParse(Console.ReadLine(), out int password))
            {
                SetPassword(password.ToString());
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.WriteLine("Неверный ввод. Пароль должен быть числом.");
            }
        }
        else
        {
            ConsoleColors.SetOrangeConsoleColor();
            Console.Write("Замок в комнате закрыт.");
            Console.Write("Введите пароль: ");
            if (int.TryParse(Console.ReadLine(), out int password))
            {
                UnlockWithPassword(password.ToString());
            }
            else
            {
                ConsoleColors.SetRedConsoleColor();
                Console.WriteLine("Неверный ввод. Пароль должен быть числом.");
            }
        }
    }

    public static void GetSetSmartLock()
    {
        ConsoleColors.SetOrangeConsoleColor();
        Console.Write("Введите пароль: ");
        if (int.TryParse(Console.ReadLine(), out int password))
        {
            UnlockWithPassword(password.ToString());
        }
        else
        {
            ConsoleColors.SetRedConsoleColor();
            Console.WriteLine("Неверный ввод. Пароль должен быть числом.");
        }
    }

    public static void Lock()
    {
        IsLocked = true;
        Console.WriteLine($"{Name} закрыт");
    }

    public static void Unlock()
    {
        IsLocked = false;
        Console.WriteLine($"{Name} открыт");
    }

    public static void SetPassword(string newPassword)
    {
        if (ValidatePassword(newPassword) == true)
        {
            Password = newPassword;
            Console.WriteLine($"{Name} пароль установлен");
        }
    }

    public static void UnlockWithPassword(string enteredPassword)
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

    private static bool ValidatePassword(string inputPassword)
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