using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

public class  MenuHelper
{

    // Создаем список комнат
    public static List<Room> rooms;

    // Статический конструктор
    public static List<Room> CreateRoom()
    {
        rooms = new List<Room>
        {
            new Room("Гостиная"),
            new Room("Спальня"),
            new Room("Ванная"),
            new Room("Кухня"),
            new Room("Детская")
        };

        // Добавляем устройства (лампы, термостаты) в каждую комнату
        rooms[0].AddDevice(new Lamp("Лампа в гостиной"));
        rooms[0].AddDevice(new Thermostat("Термостат в гостиной"));
        rooms[0].AddDevice(new Television("Телевизор в гостиной"));

        rooms[1].AddDevice(new Lamp("Лампа в спальне"));
        rooms[1].AddDevice(new Thermostat("Термостат в спальне"));
        rooms[1].AddDevice(new SmartLock("Замок в спальне", "12345"));
        rooms[1].AddDevice(new AlarmClock("Будильник в спальне"));

        rooms[2].AddDevice(new Lamp("Лампа в ванной"));
        rooms[2].AddDevice(new Thermostat("Термостат в ванной"));
        rooms[2].AddDevice(new Toilet("Унитаз в ванной")); //Унитаз
        rooms[2].AddDevice(new WashingMachine("Стиральная машина в ванной"));// стиралка

        rooms[3].AddDevice(new Lamp("Лампа в Кухне"));
        rooms[3].AddDevice(new Thermostat("Термостат в Кухне"));
        rooms[3].AddDevice(new Dishwasher("Посудомойка в Кухне"));//Посудамойка
        rooms[3].AddDevice(new Kettle("Чайник в Кухне")); // Добавление чайника

        rooms[4].AddDevice(new Lamp("Лампа в Детской"));
        rooms[4].AddDevice(new Thermostat("Термостат в Детской"));
        rooms[4].AddDevice(new SmartLock("Замок в Детской", "12345"));

        return rooms;
    }
}