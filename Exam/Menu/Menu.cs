using SmartHome.RoomSetings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Menu
    {
        public static List<MenuSection> MainMenu = new List<MenuSection>()
        {
            new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "    гостинная    \n"
                            + "╚               ╝\n",

                action = Menu.ShowLivingRoom,
                map = false



            },
            new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "      кухня      \n"
                            + "╚               ╝\n",
                action = Menu.ShowKitchenRoom,
                 map = false

            },
            new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "     детская     \n"
                            + "╚               ╝\n",
                action = Menu.ShowChildrensRoom,
                 map = false

            },
            new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "     ванная      \n"
                            + "╚               ╝\n",
                action = Menu.ShowBathRoom,
                 map = false

            },
            new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "     спальня     \n"
                            + "╚               ╝\n",
                action = Menu.ShowBedRoom,
                 map = false

            },
            new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "      выход      \n"
                            + "╚               ╝\n",
                action = Menu.OnExit,

            },

        };


       

       

        public static List<MenuSection> ChildrensRoomMenu = new List<MenuSection>()
        {
            new MenuSection()
            {
                 sectionName = "╔               ╗\n"
                             + "      лампа      \n"
                             + "╚               ╝\n", 
                 map =true,
                //action = ,
            },
             new MenuSection()
            {
                sectionName = "╔               ╗\n"
                            + "    будильник    \n"
                            + "╚               ╝\n",  
                map =true,
                //action = ,

            },
            new MenuSection()
            {
                 sectionName = "╔               ╗\n"
                             + "      дверь      \n"
                             + "╚               ╝\n",  
                    map =true,
                //action = ,
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

       

       
        public static void ShowMainMenu()
        {
            Navigation.ListNavigation(Menu.MainMenu);
        }

        public static void ShowLivingRoom()
        {
           
            Navigation.ListNavigation(LivingRoomSet.LivingRoomMenu, LivingRoom.GetLivingRoom);
            LivingRoom.GetLivingRoom();
        }

        public static void ShowBathRoom()
        {
            Navigation.ListNavigation(BathRoomSet.BathRoomMenu,BathRoom.GetBathRoom);
            BathRoom.GetBathRoom();
        }

        public static void ShowBedRoom()
        {
            Navigation.ListNavigation(BedRoomSet.BedRoomMenu,BedRoom.GetBedRoom);
            BedRoom.GetBedRoom();
        }

        public static void ShowChildrensRoom()
        {
            Navigation.ListNavigation(ChildrensRoomSet.ChildrensRoomMenu, ChildrensRoom.GetChildrensRoom);
            ChildrensRoom.GetChildrensRoom();
        }

        public static void ShowKitchenRoom()
        {
            Navigation.ListNavigation(KitchenSet.KitchenRoomMenu, Kitchen.GetKitchen);
            Kitchen.GetKitchen();
        }

        public static void OnExit()
        {
            Environment.Exit(0);
        }

    }
}
