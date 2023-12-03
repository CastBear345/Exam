using System;

public static class ConsoleColors
{
    // не используем 
    public static void SetConsoleColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }
    // не удачнный фон сделаю новый
    public static void SetBackgroundColor(ConsoleColor color)
    {
        Console.BackgroundColor = color;
    }
    public static void ResetConsoleColor()
    {
        Console.ResetColor();
    }
    // красный текс 
    public static void SetRedConsoleColor()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    // зеленый текст
    public static void SetGreenConsoleColor()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    // синий текст
    public static void SetBlueConsoleColor()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    // Жельтый текст 
    public static void SetYellowConsoleColor()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}
