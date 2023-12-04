using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

public class  MenuHelpers
{
    public static List<MenuHelpers> options = new List<MenuHelpers>()        {

            new MenuHelpers()
            {
                Title ="╔════════════════════╗\n" +
                       "║       Гостиная     ║\n" +
                       "╚════════════════════╝",
            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║       Спальня      ║\n" +
                        "╚════════════════════╝",
            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║       Ванная       ║\n" +
                        "╚════════════════════╝",

            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║        Кухня       ║\n" +
                        "╚════════════════════╝",

            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║       Детская      ║\n" +
                        "╚════════════════════╝",

            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║       Выйти        ║\n" +
                        "╚════════════════════╝\n",
            },
    };

    public static List<MenuHelpers> devices = new List<MenuHelpers>()        {

            new MenuHelpers()
            {
                Title ="╔════════════════════╗\n" +
                       "║        Лампа       ║\n" +
                       "╚════════════════════╝",
            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║       Термостат    ║\n" +
                        "╚════════════════════╝",
            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║        Замок       ║\n" +
                        "╚════════════════════╝",

            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║      Телевизор     ║\n" +
                        "╚════════════════════╝",

            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║      Будильник     ║\n" +
                        "╚════════════════════╝",

            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║  Стиральная машина ║\n" +
                        "╚════════════════════╝",
            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║       Унитаз       ║\n" +
                        "╚════════════════════╝",

            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║      Посудомойка   ║\n" +
                        "╚════════════════════╝",

            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║        Чайник      ║\n" +
                        "╚════════════════════╝",

            },
            new MenuHelpers()
            {
                Title = "╔════════════════════╗\n" +
                        "║        Выйти       ║\n" +
                        "╚════════════════════╝\n",
            },
    };

    public string Title { get; set; }
}