using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class KitchenSet
    {
        public static List<MenuSection> KitchenRoomMenu = new List<MenuSection>()
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
                             + "    телевизор    \n"
                             + "╚               ╝\n",
                  map =true,
                action = TV,
            },

            new MenuSection()
            {
                 sectionName = "╔               ╗\n"
                             + "   посудомойка   \n"
                             + "╚               ╝\n",
                 map =true,
                action = KitchenSet.DishWaher,
            },

            new MenuSection()
            {
                 sectionName = "╔               ╗\n"
                             + "     чайник      \n"
                             + "╚               ╝\n",
                 map =true,
                action = KitchenSet.Kittle,
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
            OnOffSetings.HuiZnaet(2, 1, Menu.ShowKitchenRoom);
            Console.Clear();
        }

        public static void TV()
        {
            OnOffSetings.HuiZnaet(2, 2, Menu.ShowKitchenRoom);
            Console.Clear();
        }

        public static void Kittle()
        {
            OnOffSetings.HuiZnaet(2, 3, Menu.ShowKitchenRoom);
            Console.Clear();
        }
        public static void DishWaher()
        {
            OnOffSetings.HuiZnaet(2, 4, Menu.ShowKitchenRoom);
            Console.Clear();
        }
    }
}
