using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

public class ControlRoomsImages
{
    // Метод для работы с прогрузкой изображений комнат
    public static void ControlRoomImage(string str)
    {
        if (str == "Гостиная")
        {
            LivingRoom.GetLivingRoomDevice(1, true);
        }
        else if (str == "Спальня")
        {
            BedRoom.GetBedRoom(1, true);
        }
        else if (str == "Ванная")
        {
            BathRoom.GetBathRoom(1, true);
        }
        else if (str == "Кухня")
        {
            Kitchen.GetKitchen(1, true);
        }
        else if (str == "Детская")
        {
            ChildrensRoom.GetChildrensRoom(1, true);
        }
    }
}
