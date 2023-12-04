using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    internal class MapFunctions
    {
        public static char[,] ConvertInFIleToCharArray(string[] path)
        {
          

            char[,] map = new char[GetMaxLength(path), path.Length];

            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = path[y][x];
                }
            }

            return map;
        }

        public static int GetMaxLength(string[] lines )
        {
            int maxLength = lines[0].Length;
            foreach(var line in lines)
                if(line.Length > maxLength)
                    maxLength = line.Length;

            return maxLength;

        }
    }