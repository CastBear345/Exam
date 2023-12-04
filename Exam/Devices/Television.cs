using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

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

    public void Movie(string movieTitle)
    {
        if (IsOn)
        {
            Console.WriteLine($"Начинается просмотр фильма: {movieTitle}.");
            Thread.Sleep(3000);
            WatchMovie(movieTitle);
        }
        else
        {
            Console.WriteLine($"{Name} выключен, включаю.");
            Thread.Sleep(3000);
            Console.WriteLine($"Начинается просмотр фильма: {movieTitle}.");
            Thread.Sleep(3000);
            WatchMovie(movieTitle);
        }
    }

    public void VideoGame(string gameTitle)
    {
        if (IsOn)
        {
            Console.WriteLine($"Запускается игра: {gameTitle}.");
            Thread.Sleep(3000);
            PlayGame(gameTitle);
        }
        else
        {
            Console.WriteLine($"{Name} выключен, включаю.");
            Thread.Sleep(3000);
            Console.WriteLine($"Запускается игра: {gameTitle}.");
            Thread.Sleep(3000);
            PlayGame(gameTitle);
        }
    }

    private void WatchMovie(string movieTitle)
    {
        if (movieTitle == "Годзилла против Конга")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы посмотрели Годзиллу и захотели себе ручного динозавра!");
        }
        else if (movieTitle == "Миссия Невыполнима")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы посмотрели Миссию Невыполнима и захотели сесть на диету ради хорошей формы!");
        }
        else if (movieTitle == "Барби")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы посмотрели Барби и закупили несколько постеров с Райаном Гослингом!");
        }
        else if (movieTitle == "Индиана Джонс")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы посмотрели Индиану Джонса и... все равно захотели похудеть");
        }
        else if (movieTitle == "Мстители")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы посмотрели Мстителей и найдя на улице камень пытались создать портал... сумасшедший");
        }
    }

    private void PlayGame(string movieTitle)
    {
        if (movieTitle == "Assasin's Creed")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы поиграли в Assasin's Creed!");
        }
        else if (movieTitle == "Resident Evil")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы поиграли в Resident Evil!");
        }
        else if (movieTitle == "Fallout")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы поиграли в Fallout!");
        }
        else if (movieTitle == "GTA V")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы поиграли в GTA V");
        }
        else if (movieTitle == "Fortnite")
        {
            Thread.Sleep(3000);
            Console.WriteLine("Вы поиграли в Fortnite");
        }
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"{Name} громкость: {Volume}");
    }
}