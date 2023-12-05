using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    public class Navigation
    {

        public static void PrintMenuSelect(string name)
        {
            string space = "                      ";

            if (name.Length < space.Length )
            {

                Console.WriteLine("╔════════════════════╗");
                Console.WriteLine($"{name} ");
                Console.WriteLine("╚════════════════════╝");
            }

        }
        
        public static void SelectMenu(int index, List<MenuSection> select)
        {

            // Console.Clear();

            // Console.WriteLine(select[index].sectionName);
           
            foreach (var rasd in select)
            {
                //MenuSection.Index(index);

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
                    list[index].get();
                    list[index].index = 1;
                    //MenuSection.Index(index);
                    
                 
                    SelectMenu(index, list);

                    index = 0;
                }
            } while (key.Key != ConsoleKey.Enter
            );

            Console.ReadKey();
        }
    }