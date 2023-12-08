using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class BedRoomSet
    {
        public static List<MenuSection> BedRoomMenu = new List<MenuSection>()
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
                action = Door,
            },
            new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "      выход      \n"
                            + "╚               ╝\n",
                    map =true,
                 action = Menu.ShowMainMenu,

            },
        };

        public static void Lamp()
        {
            OnOffSetings.HuiZnaet(5, 1, Menu.ShowBedRoom);
            Console.Clear();
        }
        public static void Door()
        {
            OnOffSetings.HuiZnaet(5, 3, Menu.ShowBedRoom);
            Console.Clear();
        }

        public static void Alarm()
        {
            OnOffSetings.HuiZnaet(5, 2, Menu.ShowBedRoom);
            Console.Clear();
        }
    }
}
