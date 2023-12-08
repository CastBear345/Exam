using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


public class Navigation
{



    public static void SelectMenu(int index, List<MenuSection> select)
    {



        foreach (var rasd in select)
        {

           


            if (rasd == select[index])
            {

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                
                Console.WriteLine(rasd.sectionName);


            }
            else
            {

                Console.WriteLine(rasd.sectionName);



            }

            Console.ResetColor();

        }
    }

    public static void ListNavigation(List<MenuSection> list)
    {

        int index = 0;
        SelectMenu(index, list);
        ConsoleKeyInfo key;

        do
        {

            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.DownArrow && index + 1 < list.Count)
            {
                if (index > list.Count) { index = index - 1; }
                index++;
                Console.Clear();
                SelectMenu(index, list);

            }
            if (key.Key == ConsoleKey.UpArrow && index - 1 >= 0)
            {
                index--;
                Console.Clear();
                SelectMenu(index, list);

            }
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                list[index].action();

                list[index].index = 1;



                SelectMenu(index, list);

                index = 0;
            }
        } while (key.Key != ConsoleKey.Enter
        );

        Console.ReadKey();




    }


    public static void SelectMenu(int index, List<MenuSection> select, Action map)
    {
       
        map();

        foreach (var rasd in select)
        {
            



            if (rasd == select[index])
            {

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
               
                Console.WriteLine(rasd.sectionName);


            }
            else
            {

                Console.WriteLine(rasd.sectionName);



            }

            Console.ResetColor();

        }
    }

    public static void ListNavigation(List<MenuSection> list, Action map)
    {

        int index = 0;
        SelectMenu(index, list, map);
        ConsoleKeyInfo key;

        do
        {

            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.DownArrow && index + 1 < list.Count)
            {
                if (index > list.Count) { index = index - 1; }
                index++;
                Console.Clear();
                if (list[index].map != false) { SelectMenu(index, list, map); }
                else
                {
                    SelectMenu(index, list);
                }


            }
            if (key.Key == ConsoleKey.UpArrow && index - 1 >= 0)
            {
                index--;
                Console.Clear();
                if (list[index].map != false) { SelectMenu(index, list, map); }
                else
                {
                    SelectMenu(index, list);
                }

            }
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                list[index].action();

                list[index].index = 1;
               // list[index].map = true;
                SelectMenu(index, list, map);

                index = 0;
            }
        } while (key.Key != ConsoleKey.Enter
        );

        Console.ReadKey();




    }


    public static int inputIndex { get; set; }
    public static void Greetings()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        string Greting = "████████████████████████████████████████\n████████████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█████████\n█████▀▀░░░░░░░░░░░░░░░░░░░░░░░░░▀███████\r\n████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██████\r\n███▀░░░░░▄▄▄░░░░░░░░▄▄▀███▄▄░░░░░░░█████\r\n██░░░░░░▀▀▀███▄▄░░░█▄▄█▀█▀▀▀▀░▀░▄▄░▀▀███\r\n█░░▄▄░▄▄░▄░░░█▀░░░░░░░░░░▀▄▄▄█▀▀▄░▀█░░▀█\r\n█░░░░▄░▀▀░░▄█▀░░░░░░▄▄░░░░░░░▄▄▀██▄░█░░█\r\n██░░░██░░░▀▀█▄░░░▀▀▀▄▀░▄▄▄███▀░▄█░░░▀░▄█\r\n██▄░██▀█▀▄▄▄▄▄█▄▄▄▄▄▀▀█▀░░▄███▀█▀░░░▄▄██\r\n███░████▄█▄░░█░░▄█░░▄▄███▀▀▀█▄▀░░░░▄████\r\n███░▀██████████████▀▀▀▀█░░░▄▀▀░░░░▄█████\r\n███░░██▀█▀██▀█▀░░▀█░░░░█▄█▀░░░░░▄███████\r\n███░░░░▀▀▀██▄██▄▄██▀▀▀▀▀░░░░░▄▄█████████\r\n██▀░░░░░░░░░░░░░░░░░░░░░░▄▄▄████████████\r\n██▄░░░░░░░░░░░░░░░░░░▄▄█████████████████\r\n████▄░░░░░░░░░▄▄▄▄▄█████████████████████\r\n████████████████████████████████████████";
        Console.WriteLine(Greting);

        Console.WriteLine(" Добро пожаловать в онлайн Кинотеатр ");
        Thread.Sleep(3000);
        Console.Clear();
        Console.ResetColor();
    }




}

