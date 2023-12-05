using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

public class EditDevicesParameters
{
    private static List<MenuSection> options1 = new List<MenuSection>(){
                new MenuSection
                {
                   sectionName = "╔                    ╗\n"+
                                 "        Яркость       \n"+
                                 "╚                    ╝\n",
                  action = Lamp.SetBrightness,
                },
                new MenuSection
                {
                   sectionName = "╔                    ╗\n" +
                                 "       Подсветка      \n" +
                                 "╚                    ╝\n",
                  action = Lamp.MoodLighting,
                },
                new MenuSection
                {
                   sectionName = "╔                    ╗\n" +
                                 "        Выход         \n" +
                                 "╚                    ╝\n",
                  action = TestMenu.GetMainMenu,


                },
     };
    // Метод для изменения параметров устройства (например, яркости лампы или температуры термостата)
    public static void GetLampEdit() {
        Navigation.ListNavigation(EditDevicesParameters.options1, null);
    }

     private static List<MenuSection> options2 = new List<MenuSection>(){
                new MenuSection
                {
                   sectionName = "╔                    ╗\n"+
                                 "      Температура     \n"+
                                 "╚                    ╝\n",
                  action = Thermostat.GetTemperature,
                },
                new MenuSection
                {
                   sectionName = "╔                    ╗\n" +
                                 "        Выход         \n" +
                                 "╚                    ╝\n",
                  action = TestMenu.GetMainMenu,


                },
     };
    public static void GetThermostatEdit()
    {
        Navigation.ListNavigation(EditDevicesParameters.options2, null);
    }

    private static List<MenuSection> options3 = new List<MenuSection>(){
                new MenuSection
                {
                   sectionName = "╔                    ╗\n"+
                                 "       Будильник      \n"+
                                 "╚                    ╝\n",
                  action = AlarmClock.GetAlarmTime,
                },
                new MenuSection
                {
                   sectionName = "╔                    ╗\n" +
                                 "        Выход         \n" +
                                 "╚                    ╝\n",
                  action = TestMenu.GetMainMenu,


                },
     };

    public static void GetAlarmLockEdit()
    {
        Navigation.ListNavigation(EditDevicesParameters.options3, null);
    }

    private static List<MenuSection> options4 = new List<MenuSection>(){
                new MenuSection
                {
                   sectionName = "╔                    ╗\n"+
                                 "    Изменить пароль   \n"+
                                 "╚                    ╝\n",
                  action = SmartLock.GetChangeSmartLock,
                },
                new MenuSection
                {
                   sectionName = "╔                    ╗\n" +
                                 "     Открыть замок    \n" +
                                 "╚                    ╝\n",
                  action = SmartLock.GetSetSmartLock,
                },
                new MenuSection
                {
                   sectionName = "╔                    ╗\n" +
                                 "        Выход         \n" +
                                 "╚                    ╝\n",
                  action = TestMenu.GetMainMenu,


                },
     };

    public static void GetSmartLockEdit()
    {
        Navigation.ListNavigation(EditDevicesParameters.options4, null);
    }
}
