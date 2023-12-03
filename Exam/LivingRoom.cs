using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    public class LivingRoom
    {
        public static string[] LRmap = File.ReadAllLines(@"TextFile1.txt");
    public static bool[] SaveSatings = new bool[3] {false,false,true };

        //метод для вызова "пример вызова   GetLivingRoom(1,true) первый параметр это индекс обьекта второй вкл,выкл
        //1 это лампа, 2 это телевизор, 3 это дверь она по умолчанию открыта, тоесть true
        public static void GetLivingRoom(int obj, bool onoff)
        {
            char[,] room = MapFunctions.ConvertInFIleToCharArray(LRmap);

            bool lamp = SaveSatings[0];
            bool tv = SaveSatings[1];
            bool door = SaveSatings[2];

            if (obj == 1)
            {
                lamp = onoff;
            } 
            else if (obj == 2)
            {
                tv = onoff;
            }
            else if(obj == 3)
            {
                door = onoff;
            }

            LivingRoom.LivingRoomSetings(room,lamp,tv,door);
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
        public static void LivingRoomSetings(char[,] map, bool lamp, bool tv, bool door)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if (lamp == true && map[x, y] == '░' || lamp == true && map[x, y] == '║' || lamp == true && map[x, y] == '╚' || lamp == true && map[x, y] == '═' || lamp == true && map[x, y] == '╝')
                    {                        
                        Console.ForegroundColor = ConsoleColor.Yellow;                       
                    }                 
                    if (tv == true && map[x, y] == '▒')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    if (door == false && map[x,y] == '▓')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    if (map[x, y] == '█')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                         Console.Write(map[x, y]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("\n");
            }
            bool[] setings = SaveSatings;
            setings[0] = lamp;
            setings[1] = tv;
            setings[2] = door;

            SaveSatings = setings;

        }


    }

