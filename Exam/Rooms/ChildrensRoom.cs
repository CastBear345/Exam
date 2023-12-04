using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



internal class ChildrensRoom
{
    public static string[] ChRmap = File.ReadAllLines(@"ChildrensRoom.txt");
    public static bool[] CrSatings = new bool[3] { false, false, true };

    //метод для вызова "пример вызова   GetLivingRoom(1,true) первый параметр это индекс обьекта второй вкл,выкл
    //1 это лампа, 2 это телевизор, 3 это дверь она по умолчанию открыта, тоесть true
    public static void GetChildrensRoom(int obj, bool onoff)
    {
        char[,] room = MapFunctions.ConvertInFIleToCharArray(ChRmap);

        bool lamp = CrSatings[0];
        bool tv = CrSatings[1];
        bool door = CrSatings[2];

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
            door = onoff;
        }

        ChildrensRoom.LivingRoomSetings(room, lamp, tv, door);
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




    //метод для включения и отключения обьектов
    public static void LivingRoomSetings(char[,] map, bool lamp, bool alarm, bool door)
    {
        for (int y = 0; y < map.GetLength(1); y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                if (lamp == true && map[x, y] == '░' || lamp == true && map[x, y] == '║' || lamp == true && map[x, y] == '╚' || lamp == true && map[x, y] == '═' || lamp == true && map[x, y] == '╝')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (alarm == true && map[x, y] == '▒')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (door == false && map[x, y] == ':')
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
        bool[] setings = CrSatings;
        setings[0] = lamp;
        setings[1] = alarm;
        setings[2] = door;

        CrSatings = setings;

    }

}