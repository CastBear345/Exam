using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;





internal class Kitchen
{
    public static string[] Kitchenmap = File.ReadAllLines("Kitchen.txt");
    public static bool[] KitchenSatings = new bool[4] { false, false, false, false };

    //метод для вызова "пример вызова   GetLivingRoom(1,true) первый параметр это индекс обьекта второй вкл,выкл
    //1 это лампа, 2 это телевизор, 3 это дверь она по умолчанию открыта, тоесть true
    public static void GetKitchen(int obj, bool onoff)
    {
        char[,] room = MapFunctions.ConvertInFIleToCharArray(Kitchenmap);

        bool lamp = KitchenSatings[0];
        bool tv = KitchenSatings[1];
        bool kettle = KitchenSatings[2];
        bool dishwasher = KitchenSatings[3];
        if (obj == 1)
        {
            lamp = onoff;
        }
        else if (obj == 2)
        {
            tv = onoff;
        }
        else if (obj == 3)
        {
            kettle = onoff;
        }
        else if (obj == 4)
        {
            dishwasher = onoff;
        }

        Kitchen.KitchenSetings(room, lamp, tv, kettle, dishwasher);
    }


    //метод для проверки массива SaveSatings

    /* public static void Show()
     {
         bool[] set = SaveSatings;

         foreach(bool ru in set)
         {
             Console.WriteLine(ru);
         }
     }*/




    //метод для вывода и включения, отключения обьектов
    public static void KitchenSetings(char[,] map, bool lamp, bool tv, bool kettle, bool dishwasher)
    {
        for (int y = 0; y < map.GetLength(1); y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                if (lamp == true && map[x, y] == '░' || lamp == true && map[x, y] == '║' || lamp == true && map[x, y] == '╚' || lamp == true && map[x, y] == '═' || lamp == true && map[x, y] == '╝')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (tv == true && map[x, y] == '▓')
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                if (dishwasher == true && map[x, y] == '▒')
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                if (kettle == true && map[x, y] == '=')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                }
                if (map[x, y] == '█')
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(map[x, y]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("\n");
        }
        bool[] setings = KitchenSatings;
        setings[0] = lamp;
        setings[1] = tv;
        setings[2] = kettle;

        KitchenSatings = setings;

    }

}