using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class LivingRoomSet
    {

        public static List<MenuSection> LivingRoomMenu = new List<MenuSection>()
        {
            new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "    освещение    \n"
                            + "╚               ╝\n",
                map =true,
                action = LivingRoomSet.Lamp,

            },

            new MenuSection()
            {
                 sectionName = "╔               ╗\n"
                            +  "    телевизор    \n"
                            +  "╚               ╝\n",
                 map =true,
                action = TV,
            
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
            OnOffSetings.HuiZnaet(1,1,Menu.ShowLivingRoom);
            Console.Clear();
        }

        public static void TV()
        {
            OnOffSetings.HuiZnaet(1, 2, Menu.ShowLivingRoom);
            Console.Clear();
        }

    }
}
