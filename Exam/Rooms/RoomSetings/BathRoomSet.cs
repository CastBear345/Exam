using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.RoomSetings
{
    public class BathRoomSet
    {
        public static List<MenuSection> BathRoomMenu = new List<MenuSection>()
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
                             + "  смыть личинку  \n"
                             + "╚               ╝\n",
                 map =true,
                action = Toilet,
            },
            new MenuSection()
            {
                 sectionName = "╔                ╗\n"
                             + "  водный фистинг  \n"
                             + "╚                ╝\n",
                 map =true,
                action = Bide,
            },
            new MenuSection()
            {
                 sectionName = "╔               ╗\n"
                             + "    стиралка     \n"
                             + "╚               ╝\n",
                 map =true,
                action = Washing,
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
            OnOffSetings.HuiZnaet(4, 1, Menu.ShowBathRoom);
            Console.Clear();
        }
        public static void Washing()
        {
            OnOffSetings.HuiZnaet(4, 2, Menu.ShowBathRoom);
            Console.Clear();
        }

        public static void Toilet()
        {
            OnOffSetings.HuiZnaet(4, 3, Menu.ShowBathRoom);
            Console.Clear();
        }
        public static void Bide()
        {
            OnOffSetings.HuiZnaet(4, 3,true, Menu.ShowBathRoom);
            Console.Clear();
        }

    }
}
