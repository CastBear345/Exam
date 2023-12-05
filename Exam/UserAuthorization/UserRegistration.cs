using System;
using System.Collections.Generic;
using System.Threading;

bool isOpenInterface = true;

string? nameUser = "Undefined";
string? passwordUser = "Undefined";

while (isOpenInterface)
{
    Console.Write("\n");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\t-->>-- РегиСтрацИя умНогО дОмА --<<--\n\n");
    Console.Write(" Зарегистрироваться: - a\n Как администратор: - b\n");
    Console.Write("\n --Панель команд: ");
    string? controlPanel = Console.ReadLine();

    if (controlPanel == "a" ||controlPanel == "A")
    {
        Console.Write("\n Введите имя: ");
        nameUser = Console.ReadLine();

        Console.Write(" Введите пароль: ");
        passwordUser = (Console.ReadLine());
    }
    else if (controlPanel == "b" || controlPanel == "B")
    {
        Console.Write("\n Введите имя: ");
        nameUser = Console.ReadLine();

        Console.Write(" Введите пароль: ");
        passwordUser = Console.ReadLine();
        if (nameUser == Authorization._ADMIN_NAME && passwordUser == Authorization._ADMIN_PASSWORD)
        {
            Console.Write("\n");
            Console.Write(" -->> Загрузка <<--");
            Console.WriteLine("\n");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write("\r"+i.ToString()+"%");
                Thread.Sleep(120);
            }
            Console.WriteLine(" Добро пожаловать глава");
        }
        else
        {
            Console.WriteLine($"Повторите еще раз");
        }
    }
    else
    {
        Console.WriteLine("\n\tВозникли ошибки с вводом\n1 - Вы ввели не те команты\n2 - Для других " +
            "языков стандарты не устоновлены");
    }

    Console.ReadKey();
    Console.Clear();
}