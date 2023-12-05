using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class TestMenu
{
    public static List<MenuSection> testMenu = new List<MenuSection>()
                    {
                        new MenuSection
                        {
                           sectionName = "╔════════════════════╗\n" +
                                         "|     Гостинная      |\n"+
                                         "╚════════════════════╝\n" ,
                           action = GetLivingRoomDevise ,

                        },
                        new MenuSection
                        {
                             sectionName = "╔════════════════════╗\n" +
                                           "|        кухня       |\n"+
                                           "╚════════════════════╝\n"
                        },
                        new MenuSection
                        {
                             sectionName = "╔════════════════════╗\n" +
                                           "|       ванная       |\n"+
                                           "╚════════════════════╝\n"
                        },
                        new MenuSection
                        {
                               sectionName = "╔════════════════════╗\n" +
                                             "|      детская       |\n"+
                                             "╚════════════════════╝\n"
                        },
                         new MenuSection
                         {
                              sectionName = "╔════════════════════╗\n"+
                                            "|      спальня       |\n"+
                                            "╚════════════════════╝\n"
                         },
                           new MenuSection
                           {
                               sectionName = "╔════════════════════╗\n"+
                                             "|       выход        |\n"+
                                             "╚════════════════════╝\n",
                                    action = OnExit
                           }
                    };


    public static List<MenuSection> livingRoom = new List<MenuSection>()
      {
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       лампа        |\n"+
                           "╚════════════════════╝\n"
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|     телевизор      |\n"+
                           "╚════════════════════╝\n"
          },

          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       выход        |\n"+
                           "╚════════════════════╝\n",
             action = GetMainMenu,


          }

      };


    public static List<MenuSection> kitchen = new List<MenuSection>()
      {
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       лампа        |\n"+
                           "╚════════════════════╝\n"
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|     телевизор      |\n"+
                           "╚════════════════════╝\n"
          },
           new MenuSection()
           {
              sectionName = "╔════════════════════╗\n" +
                            "║        Чайник      ║\n" +
                            "╚════════════════════╝",

           },

            new MenuSection()
            {
                sectionName = "╔════════════════════╗\n" +
                              "║  Стиральная машина ║\n" +
                              "╚════════════════════╝",
            },

          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       выход        |\n"+
                           "╚════════════════════╝\n",
             action = GetMainMenu,


          }

      };

    public static List<MenuSection> BathRoom = new List<MenuSection>()
    {
         new MenuSection()
            {
                sectionName ="╔════════════════════╗\n" +
                             "║        Лампа       ║\n" +
                             "╚════════════════════╝",
            },
          new MenuSection()
            {
                sectionName = "╔════════════════════╗\n" +
                              "║  Стиральная машина ║\n" +
                              "╚════════════════════╝",
            },
           new MenuSection()
            {
                sectionName = "╔════════════════════╗\n" +
                              "║       Унитаз       ║\n" +
                              "╚════════════════════╝",


            },
            new MenuSection()
            {
                sectionName = "╔════════════════════╗\n" +
                              "║        Выйти       ║\n" +
                              "╚════════════════════╝\n",
            },

    };

    public static List<MenuSection> bedRoom = new List<MenuSection>()
      {
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       лампа        |\n"+
                           "╚════════════════════╝\n"
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|     будильник      |\n"+
                           "╚════════════════════╝\n"
          },

          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       выход        |\n"+
                           "╚════════════════════╝\n",
             action = GetMainMenu,


          }

      };

    public static List<MenuSection> childrensRoom = new List<MenuSection>()
      {
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       лампа        |\n"+
                           "╚════════════════════╝\n"
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|      будильник     |\n"+
                           "╚════════════════════╝\n"
          },

          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       выход        |\n"+
                           "╚════════════════════╝\n",
             action = GetMainMenu,


          }

      };


    public static void GetLivingRoomDevise()
    {
        Navigation.ListNavigation(TestMenu.livingRoom);
    }
    public static void GetMainMenu()
    {
        Navigation.ListNavigation(TestMenu.testMenu);
    }

    public static void OnExit()
    {
        Environment.Exit(0);
    }






}
