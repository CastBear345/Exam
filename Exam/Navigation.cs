using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    public class Navigation
    {
        public static void SelectMenu(int index, List<MenuSection> select, string? str)
        {

            // Console.Clear();

            // Console.WriteLine(select[index].sectionName);
           
            ControlRoomsImages.ControlRoomImage(str);
            Console.WriteLine();
            foreach (var rasd in select)
            {
            //MenuSection.Index(index);
                if (rasd == select[index])
                {   
                    
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(rasd.sectionName);

            }
                else
                {
                    Console.WriteLine(rasd.sectionName);

                }

                Console.ResetColor();

            }
        }

        public static void ListNavigation(List<MenuSection> list, string? str)
        {
          
            int index = 0;
            SelectMenu(index, list, str);
            ConsoleKeyInfo key;

            do
            {
                
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow && index + 1 < list.Count)
                {
                    if (index > list.Count) { index = index - 1; }
                    index++;
                    Console.Clear();
                    SelectMenu(index, list, str);
                    
                }
                if (key.Key == ConsoleKey.UpArrow && index - 1 >= 0)
                {
                    index--;
                    Console.Clear();
                    SelectMenu(index, list, str);
                    
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();                    
                    list[index].action();
                    list[index].get();
                    list[index].index = 1;
                    //MenuSection.Index(index);
                    
                 
                    SelectMenu(index, list, str);

                    index = 0;
                }
            } while (key.Key != ConsoleKey.Enter
            );

            Console.ReadKey();
    }
}