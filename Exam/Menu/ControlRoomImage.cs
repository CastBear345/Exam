using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

public class ControlRoomsImages
{
    // Метод для работы с прогрузкой изображений комнат
    public static void ControlRoomImage(Room room)
    {
        if (room.Name is "Гостиная")
        {
            LivingRoom.GetLivingRoom(1, true);
        }
        else if (room.Name is "Спальня")
        {
            BedRoom.GetBedRoom(1, true);
        }
        else if (room.Name is "Ванная")
        {
            BathRoom.GetBathRoom(1, true);
        }
        else if (room.Name is "Кухня")
        {
            Kitchen.GetKitchen(2, true);
        }
        else if (room.Name is "Детская")
        {
            ChildrensRoom.GetChildrensRoom(1, true);
        }
    }
}
