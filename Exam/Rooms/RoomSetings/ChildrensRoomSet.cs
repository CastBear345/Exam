using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class ChildrensRoomSet
    {
        public static List<MenuSection> ChildrensRoomMenu = new List<MenuSection>()
        {
            new MenuSection()
            {
                 sectionName = "╔               ╗\n"
                             + "      лампа      \n"
                             + "╚               ╝\n",
                 map =true,
                action = Lamp,
            },
             new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "    будильник    \n"
                            + "╚               ╝\n",
                map =true,
                action = Alarm,

            },
            new MenuSection()
            {
                 sectionName = "╔               ╗\n"
                             + "      дверь      \n"
                             + "╚               ╝\n",
                    map =true,
                action = Door
                ,
            },
            new MenuSection()
            {
                 sectionName = "╔               ╗\n"
                             + "      выход      \n"
                             + "╚               ╝\n",
                 map =true,
                 action = Menu.ShowMainMenu,
            }
        };

        public static void Lamp()
        {
            OnOffSetings.HuiZnaet(3, 1, Menu.ShowChildrensRoom);
            Console.Clear();
        }

        public static void Alarm()
        {
            OnOffSetings.HuiZnaet(3, 2, Menu.ShowChildrensRoom);
            Console.Clear();
        }
        public static void Door()
        {
            OnOffSetings.HuiZnaet(3, 3, Menu.ShowChildrensRoom);
            Console.Clear();
        }
    }
}
