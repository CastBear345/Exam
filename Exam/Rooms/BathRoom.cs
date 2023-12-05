using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

internal class BathRoom
{
    public static string[] Bathroommap = File.ReadAllLines(@"Bathroom.txt");
    public static bool[] BathroomSatings = new bool[4] { false, false, false, false };

    //метод для вызова "пример вызова   GetLivingRoom(1,true) первый параметр это индекс обьекта второй вкл,выкл
    //1 это лампа, 2 это телевизор, 3 это дверь она по умолчанию открыта, тоесть true
    public static void GetBathRoom(int obj, bool onoff)
    {
        char[,] room = MapFunctions.ConvertInFIleToCharArray(Bathroommap);

        bool lamp = BathroomSatings[0];
        bool washing = BathroomSatings[1];
        bool toilet = BathroomSatings[2];
        bool bide = BathroomSatings[3];



        if (obj == 1)
        {
            lamp = onoff;
        }
        else if (obj == 2)
        {
            washing = onoff;
        }
        else if (obj == 3)
        {
            toilet = onoff;
            if (toilet == true) { bide = false; }
        }

        BathRoom.BathRoomSetings(room, lamp, washing, toilet, bide);
    }
    public static void GetBathRoom(int obj, bool onoff, bool one)
    {
        char[,] room = MapFunctions.ConvertInFIleToCharArray(Bathroommap);

        bool lamp = BathroomSatings[0];
        bool washing = BathroomSatings[1];
        bool toilet = BathroomSatings[2];
        bool bide = BathroomSatings[3];
        if (obj == 1)
        {
            lamp = onoff;
        }
        else if (obj == 2)
        {
            washing = onoff;
        }
        else if (obj == 3)
        {
            toilet = onoff;
            bide = one;
        }
        //else if (obj == 4)
        //{
        //    toilet = onoff;
        //    bide = one;
        //}

        BathRoom.BathRoomSetings(room, lamp, washing, toilet, bide);
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
    public static void BathRoomSetings(char[,] map, bool lamp, bool washing, bool toilet, bool bide)
    {
        for (int y = 0; y < map.GetLength(1); y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                if (lamp == true && map[x, y] == '░' || lamp == true && map[x, y] == '║' || lamp == true && map[x, y] == '╚' || lamp == true && map[x, y] == '═' || lamp == true && map[x, y] == '╝')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (toilet == true && map[x, y] == '▒' && bide == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                if (toilet == true && map[x, y] == ',')
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                if (toilet != true && map[x, y] == '▒' && bide == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                if (washing == true && map[x, y] == '▓')
                {
                    Console.ForegroundColor = ConsoleColor.Red;

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
        bool[] setings = BathroomSatings;
        setings[0] = lamp;
        setings[1] = washing;
        setings[2] = toilet;
        setings[3] = bide;
        BathroomSatings = setings;

    }

}
