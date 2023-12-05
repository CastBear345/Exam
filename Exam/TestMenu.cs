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
                                           "|        Кухня       |\n"+
                                           "╚════════════════════╝\n",
                           action = GetKitchenDevise ,
                        },
                        new MenuSection
                        {
                             sectionName = "╔════════════════════╗\n" +
                                           "|       Ванная       |\n"+
                                           "╚════════════════════╝\n",
                           action = GetBathRoomDevise ,
                        },
                        new MenuSection
                        {
                               sectionName = "╔════════════════════╗\n" +
                                             "|      Детская       |\n"+
                                             "╚════════════════════╝\n",
                           action = GetChildrensRoomDevise ,
                        },
                         new MenuSection
                         {
                              sectionName = "╔════════════════════╗\n"+
                                            "|      Спальня       |\n"+
                                            "╚════════════════════╝\n",
                           action = GetBedRoomDevise ,
                         },
                           new MenuSection
                           {
                               sectionName = "╔════════════════════╗\n"+
                                             "|       Выход        |\n"+
                                             "╚════════════════════╝\n",
                                    action = OnExit
                           }
                    };


    public static List<MenuSection> livingRoom = new List<MenuSection>()
      {
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Лампа        |\n"+
                           "╚════════════════════╝\n",
                           action = GetLamp ,
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|     Телевизор      |\n"+
                           "╚════════════════════╝\n",
                           action = GetTelevision ,
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|     Термометр      |\n"+
                           "╚════════════════════╝\n",
                           action = GetThermostat ,
          },

          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Выход        |\n"+
                           "╚════════════════════╝\n",
             action = GetMainMenu,


          }

      };


    public static List<MenuSection> kitchen = new List<MenuSection>()
      {
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Лампа        |\n"+
                           "╚════════════════════╝\n",
                           action = GetLamp ,
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|     Термометр      |\n"+
                           "╚════════════════════╝\n",
                           action = GetThermostat ,
          },
           new MenuSection()
           {
              sectionName = "╔════════════════════╗\n" +
                            "║       Чайник       ║\n" +
                            "╚════════════════════╝\n",
                           action = GetKettle ,

           },

            new MenuSection()
            {
                sectionName = "╔════════════════════╗\n" +
                              "║Посудомоечная машина║\n" +
                              "╚════════════════════╝\n",
                           action = GetDishWasher ,
            },

          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Выход        |\n"+
                           "╚════════════════════╝\n",
             action = GetMainMenu,


          }

      };

    public static List<MenuSection> bathRoom = new List<MenuSection>()
    {
         new MenuSection()
            {
                sectionName ="╔════════════════════╗\n" +
                             "║       Лампа        ║\n" +
                             "╚════════════════════╝\n",
                action = GetLamp,
            },
          new MenuSection()
            {
                sectionName = "╔════════════════════╗\n" +
                              "║     Термометр      ║\n" +
                              "╚════════════════════╝\n",
                action = GetThermostat,
            },
          new MenuSection()
            {
                sectionName = "╔════════════════════╗\n" +
                              "║  Стиральная машина ║\n" +
                              "╚════════════════════╝\n",
                action = GetWashingMachine,
            },
           new MenuSection()
            {
                sectionName = "╔════════════════════╗\n" +
                              "║       Унитаз       ║\n" +
                              "╚════════════════════╝\n",
                action = GetToilet,


            },
            new MenuSection()
            {
                sectionName = "╔════════════════════╗\n" +
                              "║        Выйти       ║\n" +
                              "╚════════════════════╝\n",
                action = GetMainMenu,
            },

    };

    public static List<MenuSection> bedRoom = new List<MenuSection>()
      {
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Лампа        |\n"+
                           "╚════════════════════╝\n",
                action = GetLamp,
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|     Будильник      |\n"+
                           "╚════════════════════╝\n",
                action = GetAlarmLock,
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Замок        |\n"+
                           "╚════════════════════╝\n",
                action = GetSmartLock,
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|     Термометр      |\n"+
                           "╚════════════════════╝\n",
                action = GetThermostat,
          },

          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Выход        |\n"+
                           "╚════════════════════╝\n",
             action = GetMainMenu,


          }

      };

    public static List<MenuSection> childrensRoom = new List<MenuSection>()
      {
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Лампа        |\n"+
                           "╚════════════════════╝\n",
                action = GetLamp,
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|      Будильник     |\n"+
                           "╚════════════════════╝\n",
                action = GetAlarmLock,
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Замок        |\n"+
                           "╚════════════════════╝\n",
                action = GetSmartLock,
          },
          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|     Термометр      |\n"+
                           "╚════════════════════╝\n",
                action = GetThermostat,
          },

          new MenuSection
          {
             sectionName = "╔════════════════════╗\n"+
                           "|       Выход        |\n"+
                           "╚════════════════════╝\n",
             action = GetMainMenu,


          }

      };

    public static List<MenuSection> options = new List<MenuSection>(){
                new MenuSection
                {
                   sectionName = "╔════════════════════╗\n"+
                                 "|      Включить      |\n"+
                                 "╚════════════════════╝\n",
                      action = GetLamp,
                },
                new MenuSection
                {
                   sectionName = "╔════════════════════╗\n" +
                                 "|      Выключить     |\n" +
                                 "╚════════════════════╝\n",
                  action = GetAlarmLock,
                },
                new MenuSection
                {
                   sectionName = "╔════════════════════╗\n" +
                                 "| Изменить Параметры |\n" +
                                 "╚════════════════════╝\n",
                  action = GetSmartLock,
                },
                new MenuSection
                {
                   sectionName = "╔════════════════════╗\n" +
                                 "|    Дополнительно   |\n" +
                                 "╚════════════════════╝\n",
                   action = GetThermostat,
                },

                new MenuSection
                {
                   sectionName = "╔════════════════════╗\n" +
                                 "|       Выход        |\n" +
                                 "╚════════════════════╝\n",
                  action = GetMainMenu,


                }
    };

    ////////////////////////////////
    public static void GetLivingRoomDevise()
    {
        Navigation.ListNavigation(TestMenu.livingRoom);
    }
    public static void GetKitchenDevise()
    {
        Navigation.ListNavigation(TestMenu.kitchen);
    }
    public static void GetBathRoomDevise()
    {
        Navigation.ListNavigation(TestMenu.bathRoom);
    }
    public static void GetBedRoomDevise()
    {
        Navigation.ListNavigation(TestMenu.bedRoom);
    }
    public static void GetChildrensRoomDevise()
    {
        Navigation.ListNavigation(TestMenu.childrensRoom);
    }
    ////////////////////////////////

    ////////////////////////////////
    public static void GetLamp()
    {
        Navigation.ListNavigation(TestMenu.options);
    }
    public static void GetThermostat()
    {
        Navigation.ListNavigation(TestMenu.options);
    }
    public static void GetTelevision()
    {
        Navigation.ListNavigation(TestMenu.options);
    }
    public static void GetAlarmLock()
    {
        Navigation.ListNavigation(TestMenu.options);
    }
    public static void GetKettle()
    {
        Navigation.ListNavigation(TestMenu.options);
    }
    public static void GetToilet()
    {
        Navigation.ListNavigation(TestMenu.options);
    }
    public static void GetWashingMachine()
    {
        Navigation.ListNavigation(TestMenu.options);
    }
    public static void GetDishWasher()
    {
        Navigation.ListNavigation(TestMenu.options);
    }
    public static void GetSmartLock()
    {
        Navigation.ListNavigation(TestMenu.options);
    }
    /////////////////////////////////

    public static void GetMainMenu()
    {
        Navigation.ListNavigation(TestMenu.testMenu);
    }

    public static void OnExit()
    {
        Environment.Exit(0);
    }
}
